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

namespace UCCreationMission
{
    public partial class UCCreationMission: UserControl
    {
        SQLiteConnection connec;
        DataSet ds;

        public UCCreationMission()
        {
            InitializeComponent();
        }

        public void setDataConnec(SQLiteConnection connexion, DataSet data)
        {
            connec = connexion;
            ds = data;
        }

        public void initialiserUC()
        {
            //MessageBox.Show(connec.State.ToString());
            cboNatureSinistre.Items.Add("--Sélectionner un sinistre--");
            cboCaserne.Items.Add("--Sélectionner une caserne--");
            cboCaserne.SelectedIndex = 0;
            cboNatureSinistre.SelectedIndex = 0;

            // Remplissage des comboBox + des labels
            try
            {
                // Remplissage de la comboBox de la nature du sinistre
                string requete = @"SELECT libelle FROM NatureSinistre";

                SQLiteCommand cd = new SQLiteCommand(requete, connec);
                SQLiteDataReader dr = cd.ExecuteReader();

                while (dr.Read())
                {
                    cboNatureSinistre.Items.Add(dr.GetString(0));
                }

                // Remplissage de la comboBox des casernes
                requete = @"SELECT nom FROM Caserne";
                SQLiteCommand cd2 = new SQLiteCommand(requete, connec);
                SQLiteDataReader dr2 = cd2.ExecuteReader();

                while (dr2.Read())
                {
                    cboCaserne.Items.Add(dr2.GetString(0));
                }

                // numéro de la mission
                object numMission = ds.Tables["Mission"].Compute("MAX(id)", "");
                idMission = Convert.ToInt32(numMission);
                idMission++;
                lblId.Text = "Mission n°" + idMission.ToString();

                // date du jour
                lblDate.Text = "Déclenchée le: " + dateHeureDepart;
            }
            catch (SQLiteException erreur)
            {
                MessageBox.Show("Erreur dans la requête SQL !");
            }
        }

        // infos pour créer la mission
        int idMission;
        string dateHeureDepart = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        string dateHeureRetour = null;
        string motifAppel = null;
        string adresse = null;
        string CP = null;
        string ville = null;
        int terminee = 0;
        string compteRendu = null;
        int idNatureSinistre;
        int idCaserne;

        int nbEngin;
        int nbPompier;
        
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtCP.Clear();
            txtRue.Clear();
            txtMotif.Clear();
            txtVille.Clear();
            cboCaserne.SelectedIndex = 0;
            cboNatureSinistre.SelectedIndex = 0;
            pnlMobilisation.Visible = false;
        }

        private void btnConstituerEquipe_Click(object sender, EventArgs e)
        {
            if ((cboCaserne.SelectedIndex == 0) || (cboNatureSinistre.SelectedIndex == 0))
            {
                MessageBox.Show("Veuillez insérer la caserne et le sinistre");
            }
            else
            {
                pnlMobilisation.Visible = true;

                // Prendre le nombre d'engins nécessaires à la mission
                /*string requeteNbEngin = @"SELECT nombre FROM Necessiter
                                            WHERE idNatureSinistre = (SELECT id FROM NatureSinistre
							                                            WHERE libelle = ""Secours d'urgence aux personnes"")";*/

                string filtre = cboNatureSinistre.Text;
                filtre = filtre.Replace("'", "''");
                DataRow[] nature = ds.Tables["NatureSinistre"].Select(@"libelle = '" + filtre + "'");

                int idNature = Convert.ToInt32(nature[0]["id"]);
                DataRow[] necessites = ds.Tables["Necessiter"].Select($"idNatureSinistre = {idNature}");
                nbEngin = Convert.ToInt32(necessites[0]["nombre"]);

                idNatureSinistre = idNature;
                // Prendre les engins nécessaires à la mission
                /*string requeteEngin = @"SELECT codeTypeEngin,numero FROM Engin
                                        WHERE enMission = 0
                                        AND enPanne = 0
                                        AND idCaserne = (SELECT id FROM Caserne
				                                         WHERE nom = 'Caserne Pot-au-feu')
                                        AND codeTypeEngin = (SELECT codeTypeEngin FROM Necessiter
					                                         WHERE idNatureSinistre = (SELECT id FROM NatureSinistre
											                                           WHERE libelle = ""Secours d'urgence aux personnes""))";*/

                filtre = cboCaserne.Text;
                DataRow[] caserne = ds.Tables["Caserne"].Select("nom = '" + filtre + "'");

                int idCas = Convert.ToInt32(caserne[0]["id"]);
                string codeTypeEngin = necessites[0]["codeTypeEngin"].ToString();

                filtre = $"enMission = 0 AND enPanne = 0 AND idCaserne = {idCas} AND codeTypeEngin = '{codeTypeEngin}'";
                DataRow[] engins = ds.Tables["Engin"].Select(filtre);

                idCaserne = idCas;
                // Si il n'y a pas tous les engins dispo dans la caserne
                if (engins.Length < nbEngin)
                {
                    MessageBox.Show("Engins non disponibles, affectation à une autre caserne.");
                    filtre = $"enMission = 0 AND enPanne = 0 AND codeTypeEngin = '{codeTypeEngin}'";
                    engins = ds.Tables["Engin"].Select(filtre);
                }

                // Affichage
                DataTable enginsAffichage = ds.Tables["Engin"].Clone();
                for (int i = 0; i < nbEngin; i++)
                {
                    if (engins[i] != null)
                        enginsAffichage.ImportRow(engins[i]);
                }
                dgvEngins.DataSource = enginsAffichage;

                // Récupérer le nombre de pompier à mobiliser
                /*string requeteNbPompier = @"SELECT equipage FROM TypeEngin
                                            WHERE code = 'VSAV'";*/
                filtre = engins[0]["codeTypeEngin"].ToString();
                DataRow[] types = ds.Tables["TypeEngin"].Select("code = '" + filtre + "'");
                nbPompier = Convert.ToInt32(types[0]["equipage"]);

                // Récupérer les pompiers à mobiliser
                /*string requetePompier = @"SELECT matricule,nom,prenom FROM Pompier
                                            WHERE enMission = 0
                                            AND enConge = 0
                                            AND matricule IN (SELECT matriculePompier FROM Passer
					                                            WHERE idHabilitation = (SELECT idHabilitation FROM Embarquer
											                                            WHERE codeTypeEngin = 'VSAV'))";*/
                DataRow[] habilitations = ds.Tables["Embarquer"].Select("codeTypeEngin = '" + filtre + "'");
                List<int> idsHab = habilitations.Select(h => Convert.ToInt32(h["idHabilitation"])).ToList();
                List<DataRow> pompiersEligibles = new List<DataRow>();

                foreach (int idHab in idsHab)
                {
                    DataRow[] passers = ds.Tables["Passer"].Select($"idHabilitation = {idHab}");

                    foreach (DataRow passer in passers)
                    {
                        int mat = Convert.ToInt32(passer["matriculePompier"]);
                        DataRow[] pompier = ds.Tables["Pompier"].Select($"matricule = {mat} AND enMission = 0 AND enConge = 0");

                        if (pompier.Length > 0)
                            pompiersEligibles.Add(pompier[0]);
                    }
                }

                // Affichage
                DataTable pompiersAffichage = ds.Tables["Pompier"].Clone();
                for (int i=0; i<nbPompier; i++)
                {
                    if (pompiersEligibles[i] != null)
                        pompiersAffichage.ImportRow(pompiersEligibles[i]);                  
                }
                dgvPompiers.DataSource = pompiersAffichage;
            }
        }

