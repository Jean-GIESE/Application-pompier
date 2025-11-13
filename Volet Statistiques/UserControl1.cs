using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SAE24_Théo_LUTHIN_TP4
{

    public partial class StatisticsForm : Form
    {

        public StatisticsForm()
        {
            InitializeComponent();
            comboBoxCaserne = new ComboBox();
            listBoxEnginUtilises = new ListBox();
            listBoxHeuresUtilisation = new ListBox();
            listBoxSinistres = new ListBox();
            listBoxHabilitations = new ListBox();
            listBoxPompiersParHabilitation = new ListBox();
            LoadData();
        }
        private void LoadData()
        {
            string connectionString = "tluthin\\SDIS67.db";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Chargement des données dans comboBoxCaserne
                string queryCaserne = "SELECT nom FROM Caserne";
                using (SqlCommand command = new SqlCommand(queryCaserne, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBoxCaserne.Items.Add(reader["CaserneName"].ToString());
                    }
                }

                // Chargement des données pour listBoxEnginUtilises
                LoadListBoxData(connection, listBoxEnginUtilises, "WITH EnginCount AS (SELECT codeTypeEngin, COUNT(*) AS nb FROM Engin WHERE idCaserne = 1 GROUP BY codeTypeEngin), MaxCount AS (SELECT MAX(nb) AS max_nb FROM EnginCount)SELECT codeTypeEngin, nb FROM EnginCount WHERE nb = (SELECT max_nb FROM MaxCount)");

                // Chargement des données pour listBoxHeuresUtilisation
                LoadListBoxData(connection, listBoxHeuresUtilisation, "SELECT e.codeTypeEngin,e.numero,ROUND(SUM((JULIANDAY(m.dateHeureRetour) - JULIANDAY(m.dateHeureDepart)) * 24), 1) AS heures_utilisation FROM Engin e JOIN PartirAvec pa ON e.idCaserne = pa.idCaserne AND e.codeTypeEngin = pa.codeTypeEngin AND e.numero = pa.numeroEngin JOIN Mission m ON m.id = pa.idMission WHERE e.idCaserne = 1 AND m.dateHeureDepart IS NOT NULL AND m.dateHeureRetour IS NOT NULL GROUP BY e.codeTypeEngin, e.numeroORDER BY heures_utilisation DESC;");

                // Chargement des données pour listBoxSinistres
                LoadListBoxData(connection, listBoxSinistres, "SELECT ns.libelle AS type_sinistre, COUNT(*) AS nb_interventions FROM Mission m JOIN NatureSinistre ns ON ns.id = m.idNatureSinistre GROUP BY m.idNatureSinistre ORDER BY nb_interventions DESC;");

                // Chargement des données pour listBoxHabilitations
                LoadListBoxData(connection, listBoxHabilitations, "SELECT h.libelle,COUNT(*) AS nb_solicitations FROM Mobiliser mo JOIN Habilitation h ON mo.idHabilitation = h.id GROUP BY mo.idHabilitation ORDER BY nb_solicitations DESC;");

                // Chargement des données pour listBoxPompiersParHabilitation
                LoadListBoxData(connection, listBoxPompiersParHabilitation, "SELECT h.libelle AS habilitation,p.matricule,p.nom,p.prenom FROM Habilitation h LEFT JOIN Passer pa ON h.id = pa.idHabilitation LEFT JOIN Pompier p ON pa.matriculePompier = p.matricule ORDER BY h.libelle, p.nom;");
            }
        }

        private void LoadListBoxData(SqlConnection connection, ListBox listBox, string query)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    listBox.Items.Add(reader[0].ToString());
                }
            }
        }
    }
}