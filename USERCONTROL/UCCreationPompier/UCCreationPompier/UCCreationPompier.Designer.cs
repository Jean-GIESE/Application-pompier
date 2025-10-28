namespace UCCreationPompier
{
    partial class UCCreationPompier
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
            this.lblMatriculeCrea = new System.Windows.Forms.Label();
            this.lblMatriculeDataCrea = new System.Windows.Forms.Label();
            this.lblNomCrea = new System.Windows.Forms.Label();
            this.lblPrenomCrea = new System.Windows.Forms.Label();
            this.grpSexe = new System.Windows.Forms.GroupBox();
            this.rdbFemCrea = new System.Windows.Forms.RadioButton();
            this.rdbMascCrea = new System.Windows.Forms.RadioButton();
            this.lblDateNaissanceCrea = new System.Windows.Forms.Label();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.rdbVolCrea = new System.Windows.Forms.RadioButton();
            this.rdbProCrea = new System.Windows.Forms.RadioButton();
            this.lblTelCrea = new System.Windows.Forms.Label();
            this.lblBipCrea = new System.Windows.Forms.Label();
            this.lblCaserneRattachementCrea = new System.Windows.Forms.Label();
            this.cboCaserneRattachementCrea = new System.Windows.Forms.ComboBox();
            this.btnValiderCreation = new System.Windows.Forms.Button();
            this.btnAnnulerCrea = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.txtNomCrea = new System.Windows.Forms.TextBox();
            this.txtPrenomCrea = new System.Windows.Forms.TextBox();
            this.txtTelCrea = new System.Windows.Forms.TextBox();
            this.txtBipCrea = new System.Windows.Forms.TextBox();
            this.dtpDateNaissanceCrea = new System.Windows.Forms.DateTimePicker();
            this.grpSexe.SuspendLayout();
            this.grpType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatriculeCrea
            // 
            this.lblMatriculeCrea.AutoSize = true;
            this.lblMatriculeCrea.Location = new System.Drawing.Point(887, 170);
            this.lblMatriculeCrea.Name = "lblMatriculeCrea";
            this.lblMatriculeCrea.Size = new System.Drawing.Size(139, 37);
            this.lblMatriculeCrea.TabIndex = 11;
            this.lblMatriculeCrea.Text = "Matricule :";
            // 
            // lblMatriculeDataCrea
            // 
            this.lblMatriculeDataCrea.AutoSize = true;
            this.lblMatriculeDataCrea.Location = new System.Drawing.Point(1044, 170);
            this.lblMatriculeDataCrea.Name = "lblMatriculeDataCrea";
            this.lblMatriculeDataCrea.Size = new System.Drawing.Size(159, 37);
            this.lblMatriculeDataCrea.TabIndex = 12;
            this.lblMatriculeDataCrea.Text = "Placeholder";
            // 
            // lblNomCrea
            // 
            this.lblNomCrea.AutoSize = true;
            this.lblNomCrea.Location = new System.Drawing.Point(39, 166);
            this.lblNomCrea.Name = "lblNomCrea";
            this.lblNomCrea.Size = new System.Drawing.Size(87, 37);
            this.lblNomCrea.TabIndex = 13;
            this.lblNomCrea.Text = "Nom :";
            // 
            // lblPrenomCrea
            // 
            this.lblPrenomCrea.AutoSize = true;
            this.lblPrenomCrea.Location = new System.Drawing.Point(39, 237);
            this.lblPrenomCrea.Name = "lblPrenomCrea";
            this.lblPrenomCrea.Size = new System.Drawing.Size(125, 37);
            this.lblPrenomCrea.TabIndex = 14;
            this.lblPrenomCrea.Text = "Prénom :";
            // 
            // grpSexe
            // 
            this.grpSexe.Controls.Add(this.rdbFemCrea);
            this.grpSexe.Controls.Add(this.rdbMascCrea);
            this.grpSexe.Location = new System.Drawing.Point(46, 371);
            this.grpSexe.Name = "grpSexe";
            this.grpSexe.Size = new System.Drawing.Size(451, 161);
            this.grpSexe.TabIndex = 15;
            this.grpSexe.TabStop = false;
            this.grpSexe.Text = "Sexe :";
            // 
            // rdbFemCrea
            // 
            this.rdbFemCrea.AutoSize = true;
            this.rdbFemCrea.Location = new System.Drawing.Point(219, 77);
            this.rdbFemCrea.Name = "rdbFemCrea";
            this.rdbFemCrea.Size = new System.Drawing.Size(130, 41);
            this.rdbFemCrea.TabIndex = 1;
            this.rdbFemCrea.TabStop = true;
            this.rdbFemCrea.Text = "Feminin";
            this.rdbFemCrea.UseVisualStyleBackColor = true;
            // 
            // rdbMascCrea
            // 
            this.rdbMascCrea.AutoSize = true;
            this.rdbMascCrea.Location = new System.Drawing.Point(26, 77);
            this.rdbMascCrea.Name = "rdbMascCrea";
            this.rdbMascCrea.Size = new System.Drawing.Size(140, 41);
            this.rdbMascCrea.TabIndex = 0;
            this.rdbMascCrea.TabStop = true;
            this.rdbMascCrea.Text = "Masculin";
            this.rdbMascCrea.UseVisualStyleBackColor = true;
            // 
            // lblDateNaissanceCrea
            // 
            this.lblDateNaissanceCrea.AutoSize = true;
            this.lblDateNaissanceCrea.Location = new System.Drawing.Point(39, 312);
            this.lblDateNaissanceCrea.Name = "lblDateNaissanceCrea";
            this.lblDateNaissanceCrea.Size = new System.Drawing.Size(251, 37);
            this.lblDateNaissanceCrea.TabIndex = 16;
            this.lblDateNaissanceCrea.Text = "Date de naissance :";
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.rdbVolCrea);
            this.grpType.Controls.Add(this.rdbProCrea);
            this.grpType.Location = new System.Drawing.Point(912, 389);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(451, 143);
            this.grpType.TabIndex = 16;
            this.grpType.TabStop = false;
            this.grpType.Text = "Type :";
            // 
            // rdbVolCrea
            // 
            this.rdbVolCrea.AutoSize = true;
            this.rdbVolCrea.Location = new System.Drawing.Point(258, 59);
            this.rdbVolCrea.Name = "rdbVolCrea";
            this.rdbVolCrea.Size = new System.Drawing.Size(156, 41);
            this.rdbVolCrea.TabIndex = 3;
            this.rdbVolCrea.TabStop = true;
            this.rdbVolCrea.Text = "Volontaire";
            this.rdbVolCrea.UseVisualStyleBackColor = true;
            // 
            // rdbProCrea
            // 
            this.rdbProCrea.AutoSize = true;
            this.rdbProCrea.Location = new System.Drawing.Point(24, 59);
            this.rdbProCrea.Name = "rdbProCrea";
            this.rdbProCrea.Size = new System.Drawing.Size(197, 41);
            this.rdbProCrea.TabIndex = 2;
            this.rdbProCrea.TabStop = true;
            this.rdbProCrea.Text = "Professionnel";
            this.rdbProCrea.UseVisualStyleBackColor = true;
            // 
            // lblTelCrea
            // 
            this.lblTelCrea.AutoSize = true;
            this.lblTelCrea.Location = new System.Drawing.Point(887, 312);
            this.lblTelCrea.Name = "lblTelCrea";
            this.lblTelCrea.Size = new System.Drawing.Size(158, 37);
            this.lblTelCrea.TabIndex = 23;
            this.lblTelCrea.Text = "Téléphone :";
            // 
            // lblBipCrea
            // 
            this.lblBipCrea.AutoSize = true;
            this.lblBipCrea.Location = new System.Drawing.Point(887, 237);
            this.lblBipCrea.Name = "lblBipCrea";
            this.lblBipCrea.Size = new System.Drawing.Size(74, 37);
            this.lblBipCrea.TabIndex = 24;
            this.lblBipCrea.Text = "BIP :";
            // 
            // lblCaserneRattachementCrea
            // 
            this.lblCaserneRattachementCrea.AutoSize = true;
            this.lblCaserneRattachementCrea.Location = new System.Drawing.Point(327, 82);
            this.lblCaserneRattachementCrea.Name = "lblCaserneRattachementCrea";
            this.lblCaserneRattachementCrea.Size = new System.Drawing.Size(331, 37);
            this.lblCaserneRattachementCrea.TabIndex = 25;
            this.lblCaserneRattachementCrea.Text = "Caserne de rattachement :";
            // 
            // cboCaserneRattachementCrea
            // 
            this.cboCaserneRattachementCrea.FormattingEnabled = true;
            this.cboCaserneRattachementCrea.Location = new System.Drawing.Point(737, 82);
            this.cboCaserneRattachementCrea.Name = "cboCaserneRattachementCrea";
            this.cboCaserneRattachementCrea.Size = new System.Drawing.Size(427, 45);
            this.cboCaserneRattachementCrea.TabIndex = 27;
            this.cboCaserneRattachementCrea.SelectedIndexChanged += new System.EventHandler(this.cboCaserneRattachementCrea_SelectedIndexChanged);
            // 
            // btnValiderCreation
            // 
            this.btnValiderCreation.BackColor = System.Drawing.Color.Yellow;
            this.btnValiderCreation.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnValiderCreation.FlatAppearance.BorderSize = 5;
            this.btnValiderCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValiderCreation.Location = new System.Drawing.Point(1096, 538);
            this.btnValiderCreation.Name = "btnValiderCreation";
            this.btnValiderCreation.Size = new System.Drawing.Size(358, 101);
            this.btnValiderCreation.TabIndex = 28;
            this.btnValiderCreation.Text = "Valider la Création";
            this.btnValiderCreation.UseVisualStyleBackColor = false;
            this.btnValiderCreation.Click += new System.EventHandler(this.btnValiderCreation_Click);
            // 
            // btnAnnulerCrea
            // 
            this.btnAnnulerCrea.BackColor = System.Drawing.Color.Yellow;
            this.btnAnnulerCrea.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAnnulerCrea.FlatAppearance.BorderSize = 5;
            this.btnAnnulerCrea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerCrea.Location = new System.Drawing.Point(27, 538);
            this.btnAnnulerCrea.Name = "btnAnnulerCrea";
            this.btnAnnulerCrea.Size = new System.Drawing.Size(358, 101);
            this.btnAnnulerCrea.TabIndex = 29;
            this.btnAnnulerCrea.Text = "Annuler";
            this.btnAnnulerCrea.UseVisualStyleBackColor = false;
            this.btnAnnulerCrea.Click += new System.EventHandler(this.btnAnnulerCrea_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Red;
            this.lblTitre.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.ForeColor = System.Drawing.Color.Yellow;
            this.lblTitre.Location = new System.Drawing.Point(597, 22);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(291, 43);
            this.lblTitre.TabIndex = 30;
            this.lblTitre.Text = "MODE : CREATION";
            // 
            // txtNomCrea
            // 
            this.txtNomCrea.Location = new System.Drawing.Point(334, 163);
            this.txtNomCrea.Name = "txtNomCrea";
            this.txtNomCrea.Size = new System.Drawing.Size(402, 44);
            this.txtNomCrea.TabIndex = 31;
            // 
            // txtPrenomCrea
            // 
            this.txtPrenomCrea.Location = new System.Drawing.Point(334, 234);
            this.txtPrenomCrea.Name = "txtPrenomCrea";
            this.txtPrenomCrea.Size = new System.Drawing.Size(402, 44);
            this.txtPrenomCrea.TabIndex = 32;
            // 
            // txtTelCrea
            // 
            this.txtTelCrea.Location = new System.Drawing.Point(1051, 309);
            this.txtTelCrea.Name = "txtTelCrea";
            this.txtTelCrea.Size = new System.Drawing.Size(403, 44);
            this.txtTelCrea.TabIndex = 33;
            // 
            // txtBipCrea
            // 
            this.txtBipCrea.Location = new System.Drawing.Point(1051, 230);
            this.txtBipCrea.Name = "txtBipCrea";
            this.txtBipCrea.Size = new System.Drawing.Size(403, 44);
            this.txtBipCrea.TabIndex = 34;
            // 
            // dtpDateNaissanceCrea
            // 
            this.dtpDateNaissanceCrea.Location = new System.Drawing.Point(334, 312);
            this.dtpDateNaissanceCrea.Name = "dtpDateNaissanceCrea";
            this.dtpDateNaissanceCrea.Size = new System.Drawing.Size(402, 44);
            this.dtpDateNaissanceCrea.TabIndex = 35;
            // 
            // UCCreationPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.dtpDateNaissanceCrea);
            this.Controls.Add(this.txtBipCrea);
            this.Controls.Add(this.txtTelCrea);
            this.Controls.Add(this.txtPrenomCrea);
            this.Controls.Add(this.txtNomCrea);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.btnAnnulerCrea);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnValiderCreation);
            this.Controls.Add(this.cboCaserneRattachementCrea);
            this.Controls.Add(this.lblCaserneRattachementCrea);
            this.Controls.Add(this.lblBipCrea);
            this.Controls.Add(this.lblTelCrea);
            this.Controls.Add(this.lblDateNaissanceCrea);
            this.Controls.Add(this.grpSexe);
            this.Controls.Add(this.lblPrenomCrea);
            this.Controls.Add(this.lblNomCrea);
            this.Controls.Add(this.lblMatriculeDataCrea);
            this.Controls.Add(this.lblMatriculeCrea);
            this.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "UCCreationPompier";
            this.Size = new System.Drawing.Size(1475, 657);
            this.grpSexe.ResumeLayout(false);
            this.grpSexe.PerformLayout();
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatriculeCrea;
        private System.Windows.Forms.Label lblMatriculeDataCrea;
        private System.Windows.Forms.Label lblNomCrea;
        private System.Windows.Forms.Label lblPrenomCrea;
        private System.Windows.Forms.GroupBox grpSexe;
        private System.Windows.Forms.Label lblDateNaissanceCrea;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.Label lblTelCrea;
        private System.Windows.Forms.Label lblBipCrea;
        private System.Windows.Forms.Label lblCaserneRattachementCrea;
        private System.Windows.Forms.ComboBox cboCaserneRattachementCrea;
        private System.Windows.Forms.Button btnValiderCreation;
        private System.Windows.Forms.Button btnAnnulerCrea;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.RadioButton rdbFemCrea;
        private System.Windows.Forms.RadioButton rdbMascCrea;
        private System.Windows.Forms.RadioButton rdbVolCrea;
        private System.Windows.Forms.RadioButton rdbProCrea;
        private System.Windows.Forms.TextBox txtNomCrea;
        private System.Windows.Forms.TextBox txtPrenomCrea;
        private System.Windows.Forms.TextBox txtTelCrea;
        private System.Windows.Forms.TextBox txtBipCrea;
        private System.Windows.Forms.DateTimePicker dtpDateNaissanceCrea;
    }
}
