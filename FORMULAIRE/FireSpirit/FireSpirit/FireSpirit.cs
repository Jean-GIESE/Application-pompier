using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NavigationEngins;
using Pinpon;

namespace FireSpirit
{
    public partial class frmFireSpirit : Form
    {
        private SQLiteConnection connec;
        private DataSet ds;
        public frmFireSpirit()
        {
            InitializeComponent();

        }
        private void frmFireSpirit_Load(object sender, EventArgs e)
        {
            connec = Connexion.Connec;
            ds = MesDatas.DsGlobal;
            chargementDS();

            if (!UCTableauDeBord.Visible)
            {
                ToutFermer();
                UCTableauDeBord.Visible = true;
                UCTableauDeBord.setDataConnec(connec, ds);
                UCTableauDeBord.initialiserUC();
            }
        }
        private void chargementDS()
        {
            try
            {
                DataTable schemaTable = connec.GetSchema("Tables");
                string req;
                for (int i = 0; i < schemaTable.Rows.Count; i++)
                {
                    string nomTable = schemaTable.Rows[i][2].ToString();
                    req = "select * from " + nomTable;
                    SQLiteCommand cd = new SQLiteCommand(req, connec);
                    SQLiteDataAdapter da = new SQLiteDataAdapter();
                    da = new SQLiteDataAdapter(cd);
                    da.Fill(ds, nomTable);
                }
            }
            catch { }

            if (ds.Tables.Contains("Caserne") && ds.Tables.Contains("Engin") && ds.Tables.Contains("Mission"))
            {
                if (!ds.Relations.Contains("Caserne_Engins"))
                {
                    ds.Relations.Add("Caserne_Engins",
                        ds.Tables["Caserne"].Columns["id"],
                        ds.Tables["Engin"].Columns["idCaserne"]);
                }

                // Ajout des contraintes
                DataColumn MissionPK = ds.Tables["Mission"].Columns["id"];
                ds.Tables["Mission"].PrimaryKey = new DataColumn[] { MissionPK };
                //MessageBox.Show("Clé primaire définie");

                if (!ds.Relations.Contains("MissionFKCaserne"))
                {
                    ForeignKeyConstraint contrainte = new ForeignKeyConstraint("MissionFKCaserne", ds.Tables["Caserne"].Columns["id"], ds.Tables["Mission"].Columns["idCaserne"]);
                    ds.Tables["Mission"].Constraints.Add(contrainte);
                    //MessageBox.Show("1ère clé étrangère définie");
                }

                if (!ds.Relations.Contains("MissionFKNature"))
                {
                    ForeignKeyConstraint contrainte2 = new ForeignKeyConstraint("MissionFKNature", ds.Tables["NatureSinistre"].Columns["id"], ds.Tables["Mission"].Columns["idNatureSinistre"]);
                    ds.Tables["Mission"].Constraints.Add(contrainte2);
                    //MessageBox.Show("2ème clé étrangère définie");
                }
            }
            else
            {
                MessageBox.Show("Les tables 'Caserne' ou 'Engin' sont introuvables dans le DataSet.");
            }

        }

        private void ToutFermer()
        {
            UCNavigationEngins.Visible = false;
            UCGestionPompier.Visible = false;
            UCCreationMission.Visible = false;
            UCTableauDeBord.Visible = false;
            //les autres
            System.Windows.Forms.Application.DoEvents();
            System.Threading.Thread.Sleep(1000);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Connexion.FermerConnexion();
            this.Close();
        }

        private void UCBtnNavEngin_Click(object sender, EventArgs e)
        {
            if (!UCNavigationEngins.Visible)
            {
                ToutFermer();
                UCNavigationEngins.Visible = true;
                UCNavigationEngins.SetData(ds);
            }
        }

        private void UCBtnNavPompier_Click(object sender, EventArgs e)
        {
            if (!UCGestionPompier.Visible)
            {
                ToutFermer();
                UCGestionPompier.Visible = true;
                UCGestionPompier.InitialiserConnexion(connec);
            }
        }

        private void UCBtnNavMission_Click(object sender, EventArgs e)
        {
            if (!UCCreationMission.Visible)
            {
                ToutFermer();
                UCCreationMission.Visible = true;
                UCCreationMission.setDataConnec(connec, ds);
                UCCreationMission.initialiserUC();
            }
        }

        private void UCBtnNavTableau_Click(object sender, EventArgs e)
        {
            if (!UCTableauDeBord.Visible)
            {
                ToutFermer();
                UCTableauDeBord.Visible = true;
                UCTableauDeBord.setDataConnec(connec, ds);
                UCTableauDeBord.initialiserUC();
            }
        }
    }
}
