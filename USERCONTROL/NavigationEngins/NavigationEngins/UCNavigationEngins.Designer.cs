namespace NavigationEngins
{
    partial class UCNavigationEngins
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
            this.chkPanne = new System.Windows.Forms.CheckBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTypeData = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(150, 72);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(252, 37);
            this.lblCaserne.TabIndex = 0;
            this.lblCaserne.Text = "Choix de la caserne";
            // 
            // lblPanne
            // 
            this.lblPanne.AutoSize = true;
            this.lblPanne.Location = new System.Drawing.Point(783, 357);
            this.lblPanne.Name = "lblPanne";
            this.lblPanne.Size = new System.Drawing.Size(132, 37);
            this.lblPanne.TabIndex = 1;
            this.lblPanne.Text = "En panne";
            // 
            // lblMission
            // 
            this.lblMission.AutoSize = true;
            this.lblMission.Location = new System.Drawing.Point(150, 357);
            this.lblMission.Name = "lblMission";
            this.lblMission.Size = new System.Drawing.Size(147, 37);
            this.lblMission.TabIndex = 2;
            this.lblMission.Text = "En mission";
            // 
            // lblDateData
            // 
            this.lblDateData.AutoSize = true;
            this.lblDateData.Location = new System.Drawing.Point(1120, 37);
            this.lblDateData.Name = "lblDateData";
            this.lblDateData.Size = new System.Drawing.Size(81, 37);
            this.lblDateData.TabIndex = 3;
            this.lblDateData.Text = "None";
            // 
            // lblNumData
            // 
            this.lblNumData.AutoSize = true;
            this.lblNumData.Location = new System.Drawing.Point(445, 37);
            this.lblNumData.Name = "lblNumData";
            this.lblNumData.Size = new System.Drawing.Size(81, 37);
            this.lblNumData.TabIndex = 4;
            this.lblNumData.Text = "None";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(150, 37);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(112, 37);
            this.lblNum.TabIndex = 5;
            this.lblNum.Text = "Numéro";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(783, 37);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(227, 37);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date de réception";
            // 
            // btnPremier
            // 
            this.btnPremier.BackColor = System.Drawing.Color.Yellow;
            this.btnPremier.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnPremier.FlatAppearance.BorderSize = 5;
            this.btnPremier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPremier.ForeColor = System.Drawing.Color.Black;
            this.btnPremier.Location = new System.Drawing.Point(169, 687);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(100, 100);
            this.btnPremier.TabIndex = 7;
            this.btnPremier.Text = "<<";
            this.btnPremier.UseVisualStyleBackColor = false;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // btnArriere
            // 
            this.btnArriere.BackColor = System.Drawing.Color.Yellow;
            this.btnArriere.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnArriere.FlatAppearance.BorderSize = 5;
            this.btnArriere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArriere.ForeColor = System.Drawing.Color.Black;
            this.btnArriere.Location = new System.Drawing.Point(379, 687);
            this.btnArriere.Name = "btnArriere";
            this.btnArriere.Size = new System.Drawing.Size(100, 100);
            this.btnArriere.TabIndex = 8;
            this.btnArriere.Text = "<";
            this.btnArriere.UseVisualStyleBackColor = false;
            this.btnArriere.Click += new System.EventHandler(this.btnArriere_Click);
            // 
            // btnAvant
            // 
            this.btnAvant.BackColor = System.Drawing.Color.Yellow;
            this.btnAvant.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAvant.FlatAppearance.BorderSize = 5;
            this.btnAvant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvant.ForeColor = System.Drawing.Color.Black;
            this.btnAvant.Location = new System.Drawing.Point(954, 687);
            this.btnAvant.Name = "btnAvant";
            this.btnAvant.Size = new System.Drawing.Size(100, 100);
            this.btnAvant.TabIndex = 9;
            this.btnAvant.Text = ">";
            this.btnAvant.UseVisualStyleBackColor = false;
            this.btnAvant.Click += new System.EventHandler(this.btnAvant_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.BackColor = System.Drawing.Color.Yellow;
            this.btnDernier.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnDernier.FlatAppearance.BorderSize = 5;
            this.btnDernier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDernier.ForeColor = System.Drawing.Color.Black;
            this.btnDernier.Location = new System.Drawing.Point(1149, 687);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(100, 100);
            this.btnDernier.TabIndex = 10;
            this.btnDernier.Text = ">>";
            this.btnDernier.UseVisualStyleBackColor = false;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // cboCaserne
            // 
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(505, 69);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(720, 45);
            this.cboCaserne.TabIndex = 11;
            // 
            // chkMission
            // 
            this.chkMission.AutoSize = true;
            this.chkMission.Enabled = false;
            this.chkMission.Location = new System.Drawing.Point(452, 369);
            this.chkMission.Name = "chkMission";
            this.chkMission.Size = new System.Drawing.Size(15, 14);
            this.chkMission.TabIndex = 12;
            this.chkMission.UseVisualStyleBackColor = true;
            // 
            // chkPanne
            // 
            this.chkPanne.AutoSize = true;
            this.chkPanne.Enabled = false;
            this.chkPanne.Location = new System.Drawing.Point(1137, 369);
            this.chkPanne.Name = "chkPanne";
            this.chkPanne.Size = new System.Drawing.Size(15, 14);
            this.chkPanne.TabIndex = 13;
            this.chkPanne.UseVisualStyleBackColor = true;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(150, 195);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(169, 37);
            this.lblType.TabIndex = 14;
            this.lblType.Text = "Type d\'engin";
            // 
            // lblTypeData
            // 
            this.lblTypeData.AutoSize = true;
            this.lblTypeData.Location = new System.Drawing.Point(445, 195);
            this.lblTypeData.Name = "lblTypeData";
            this.lblTypeData.Size = new System.Drawing.Size(81, 37);
            this.lblTypeData.TabIndex = 15;
            this.lblTypeData.Text = "None";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lblCaserne);
            this.panel1.Controls.Add(this.cboCaserne);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1480, 161);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.lblNum);
            this.panel2.Controls.Add(this.lblNumData);
            this.panel2.Controls.Add(this.chkPanne);
            this.panel2.Controls.Add(this.lblType);
            this.panel2.Controls.Add(this.chkMission);
            this.panel2.Controls.Add(this.lblTypeData);
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.lblDateData);
            this.panel2.Controls.Add(this.lblPanne);
            this.panel2.Controls.Add(this.lblMission);
            this.panel2.Location = new System.Drawing.Point(12, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1480, 450);
            this.panel2.TabIndex = 17;
            // 
            // UCNavigationEngins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.btnAvant);
            this.Controls.Add(this.btnArriere);
            this.Controls.Add(this.btnPremier);
            this.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "UCNavigationEngins";
            this.Size = new System.Drawing.Size(1506, 836);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.CheckBox chkPanne;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTypeData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
