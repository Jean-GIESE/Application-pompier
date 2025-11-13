using System.Windows.Forms;

namespace SAE24_Théo_LUTHIN_TP4
{
    partial class StatisticsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxCaserne;
        private ListBox listBoxEnginUtilises;
        private ListBox listBoxHeuresUtilisation;
        private ListBox listBoxSinistres;
        private ListBox listBoxHabilitations;
        private ListBox listBoxPompiersParHabilitation;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.comboBoxCaserne = new ComboBox();
            this.listBoxEnginUtilises = new ListBox();
            this.listBoxHeuresUtilisation = new ListBox();
            this.listBoxSinistres = new ListBox();
            this.listBoxHabilitations = new ListBox();
            this.listBoxPompiersParHabilitation = new ListBox();
            this.label3 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();

            this.SuspendLayout();

            // Configuration des labels
            this.label1.Text = "Sélection de la caserne";
            this.label1.Location = new System.Drawing.Point(20, 20);

            this.label2.Text = "Engins utilisés";
            this.label2.Location = new System.Drawing.Point(20, 60);

            this.label3.Text = "Heures d'utilisation";
            this.label3.Location = new System.Drawing.Point(20, 100);

            this.label4.Text = "Interventions par sinistre";
            this.label4.Location = new System.Drawing.Point(20, 140);

            this.label5.Text = "Habilitations";
            this.label5.Location = new System.Drawing.Point(20, 180);

            this.label6.Text = "Pompiers par habilitation";
            this.label6.Location = new System.Drawing.Point(20, 220);

            this.label7.Text = "Statistiques";
            this.label7.Font = new System.Drawing.Font("Arial", 14, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(150, 10);

            // Configuration des contrôles
            this.comboBoxCaserne.Location = new System.Drawing.Point(180, 20);
            this.comboBoxCaserne.Size = new System.Drawing.Size(200, 21);

            this.listBoxEnginUtilises.Location = new System.Drawing.Point(180, 60);
            this.listBoxEnginUtilises.Size = new System.Drawing.Size(200, 60);

            this.listBoxHeuresUtilisation.Location = new System.Drawing.Point(180, 100);
            this.listBoxHeuresUtilisation.Size = new System.Drawing.Size(200, 60);

            this.listBoxSinistres.Location = new System.Drawing.Point(180, 140);
            this.listBoxSinistres.Size = new System.Drawing.Size(200, 60);

            this.listBoxHabilitations.Location = new System.Drawing.Point(180, 180);
            this.listBoxHabilitations.Size = new System.Drawing.Size(200, 60);

            this.listBoxPompiersParHabilitation.Location = new System.Drawing.Point(180, 220);
            this.listBoxPompiersParHabilitation.Size = new System.Drawing.Size(200, 60);

            // Ajout des contrôles à la fenêtre
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCaserne);
            this.Controls.Add(this.listBoxEnginUtilises);
            this.Controls.Add(this.listBoxHeuresUtilisation);
            this.Controls.Add(this.listBoxSinistres);
            this.Controls.Add(this.listBoxHabilitations);
            this.Controls.Add(this.listBoxPompiersParHabilitation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);

            this.ClientSize = new System.Drawing.Size(420, 300);
            this.Name = "StatisticsForm";
            this.Text = "Statistiques des Pompiers";
            this.ResumeLayout(false);
        }
    }
}
