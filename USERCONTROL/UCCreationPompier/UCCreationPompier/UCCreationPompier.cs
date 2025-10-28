using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCCreationPompier
{
    public partial class UCCreationPompier: UserControl
    {
        private SQLiteConnection _connexion;
        public UCCreationPompier()
        {
            InitializeComponent();
        }
        public void InitialiserConnexion(SQLiteConnection connexion)
        {
            _connexion = connexion;

            if (_connexion == null || _connexion.State != ConnectionState.Open)
            {
                MessageBox.Show("Connexion invalide ou fermée.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RemplirComboCaserneCrea();

            if (cboCaserneRattachementCrea.Items.Count > 0)
            {
                cboCaserneRattachementCrea.SelectedIndex = 0;
            }
            MettreAJourMatriculeSelonCaserne();

        }
        public void RemplirComboCaserneCrea()
        {
            cboCaserneRattachementCrea.Items.Clear();
            using (var cmd = new SQLiteCommand("SELECT nom FROM Caserne ORDER BY nom", _connexion))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cboCaserneRattachementCrea.Items.Add(reader["nom"].ToString());
                    }
                }
            }
        }

        public void cboCaserneRattachementCrea_SelectedIndexChanged(object sender, EventArgs e)
        {
            MettreAJourMatriculeSelonCaserne();
        }

        private void btnAnnulerCrea_Click(object sender, EventArgs e)
        {
            // Tout vider
            ViderChamps();

            // Masquer l'UserControl
            this.Visible = false;
        }

        public void btnValiderCreation_Click(object sender, EventArgs e)
        {
            if (_connexion == null || _connexion.State != ConnectionState.Open)
            {
                MessageBox.Show("Connexion à la base de données non établie.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Récupération des données
            int matricule;
            if (!int.TryParse(lblMatriculeDataCrea.Text, out matricule))
            {
                MessageBox.Show("Matricule invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nom = txtNomCrea.Text.Trim();
            string prenom = txtPrenomCrea.Text.Trim();
            string sexe = rdbMascCrea.Checked ? "m" : (rdbFemCrea.Checked ? "f" : null);
            string type = rdbProCrea.Checked ? "p" : (rdbVolCrea.Checked ? "v" : null);
            string portable = txtTelCrea.Text.Trim();
            string bip = txtBipCrea.Text.Trim();
            DateTime dateNaissance = dtpDateNaissanceCrea.Value;
            DateTime dateEmbauche = DateTime.Today;
            string caserneNom = cboCaserneRattachementCrea.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || sexe == null || type == null || string.IsNullOrEmpty(caserneNom))
            {
                MessageBox.Show("Tous les champs obligatoires doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var transaction = _connexion.BeginTransaction())
                {
                    // 1. Insérer dans la table Pompier
                    string insertPompier = @"INSERT INTO Pompier 
                (matricule, nom, prenom, sexe, dateNaissance, type, portable, bip, enMission, enConge, codeGrade, dateEmbauche) 
                VALUES (@matricule, @nom, @prenom, @sexe, @dateNaissance, @type, @portable, @bip, 0, 0, @codeGrade, @dateEmbauche)";

                    using (var cmd = new SQLiteCommand(insertPompier, _connexion, transaction))
                    {
                        cmd.Parameters.AddWithValue("@matricule", matricule);
                        cmd.Parameters.AddWithValue("@nom", nom);
                        cmd.Parameters.AddWithValue("@prenom", prenom);
                        cmd.Parameters.AddWithValue("@sexe", sexe);
                        cmd.Parameters.AddWithValue("@dateNaissance", dateNaissance.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@type", type);
                        cmd.Parameters.AddWithValue("@portable", string.IsNullOrEmpty(portable) ? DBNull.Value : (object)portable);
                        if (int.TryParse(bip, out int bipInt))
                            cmd.Parameters.AddWithValue("@bip", bipInt);
                        else
                            cmd.Parameters.AddWithValue("@bip", DBNull.Value);
                        cmd.Parameters.AddWithValue("@codeGrade", "SAP");
                        cmd.Parameters.AddWithValue("@dateEmbauche", dateEmbauche.ToString("yyyy-MM-dd"));
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Récupérer idCaserne
                    int idCaserne = -1;
                    using (var cmd = new SQLiteCommand("SELECT id FROM Caserne WHERE nom = @nom", _connexion, transaction))
                    {
                        cmd.Parameters.AddWithValue("@nom", caserneNom);
                        object result = cmd.ExecuteScalar();
                        if (result == null)
                        {
                            throw new Exception("Caserne non trouvée.");
                        }
                        idCaserne = Convert.ToInt32(result);
                    }

                    // 3. Insérer dans la table Affectation
                    string insertAffectation = @"INSERT INTO Affectation (matriculePompier, dateA, idCaserne) 
                                         VALUES (@matricule, @dateA, @idCaserne)";
                    using (var cmd = new SQLiteCommand(insertAffectation, _connexion, transaction))
                    {
                        cmd.Parameters.AddWithValue("@matricule", matricule);
                        cmd.Parameters.AddWithValue("@dateA", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@idCaserne", idCaserne);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Pompier créé avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Visible = false;
                    ViderChamps();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la création du pompier : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ViderChamps()
        {
            txtNomCrea.Clear();
            txtPrenomCrea.Clear();
            txtTelCrea.Clear();
            txtBipCrea.Clear();
            rdbMascCrea.Checked = false;
            rdbFemCrea.Checked = false;
            rdbProCrea.Checked = false;
            rdbVolCrea.Checked = false;
            dtpDateNaissanceCrea.Value = DateTime.Today;
        }
        public void MettreAJourMatriculeSelonCaserne()
        {
            if (_connexion == null || _connexion.State != ConnectionState.Open)
                return;

            string caserneSelectionnee = cboCaserneRattachementCrea.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(caserneSelectionnee))
                return;

            try
            {
                // 1. Récupérer l'id de la caserne
                int idCaserne = -1;
                using (var cmdId = new SQLiteCommand("SELECT id FROM Caserne WHERE nom = @nom", _connexion))
                {
                    cmdId.Parameters.AddWithValue("@nom", caserneSelectionnee);
                    object resultId = cmdId.ExecuteScalar();

                    if (resultId == null || resultId == DBNull.Value)
                        return;

                    idCaserne = Convert.ToInt32(resultId);
                }

                // 2. Récupérer le MAX(matricule)
                string query = @"
            SELECT MAX(p.matricule) 
            FROM Pompier p
            INNER JOIN Affectation a ON p.matricule = a.matriculePompier
            WHERE a.idCaserne = @idCaserne";

                using (var cmd = new SQLiteCommand(query, _connexion))
                {
                    cmd.Parameters.AddWithValue("@idCaserne", idCaserne);
                    object result = cmd.ExecuteScalar();

                    int nouveauMatricule = 1;
                    if (result != DBNull.Value && result != null)
                        nouveauMatricule = Convert.ToInt32(result) + 1;

                    lblMatriculeDataCrea.Text = nouveauMatricule.ToString();
                    txtBipCrea.Text = nouveauMatricule.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la génération du matricule : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