        private void btnCreationM_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(txtCP.Text)) || (string.IsNullOrWhiteSpace(txtMotif.Text)) || (string.IsNullOrWhiteSpace(txtRue.Text)) || (string.IsNullOrWhiteSpace(txtVille.Text)))
            {
                MessageBox.Show("Veuillez insérer les informations de la mission!");
            }
            else if ((dgvEngins.DataSource == null) || (dgvPompiers.DataSource == null))
            {
                MessageBox.Show("Mission annulée! Engins ou pompiers nécessaires manquants.");
            }
            else
            {
                // Création de la mission
                motifAppel = txtMotif.Text.ToString();
                adresse = txtRue.Text.ToString();
                CP = txtCP.Text.ToString();
                ville = txtVille.Text.ToString();
                
                DataRow ligne;
                ligne = ds.Tables["Mission"].NewRow();
                ligne[0] = idMission;
                ligne[1] = dateHeureDepart;
                ligne[2] = dateHeureRetour;
                ligne[3] = motifAppel;
                ligne[4] = adresse;
                ligne[5] = CP;
                ligne[6] = ville;
                ligne[7] = terminee;
                ligne[8] = compteRendu;
                ligne[9] = idNatureSinistre;
                ligne[10] = idCaserne;
                ds.Tables["Mission"].Rows.Add(ligne);

                // mettre les engins et les pomiers en missions
                string type;
                string filtre;
                int num;
                for (int i = 0; i < nbEngin; i++)
                {
                    if (dgvEngins.Rows[i] != null)
                    {
                        type = dgvEngins.Rows[i].Cells["codeTypeEngin"].Value.ToString();
                        num = Convert.ToInt32(dgvEngins.Rows[i].Cells["numero"].Value);
                        filtre = $"idCaserne = {idCaserne} AND codeTypeEngin = '{type}' AND numero = {num}";
                        DataRow[] engin = ds.Tables["Engin"].Select(filtre);
                        engin[0]["enMission"] = 1;

                        // Remplir la table PartirAvec
                        DataRow lignePartirAvec;
                        lignePartirAvec = ds.Tables["PartirAvec"].NewRow();
                        lignePartirAvec[0] = idCaserne;
                        lignePartirAvec[1] = type;
                        lignePartirAvec[2] = num;
                        lignePartirAvec[3] = idMission;
                        ds.Tables["PartirAvec"].Rows.Add(lignePartirAvec);
                    }
                }

                int matricule;
                for (int i = 0; i < nbPompier; i++)
                {
                    if (dgvPompiers.Rows[i] != null)
                    {
                        matricule = Convert.ToInt32(dgvPompiers.Rows[i].Cells["matricule"].Value);
                        filtre = $"matricule = {matricule}";
                        DataRow[] pompier = ds.Tables["Pompier"].Select(filtre);
                        pompier[0]["enMission"] = 1;

                        // Remplir la table Mobiliser
                        DataRow[] habilitation = ds.Tables["Passer"].Select("matriculePompier = " + matricule);

                        DataRow ligneMobiliser;
                        ligneMobiliser = ds.Tables["Mobiliser"].NewRow();
                        ligneMobiliser[0] = matricule;
                        ligneMobiliser[1] = idMission;
                        ligneMobiliser[2] = Convert.ToInt32(habilitation[0]["idHabilitation"]);
                        ds.Tables["Mobiliser"].Rows.Add(ligneMobiliser);
                    }
                }

                // Mise à jour de l'id + de la date
                idMission++;
                lblId.Text = "Mission n°" + idMission.ToString();
                dateHeureDepart = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                lblDate.Text = "Déclenchée le: " + dateHeureDepart.ToString();
                btnAnnuler_Click(sender, e);
                MessageBox.Show("Mission créé avec succès!");
            }
        }      
    }
}
