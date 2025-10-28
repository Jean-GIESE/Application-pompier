namespace UCtableauDeBord
{
    partial class UCtableauDeBord
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
            this.lblTableauBord = new System.Windows.Forms.Label();
            this.chkEnCours = new System.Windows.Forms.CheckBox();
            this.pnlBleu = new System.Windows.Forms.Panel();
            this.pnlGris = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTableauBord
            // 
            this.lblTableauBord.AutoSize = true;
            this.lblTableauBord.Location = new System.Drawing.Point(595, 35);
            this.lblTableauBord.Name = "lblTableauBord";
            this.lblTableauBord.Size = new System.Drawing.Size(212, 37);
            this.lblTableauBord.TabIndex = 0;
            this.lblTableauBord.Text = "Tableau de bord";
            // 
            // chkEnCours
            // 
            this.chkEnCours.AutoSize = true;
            this.chkEnCours.Location = new System.Drawing.Point(23, 88);
            this.chkEnCours.Name = "chkEnCours";
            this.chkEnCours.Size = new System.Drawing.Size(141, 41);
            this.chkEnCours.TabIndex = 1;
            this.chkEnCours.Text = "En cours";
            this.chkEnCours.UseVisualStyleBackColor = true;
            this.chkEnCours.CheckedChanged += new System.EventHandler(this.chkEnCours_CheckedChanged);
            // 
            // pnlBleu
            // 
            this.pnlBleu.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlBleu.Location = new System.Drawing.Point(20, 155);
            this.pnlBleu.Name = "pnlBleu";
            this.pnlBleu.Size = new System.Drawing.Size(1461, 29);
            this.pnlBleu.TabIndex = 2;
            // 
            // pnlGris
            // 
            this.pnlGris.AutoScroll = true;
            this.pnlGris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGris.Location = new System.Drawing.Point(20, 210);
            this.pnlGris.Name = "pnlGris";
            this.pnlGris.Size = new System.Drawing.Size(1461, 607);
            this.pnlGris.TabIndex = 3;
            // 
            // UCtableauDeBord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.pnlGris);
            this.Controls.Add(this.pnlBleu);
            this.Controls.Add(this.chkEnCours);
            this.Controls.Add(this.lblTableauBord);
            this.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "UCtableauDeBord";
            this.Size = new System.Drawing.Size(1506, 836);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableauBord;
        private System.Windows.Forms.CheckBox chkEnCours;
        private System.Windows.Forms.Panel pnlBleu;
        private System.Windows.Forms.Panel pnlGris;
    }
}
