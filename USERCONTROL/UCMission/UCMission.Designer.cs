namespace UCMission
{
    partial class UCMission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMission));
            this.lblId = new System.Windows.Forms.Label();
            this.lblDateHeureDepart = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.lblMotifAppel = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.pctImage = new System.Windows.Forms.PictureBox();
            this.pnlCouleur = new System.Windows.Forms.Panel();
            this.lblNature = new System.Windows.Forms.Label();
            this.pnlFondJaune = new System.Windows.Forms.Panel();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnMission = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).BeginInit();
            this.pnlCouleur.SuspendLayout();
            this.pnlFondJaune.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(183, 110);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(47, 46);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblDateHeureDepart
            // 
            this.lblDateHeureDepart.Location = new System.Drawing.Point(490, 111);
            this.lblDateHeureDepart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateHeureDepart.Name = "lblDateHeureDepart";
            this.lblDateHeureDepart.Size = new System.Drawing.Size(350, 46);
            this.lblDateHeureDepart.TabIndex = 1;
            this.lblDateHeureDepart.Text = "Date";
            this.lblDateHeureDepart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCaserne
            // 
            this.lblCaserne.Location = new System.Drawing.Point(856, 111);
            this.lblCaserne.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCaserne.Size = new System.Drawing.Size(350, 46);
            this.lblCaserne.TabIndex = 3;
            this.lblCaserne.Text = "Caserne";
            this.lblCaserne.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblMotifAppel
            // 
            this.lblMotifAppel.Font = new System.Drawing.Font("Arial Narrow", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotifAppel.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMotifAppel.Location = new System.Drawing.Point(428, 8);
            this.lblMotifAppel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotifAppel.Name = "lblMotifAppel";
            this.lblMotifAppel.Size = new System.Drawing.Size(437, 114);
            this.lblMotifAppel.TabIndex = 4;
            this.lblMotifAppel.Text = "Motif";
            this.lblMotifAppel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(183, 16);
            this.lblVille.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(81, 46);
            this.lblVille.TabIndex = 5;
            this.lblVille.Text = "Ville";
            // 
            // pctImage
            // 
            this.pctImage.Location = new System.Drawing.Point(12, 28);
            this.pctImage.Margin = new System.Windows.Forms.Padding(2);
            this.pctImage.Name = "pctImage";
            this.pctImage.Size = new System.Drawing.Size(150, 111);
            this.pctImage.TabIndex = 6;
            this.pctImage.TabStop = false;
            // 
            // pnlCouleur
            // 
            this.pnlCouleur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlCouleur.Controls.Add(this.pctImage);
            this.pnlCouleur.Controls.Add(this.lblId);
            this.pnlCouleur.Controls.Add(this.lblNature);
            this.pnlCouleur.Controls.Add(this.lblCaserne);
            this.pnlCouleur.Controls.Add(this.lblVille);
            this.pnlCouleur.Controls.Add(this.lblMotifAppel);
            this.pnlCouleur.Controls.Add(this.lblDateHeureDepart);
            this.pnlCouleur.Location = new System.Drawing.Point(15, 12);
            this.pnlCouleur.Name = "pnlCouleur";
            this.pnlCouleur.Size = new System.Drawing.Size(1214, 171);
            this.pnlCouleur.TabIndex = 7;
            // 
            // lblNature
            // 
            this.lblNature.Font = new System.Drawing.Font("Arial Narrow", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNature.Location = new System.Drawing.Point(856, 16);
            this.lblNature.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(350, 86);
            this.lblNature.TabIndex = 2;
            this.lblNature.Text = "Nature";
            this.lblNature.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlFondJaune
            // 
            this.pnlFondJaune.BackColor = System.Drawing.Color.Yellow;
            this.pnlFondJaune.Controls.Add(this.btnPDF);
            this.pnlFondJaune.Controls.Add(this.btnMission);
            this.pnlFondJaune.Location = new System.Drawing.Point(1242, 12);
            this.pnlFondJaune.Name = "pnlFondJaune";
            this.pnlFondJaune.Size = new System.Drawing.Size(161, 171);
            this.pnlFondJaune.TabIndex = 8;
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.Yellow;
            this.btnPDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPDF.BackgroundImage")));
            this.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPDF.Location = new System.Drawing.Point(47, 92);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(70, 70);
            this.btnPDF.TabIndex = 1;
            this.btnPDF.UseVisualStyleBackColor = false;
            // 
            // btnMission
            // 
            this.btnMission.BackColor = System.Drawing.Color.Yellow;
            this.btnMission.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMission.BackgroundImage")));
            this.btnMission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMission.Location = new System.Drawing.Point(47, 10);
            this.btnMission.Name = "btnMission";
            this.btnMission.Size = new System.Drawing.Size(70, 70);
            this.btnMission.TabIndex = 0;
            this.btnMission.UseVisualStyleBackColor = false;
            this.btnMission.Click += new System.EventHandler(this.btnMission_Click);
            // 
            // UCMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.Controls.Add(this.pnlFondJaune);
            this.Controls.Add(this.pnlCouleur);
            this.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "UCMission";
            this.Size = new System.Drawing.Size(1413, 196);
            ((System.ComponentModel.ISupportInitialize)(this.pctImage)).EndInit();
            this.pnlCouleur.ResumeLayout(false);
            this.pnlCouleur.PerformLayout();
            this.pnlFondJaune.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDateHeureDepart;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Label lblMotifAppel;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.PictureBox pctImage;
        private System.Windows.Forms.Panel pnlCouleur;
        private System.Windows.Forms.Panel pnlFondJaune;
        private System.Windows.Forms.Button btnMission;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Label lblNature;
    }
}
