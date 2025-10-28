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
using Pinpon;
using System.Text.RegularExpressions;
using UCMission;
using System.Data.OleDb;

namespace UCtableauDeBord
{
    public partial class UCtableauDeBord: UserControl
    {
        public UCtableauDeBord()
        {
            InitializeComponent();
        }

        SQLiteConnection connec;
        DataSet ds;

        //Les images
        Dictionary<string, string> Images = new Dictionary<string, string>
        {
            {"terminee", @"..\..\Images\MissionPompier.jpg"},
            {"enCours", @"..\..\Images\ImageImportant.gif"}
        };

        public void setDataConnec(SQLiteConnection connexion, DataSet data)
        {
            connec = connexion;
            ds = data;
        }

        public void initialiserUC()
        {
            pnlGris.Controls.Clear();
            creerMission(false);
        }

        private void GestionMission(object sender, EventArgs e)
        {
            //Récupérer le bouton
            Button btnInf = (Button)sender;
            UCMission.UCMission infMission = (UCMission.UCMission) btnInf.Parent.Parent;
            //btnInf représente le bouton, btnInf.Parent représente sont parent qui est le panel jaune, .Parent.Parent représente le parent du panel jaune qui est le UC
            
            //Récupérer l'id
            string id = infMission.idMission;
            DataRow[] mission = ds.Tables["Mission"].Select("id = " + id);
            if (Convert.ToInt32(mission[0]["terminee"]) == 0)
            {
                mission[0]["terminee"] = 1;
                mission[0]["dateHeureRetour"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

                // répercuter dans la base de données
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Mission", connec);
                // Pour les commandes UPDATE/DELETE/...
                SQLiteCommandBuilder builder = new SQLiteCommandBuilder(da);
                da.Update(ds, "Mission");
                MessageBox.Show("Mission clôturé avec succès!");

                // mettre enMission des pompiers + engins à 0
                DataRow[] partirAvec = ds.Tables["PartirAvec"].Select("idMission = " + id);
                foreach (DataRow enginMobiliser in partirAvec)
                {
                    string codeTypeEngin = enginMobiliser["codeTypeEngin"].ToString();
                    int numeroEngin = Convert.ToInt32(enginMobiliser["numeroEngin"]);
                    int idCaserne = Convert.ToInt32(enginMobiliser["idCaserne"]);
                    DataRow[] engin = ds.Tables["Engin"].Select($"idCaserne = {idCaserne} AND codeTypeEngin = '{codeTypeEngin}' AND numero = {numeroEngin}");
                    engin[0]["enMission"] = 0;
                }
                // répercuter dans la base de données
                da = new SQLiteDataAdapter("SELECT * FROM Engin", connec);
                // Pour les commandes UPDATE/DELETE/...
                builder = new SQLiteCommandBuilder(da);
                da.Update(ds, "Engin");

                DataRow[] mobiliser = ds.Tables["Mobiliser"].Select("idMission = " + id);
                foreach (DataRow pompierMobiliser in mobiliser)
                {
                    int matricule = Convert.ToInt32(pompierMobiliser["matriculePompier"]);
                    DataRow[] pompier = ds.Tables["Pompier"].Select("matricule = " + matricule);
                    pompier[0]["enMission"] = 0;
                }
                // répercuter dans la base de données
                da = new SQLiteDataAdapter("SELECT * FROM Pompier", connec);
                // Pour les commandes UPDATE/DELETE/...
                builder = new SQLiteCommandBuilder(da);
                da.Update(ds, "Pompier");

                pnlGris.Controls.Clear();
                creerMission(false);
            }
            else
            {
                MessageBox.Show("la mission est déjà terminée");
            }
        }

        /*private void UCtableauDeBord_Load(object sender, EventArgs e)
        {

        }*/

        private void creerMission(bool enCours)
        {
            int bordGauche = 20;
            int bordHaut = 20;

            int nbMissions = ds.Tables["Mission"].Rows.Count;

            //Création des missions du tableau de bord
            for (int i = 0; i < nbMissions; i++)
            {
                string idMission = ds.Tables["Mission"].Rows[i]["id"].ToString();
                // Récupérer seulement les missions pas terminées
                DataRow[] mission = ds.Tables["Mission"].Select("id = " + idMission + " AND terminee = 0");
                string imageMission = Images["enCours"];

                // Récupérer toutes les missions (terminée ou pas)
                if (!enCours)
                {
                    if (!(mission.Length > 0))
                    {
                        mission = ds.Tables["Mission"].Select("id = " + idMission);
                        imageMission = Images["terminee"];
                    }
                }

                // affichage + Création du UCMission
                if (mission.Length > 0)
                {
                    int idCaserne = Convert.ToInt32(mission[0]["idCaserne"]);
                    DataRow[] caserne = ds.Tables["Caserne"].Select("id = " + idCaserne);

                    int idNatureSinistre = Convert.ToInt32(mission[0]["idNatureSinistre"]);
                    DataRow[] natureSinistre = ds.Tables["NatureSinistre"].Select("id = " + idNatureSinistre);

                    UCMission.UCMission MissionInfos = new UCMission.UCMission(
                        mission[0]["id"].ToString(),
                        mission[0]["dateHeureDepart"].ToString(),
                        mission[0]["motifAppel"].ToString(),
                        mission[0]["ville"].ToString(),
                        natureSinistre[0]["libelle"].ToString(),
                        caserne[0]["nom"].ToString(), 
                        imageMission
                    );

                    MissionInfos.infosM = GestionMission;
                    MissionInfos.Left = bordGauche;
                    MissionInfos.Top = bordHaut;
                    pnlGris.Controls.Add(MissionInfos);

                    bordHaut += MissionInfos.Height + 30;
                }
            }
        }

        private void chkEnCours_CheckedChanged(object sender, EventArgs e)
        {
            pnlGris.Controls.Clear();
            if (chkEnCours.Checked)
            {
                creerMission(true);
            }
            else
            {
                creerMission(false);
            }
        }
    }
}
