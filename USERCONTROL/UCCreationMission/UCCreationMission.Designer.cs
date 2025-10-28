namespace UCCreationMission
{
    partial class UCCreationMission
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblId = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.grpInfosUsagers = new System.Windows.Forms.GroupBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lblAdrSinistre = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblMotif = new System.Windows.Forms.Label();
            this.pnlInfosUsagers = new System.Windows.Forms.Panel();
            this.pnlDecisionReg = new System.Windows.Forms.Panel();
            this.grpDecisionReg = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConstituerEquipe = new System.Windows.Forms.Button();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.cboNatureSinistre = new System.Windows.Forms.ComboBox();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblNatureSinistre = new System.Windows.Forms.Label();
            this.pnlMobilisation = new System.Windows.Forms.Panel();
            this.grpMobilisation = new System.Windows.Forms.GroupBox();
            this.btnCreationM = new System.Windows.Forms.Button();
            this.dgvPompiers = new System.Windows.Forms.DataGridView();
            this.dgvEngins = new System.Windows.Forms.DataGridView();
            this.lblPompiersMobilises = new System.Windows.Forms.Label();
            this.lblEnginMobilises = new System.Windows.Forms.Label();
            this.grpInfosUsagers.SuspendLayout();
            this.pnlInfosUsagers.SuspendLayout();
            this.pnlDecisionReg.SuspendLayout();
            this.grpDecisionReg.SuspendLayout();
            this.pnlMobilisation.SuspendLayout();
            this.grpMobilisation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompiers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngins)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(83, 25);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(111, 29);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Mission n° ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(772, 25);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(147, 29);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Déclenchée le: ";
            // 
            // grpInfosUsagers
            // 
            this.grpInfosUsagers.BackColor = System.Drawing.Color.MidnightBlue;
            this.grpInfosUsagers.Controls.Add(this.txtVille);
            this.grpInfosUsagers.Controls.Add(this.txtRue);
            this.grpInfosUsagers.Controls.Add(this.txtCP);
            this.grpInfosUsagers.Controls.Add(this.txtMotif);
            this.grpInfosUsagers.Controls.Add(this.lblAdrSinistre);
            this.grpInfosUsagers.Controls.Add(this.lblVille);
            this.grpInfosUsagers.Controls.Add(this.lblCP);
            this.grpInfosUsagers.Controls.Add(this.lblRue);
            this.grpInfosUsagers.Controls.Add(this.lblMotif);
            this.grpInfosUsagers.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpInfosUsagers.ForeColor = System.Drawing.Color.Yellow;
            this.grpInfosUsagers.Location = new System.Drawing.Point(11, 14);
            this.grpInfosUsagers.Margin = new System.Windows.Forms.Padding(2);
            this.grpInfosUsagers.Name = "grpInfosUsagers";
            this.grpInfosUsagers.Padding = new System.Windows.Forms.Padding(2);
            this.grpInfosUsagers.Size = new System.Drawing.Size(1409, 258);
            this.grpInfosUsagers.TabIndex = 2;
            this.grpInfosUsagers.TabStop = false;
            this.grpInfosUsagers.Text = "Informations usagers";
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(940, 193);
            this.txtVille.Margin = new System.Windows.Forms.Padding(2);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(442, 35);
            this.txtVille.TabIndex = 3;
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(940, 87);
            this.txtRue.Margin = new System.Windows.Forms.Padding(2);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(442, 35);
            this.txtRue.TabIndex = 7;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(940, 140);
            this.txtCP.Margin = new System.Windows.Forms.Padding(2);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(182, 35);
            this.txtCP.TabIndex = 6;
            // 
            // txtMotif
            // 
            this.txtMotif.Location = new System.Drawing.Point(123, 57);
            this.txtMotif.Margin = new System.Windows.Forms.Padding(2);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(605, 185);
            this.txtMotif.TabIndex = 5;
            // 
            // lblAdrSinistre
            // 
            this.lblAdrSinistre.AutoSize = true;
            this.lblAdrSinistre.Location = new System.Drawing.Point(1028, 33);
            this.lblAdrSinistre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdrSinistre.Name = "lblAdrSinistre";
            this.lblAdrSinistre.Size = new System.Drawing.Size(151, 29);
            this.lblAdrSinistre.TabIndex = 4;
            this.lblAdrSinistre.Text = "adresse sinistre";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(749, 200);
            this.lblVille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(49, 29);
            this.lblVille.TabIndex = 3;
            this.lblVille.Text = "Ville";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(749, 143);
            this.lblCP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(113, 29);
            this.lblCP.TabIndex = 2;
            this.lblCP.Text = "code postal";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Location = new System.Drawing.Point(749, 90);
            this.lblRue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(42, 29);
            this.lblRue.TabIndex = 1;
            this.lblRue.Text = "rue";
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(29, 61);
            this.lblMotif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(56, 29);
            this.lblMotif.TabIndex = 0;
            this.lblMotif.Text = "Motif";
            // 
            // pnlInfosUsagers
            // 
            this.pnlInfosUsagers.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlInfosUsagers.Controls.Add(this.grpInfosUsagers);
            this.pnlInfosUsagers.Location = new System.Drawing.Point(23, 83);
            this.pnlInfosUsagers.Margin = new System.Windows.Forms.Padding(2);
            this.pnlInfosUsagers.Name = "pnlInfosUsagers";
            this.pnlInfosUsagers.Size = new System.Drawing.Size(1445, 285);
            this.pnlInfosUsagers.TabIndex = 3;
            // 
            // pnlDecisionReg
            // 
            this.pnlDecisionReg.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlDecisionReg.Controls.Add(this.grpDecisionReg);
            this.pnlDecisionReg.Location = new System.Drawing.Point(23, 390);
            this.pnlDecisionReg.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDecisionReg.Name = "pnlDecisionReg";
            this.pnlDecisionReg.Size = new System.Drawing.Size(1445, 208);
            this.pnlDecisionReg.TabIndex = 4;
            // 
            // grpDecisionReg
            // 
            this.grpDecisionReg.Controls.Add(this.btnAnnuler);
            this.grpDecisionReg.Controls.Add(this.btnConstituerEquipe);
            this.grpDecisionReg.Controls.Add(this.cboCaserne);
            this.grpDecisionReg.Controls.Add(this.cboNatureSinistre);
            this.grpDecisionReg.Controls.Add(this.lblCaserne);
            this.grpDecisionReg.Controls.Add(this.lblNatureSinistre);
            this.grpDecisionReg.ForeColor = System.Drawing.Color.Yellow;
            this.grpDecisionReg.Location = new System.Drawing.Point(11, 15);
            this.grpDecisionReg.Margin = new System.Windows.Forms.Padding(2);
            this.grpDecisionReg.Name = "grpDecisionReg";
            this.grpDecisionReg.Padding = new System.Windows.Forms.Padding(2);
            this.grpDecisionReg.Size = new System.Drawing.Size(1409, 183);
            this.grpDecisionReg.TabIndex = 0;
            this.grpDecisionReg.TabStop = false;
            this.grpDecisionReg.Text = "Décision du régulateur";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.Yellow;
            this.btnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAnnuler.FlatAppearance.BorderSize = 5;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAnnuler.Location = new System.Drawing.Point(683, 109);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(334, 59);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConstituerEquipe
            // 
            this.btnConstituerEquipe.BackColor = System.Drawing.Color.Yellow;
            this.btnConstituerEquipe.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnConstituerEquipe.FlatAppearance.BorderSize = 4;
            this.btnConstituerEquipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConstituerEquipe.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnConstituerEquipe.Location = new System.Drawing.Point(1061, 109);
            this.btnConstituerEquipe.Name = "btnConstituerEquipe";
            this.btnConstituerEquipe.Size = new System.Drawing.Size(334, 59);
            this.btnConstituerEquipe.TabIndex = 5;
            this.btnConstituerEquipe.Text = "Constituer l\'équipe";
            this.btnConstituerEquipe.UseVisualStyleBackColor = false;
            this.btnConstituerEquipe.Click += new System.EventHandler(this.btnConstituerEquipe_Click);
            // 
            // cboCaserne
            // 
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(1005, 44);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(390, 37);
            this.cboCaserne.TabIndex = 3;
            // 
            // cboNatureSinistre
            // 
            this.cboNatureSinistre.FormattingEnabled = true;
            this.cboNatureSinistre.Location = new System.Drawing.Point(295, 44);
            this.cboNatureSinistre.Name = "cboNatureSinistre";
            this.cboNatureSinistre.Size = new System.Drawing.Size(390, 37);
            this.cboNatureSinistre.TabIndex = 2;
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(709, 52);
            this.lblCaserne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(183, 29);
            this.lblCaserne.TabIndex = 1;
            this.lblCaserne.Text = "caserne à mobiliser";
            // 
            // lblNatureSinistre
            // 
            this.lblNatureSinistre.AutoSize = true;
            this.lblNatureSinistre.Location = new System.Drawing.Point(14, 47);
            this.lblNatureSinistre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNatureSinistre.Name = "lblNatureSinistre";
            this.lblNatureSinistre.Size = new System.Drawing.Size(166, 29);
            this.lblNatureSinistre.TabIndex = 0;
            this.lblNatureSinistre.Text = "Nature du sinistre";
            // 
            // pnlMobilisation
            // 
            this.pnlMobilisation.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlMobilisation.Controls.Add(this.grpMobilisation);
            this.pnlMobilisation.ForeColor = System.Drawing.Color.Yellow;
            this.pnlMobilisation.Location = new System.Drawing.Point(23, 620);
            this.pnlMobilisation.Name = "pnlMobilisation";
            this.pnlMobilisation.Size = new System.Drawing.Size(1445, 476);
            this.pnlMobilisation.TabIndex = 5;
            this.pnlMobilisation.Visible = false;
            // 
            // grpMobilisation
            // 
            this.grpMobilisation.Controls.Add(this.btnCreationM);
            this.grpMobilisation.Controls.Add(this.dgvPompiers);
            this.grpMobilisation.Controls.Add(this.dgvEngins);
            this.grpMobilisation.Controls.Add(this.lblPompiersMobilises);
            this.grpMobilisation.Controls.Add(this.lblEnginMobilises);
            this.grpMobilisation.ForeColor = System.Drawing.Color.Yellow;
            this.grpMobilisation.Location = new System.Drawing.Point(11, 13);
            this.grpMobilisation.Name = "grpMobilisation";
            this.grpMobilisation.Size = new System.Drawing.Size(1409, 445);
            this.grpMobilisation.TabIndex = 0;
            this.grpMobilisation.TabStop = false;
            this.grpMobilisation.Text = "Mobilisation des engins et des pompiers";
            // 
            // btnCreationM
            // 
            this.btnCreationM.BackColor = System.Drawing.Color.Yellow;
            this.btnCreationM.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCreationM.FlatAppearance.BorderSize = 4;
            this.btnCreationM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreationM.ForeColor = System.Drawing.Color.Firebrick;
            this.btnCreationM.Location = new System.Drawing.Point(546, 374);
            this.btnCreationM.Name = "btnCreationM";
            this.btnCreationM.Size = new System.Drawing.Size(327, 54);
            this.btnCreationM.TabIndex = 4;
            this.btnCreationM.Text = "Créer Mission";
            this.btnCreationM.UseVisualStyleBackColor = false;
            this.btnCreationM.Click += new System.EventHandler(this.btnCreationM_Click);
            // 
            // dgvPompiers
            // 
            this.dgvPompiers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPompiers.Location = new System.Drawing.Point(716, 117);
            this.dgvPompiers.Name = "dgvPompiers";
            this.dgvPompiers.RowHeadersWidth = 62;
            this.dgvPompiers.RowTemplate.Height = 28;
            this.dgvPompiers.Size = new System.Drawing.Size(664, 236);
            this.dgvPompiers.TabIndex = 3;
            // 
            // dgvEngins
            // 
            this.dgvEngins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEngins.Location = new System.Drawing.Point(21, 117);
            this.dgvEngins.Name = "dgvEngins";
            this.dgvEngins.RowHeadersWidth = 62;
            this.dgvEngins.RowTemplate.Height = 28;
            this.dgvEngins.Size = new System.Drawing.Size(664, 236);
            this.dgvEngins.TabIndex = 2;
            // 
            // lblPompiersMobilises
            // 
            this.lblPompiersMobilises.AutoSize = true;
            this.lblPompiersMobilises.Location = new System.Drawing.Point(918, 62);
            this.lblPompiersMobilises.Name = "lblPompiersMobilises";
            this.lblPompiersMobilises.Size = new System.Drawing.Size(183, 29);
            this.lblPompiersMobilises.TabIndex = 1;
            this.lblPompiersMobilises.Text = "Pompiers Mobilisés";
            // 
            // lblEnginMobilises
            // 
            this.lblEnginMobilises.AutoSize = true;
            this.lblEnginMobilises.Location = new System.Drawing.Point(194, 62);
            this.lblEnginMobilises.Name = "lblEnginMobilises";
            this.lblEnginMobilises.Size = new System.Drawing.Size(159, 29);
            this.lblEnginMobilises.TabIndex = 0;
            this.lblEnginMobilises.Text = "Engins mobilisés";
            // 
            // UCCreationMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.pnlMobilisation);
            this.Controls.Add(this.pnlDecisionReg);
            this.Controls.Add(this.pnlInfosUsagers);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblId);
            this.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UCCreationMission";
            this.Size = new System.Drawing.Size(1489, 836);
            this.grpInfosUsagers.ResumeLayout(false);
            this.grpInfosUsagers.PerformLayout();
            this.pnlInfosUsagers.ResumeLayout(false);
            this.pnlDecisionReg.ResumeLayout(false);
            this.grpDecisionReg.ResumeLayout(false);
            this.grpDecisionReg.PerformLayout();
            this.pnlMobilisation.ResumeLayout(false);
            this.grpMobilisation.ResumeLayout(false);
            this.grpMobilisation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPompiers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEngins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpInfosUsagers;
        private System.Windows.Forms.Label lblAdrSinistre;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Panel pnlInfosUsagers;
        private System.Windows.Forms.Panel pnlDecisionReg;
        private System.Windows.Forms.GroupBox grpDecisionReg;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblNatureSinistre;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.ComboBox cboNatureSinistre;
        private System.Windows.Forms.Button btnConstituerEquipe;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Panel pnlMobilisation;
        private System.Windows.Forms.GroupBox grpMobilisation;
        private System.Windows.Forms.Label lblPompiersMobilises;
        private System.Windows.Forms.Label lblEnginMobilises;
        private System.Windows.Forms.DataGridView dgvPompiers;
        private System.Windows.Forms.DataGridView dgvEngins;
        private System.Windows.Forms.Button btnCreationM;
    }
}
