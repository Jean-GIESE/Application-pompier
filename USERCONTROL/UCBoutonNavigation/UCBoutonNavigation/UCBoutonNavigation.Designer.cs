namespace UCBoutonNavigation
{
    partial class UCBoutonNavigation
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
            this.pnlFond = new System.Windows.Forms.Panel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblVollet = new System.Windows.Forms.Label();
            this.pnlFond.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFond
            // 
            this.pnlFond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlFond.Controls.Add(this.lblVollet);
            this.pnlFond.Controls.Add(this.pctLogo);
            this.pnlFond.Location = new System.Drawing.Point(3, 3);
            this.pnlFond.Name = "pnlFond";
            this.pnlFond.Size = new System.Drawing.Size(314, 89);
            this.pnlFond.TabIndex = 0;
            // 
            // pctLogo
            // 
            this.pctLogo.Location = new System.Drawing.Point(8, 6);
            this.pctLogo.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(77, 77);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // lblVollet
            // 
            this.lblVollet.AutoSize = true;
            this.lblVollet.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVollet.Location = new System.Drawing.Point(96, 32);
            this.lblVollet.Name = "lblVollet";
            this.lblVollet.Size = new System.Drawing.Size(120, 29);
            this.lblVollet.TabIndex = 1;
            this.lblVollet.Text = "PlaceHolder";
            // 
            // UCBoutonNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(this.pnlFond);
            this.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "UCBoutonNavigation";
            this.Size = new System.Drawing.Size(320, 95);
            this.pnlFond.ResumeLayout(false);
            this.pnlFond.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFond;
        private System.Windows.Forms.Label lblVollet;
        private System.Windows.Forms.PictureBox pctLogo;
    }
}
