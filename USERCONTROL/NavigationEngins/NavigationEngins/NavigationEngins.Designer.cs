namespace NavigationEngins
{
    partial class NavigationEngins
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
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblPanne = new System.Windows.Forms.Label();
            this.lblMission = new System.Windows.Forms.Label();
            this.lblDateData = new System.Windows.Forms.Label();
            this.lblNumData = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnArriere = new System.Windows.Forms.Button();
            this.btnAvant = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.chkMission = new System.Windows.Forms.CheckBox();
            this.choPanne = new System.Windows.Forms.CheckBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTypeData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(425, 89);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(252, 37);
            this.lblCaserne.TabIndex = 0;
            this.lblCaserne.Text = "Choix de la caserne";
            // 
            // lblPanne
            // 
            this.lblPanne.AutoSize = true;
            this.lblPanne.Location = new System.Drawing.Point(416, 789);
            this.lblPanne.Name = "lblPanne";
            this.lblPanne.Size = new System.Drawing.Size(132, 37);
            this.lblPanne.TabIndex = 1;
            this.lblPanne.Text = "En panne";
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Location = new System.Drawing.Point(416, 617);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(147, 37);
            this.lblMission.TabIndex = 2;
            this.lblMission.Text = "En mission";
            // 
            // lblDateData
            // 
            this.lblDateData.AutoSize = true;
            this.lblDateData.Location = new System.Drawing.Point(1408, 277);
            this.lblDateData.Name = "lblDateData";
            this.lblDateData.Size = new System.Drawing.Size(81, 37);
            this.lblDateData.TabIndex = 3;
            this.lblDateData.Text = "None";
            // 
            // lblNumData
            // 
            this.lblNumData.AutoSize = true;
            this.lblNumData.Location = new System.Drawing.Point(746, 277);
            this.lblNumData.Name = "lblNumData";
            this.lblNumData.Size = new System.Drawing.Size(81, 37);
            this.lblNumData.TabIndex = 4;
            this.lblNumData.Text = "None";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(425, 277);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(112, 37);
            this.lblNum.TabIndex = 5;
            this.lblNum.Text = "Numéro";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(1087, 277);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(227, 37);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date de réception";
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(517, 1136);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(100, 100);
            this.btnPremier.TabIndex = 7;
            this.btnPremier.Text = "<<";
            this.btnPremier.UseVisualStyleBackColor = true;
            // 
            // btnArriere
            // 
            this.btnArriere.Location = new System.Drawing.Point(731, 1136);
            this.btnArriere.Name = "btnArriere";
            this.btnArriere.Size = new System.Drawing.Size(100, 100);
            this.btnArriere.TabIndex = 8;
            this.btnArriere.Text = "<";
            this.btnArriere.UseVisualStyleBackColor = true;
            // 
            // btnAvant
            // 
            this.btnAvant.Location = new System.Drawing.Point(1029, 1136);
            this.btnAvant.Name = "btnAvant";
            this.btnAvant.Size = new System.Drawing.Size(100, 100);
            this.btnAvant.TabIndex = 9;
            this.btnAvant.Text = ">";
            this.btnAvant.UseVisualStyleBackColor = true;
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(1223, 1136);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(100, 100);
            this.btnDernier.TabIndex = 10;
            this.btnDernier.Text = ">>";
            this.btnDernier.UseVisualStyleBackColor = true;
            // 
            // cboCaserne
            // 
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(753, 86);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(720, 45);
            this.cboCaserne.TabIndex = 11;
            // 
            // chkMission
            // 
            this.chkMission.AutoSize = true;
            this.chkMission.Location = new System.Drawing.Point(753, 613);
            this.chkMission.Name = "chkMission";
            this.chkMission.Size = new System.Drawing.Size(15, 14);
            this.chkMission.TabIndex = 12;
            this.chkMission.UseVisualStyleBackColor = true;
            // 
            // choPanne
            // 
            this.choPanne.AutoSize = true;
            this.choPanne.Location = new System.Drawing.Point(753, 789);
            this.choPanne.Name = "choPanne";
            this.choPanne.Size = new System.Drawing.Size(15, 14);
            this.choPanne.TabIndex = 13;
            this.choPanne.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(425, 432);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(169, 37);
            this.lblType.TabIndex = 14;
            this.lblType.Text = "Type d\'engin";
            // 
            // lblTypeData
            // 
            this.lblTypeData.AutoSize = true;
            this.lblTypeData.Location = new System.Drawing.Point(746, 432);
            this.lblTypeData.Name = "lblTypeData";
            this.lblTypeData.Size = new System.Drawing.Size(81, 37);
            this.lblTypeData.TabIndex = 15;
            this.lblTypeData.Text = "None";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTypeData);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.choPanne);
            this.Controls.Add(this.chkMission);
            this.Controls.Add(this.cboCaserne);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.btnAvant);
            this.Controls.Add(this.btnArriere);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblNumData);
            this.Controls.Add(this.lblDateData);
            this.Controls.Add(this.lblMission);
            this.Controls.Add(this.lblPanne);
            this.Controls.Add(this.lblCaserne);
            this.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(2000, 1281);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblPanne;
        private System.Windows.Forms.Label lblMission;
        private System.Windows.Forms.Label lblDateData;
        private System.Windows.Forms.Label lblNumData;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnArriere;
        private System.Windows.Forms.Button btnAvant;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.CheckBox chkMission;
        private System.Windows.Forms.CheckBox choPanne;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTypeData;
    }
}
