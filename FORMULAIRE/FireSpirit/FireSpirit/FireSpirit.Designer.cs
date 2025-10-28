namespace FireSpirit
{
    partial class frmFireSpirit
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFireSpirit));
            this.pnlNavigateur = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.UCBtnNavStat = new UCBoutonNavigation.UCBoutonNavigation();
            this.UCBtnNavPompier = new UCBoutonNavigation.UCBoutonNavigation();
            this.UCBtnNavMission = new UCBoutonNavigation.UCBoutonNavigation();
            this.UCBtnNavTableau = new UCBoutonNavigation.UCBoutonNavigation();
            this.UCBtnNavEngin = new UCBoutonNavigation.UCBoutonNavigation();
            this.pnlPlaceHolder = new System.Windows.Forms.Panel();
            this.UCCreationMission = new UCCreationMission.UCCreationMission();
            this.UCNavigationEngins = new NavigationEngins.UCNavigationEngins();
            this.lblChargement = new System.Windows.Forms.Label();
            this.UCGestionPompier = new UCGestionPompier.UCGestionPompier();
            this.UCTableauDeBord = new UCtableauDeBord.UCtableauDeBord();
            this.pnlNavigateur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.pnlPlaceHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavigateur
            // 
            this.pnlNavigateur.BackColor = System.Drawing.Color.Crimson;
            this.pnlNavigateur.Controls.Add(this.lblLogo);
            this.pnlNavigateur.Controls.Add(this.pcbLogo);
            this.pnlNavigateur.Controls.Add(this.btnQuitter);
            this.pnlNavigateur.Controls.Add(this.UCBtnNavStat);
            this.pnlNavigateur.Controls.Add(this.UCBtnNavPompier);
            this.pnlNavigateur.Controls.Add(this.UCBtnNavMission);
            this.pnlNavigateur.Controls.Add(this.UCBtnNavTableau);
            this.pnlNavigateur.Controls.Add(this.UCBtnNavEngin);
            this.pnlNavigateur.Location = new System.Drawing.Point(12, 12);
            this.pnlNavigateur.Name = "pnlNavigateur";
            this.pnlNavigateur.Size = new System.Drawing.Size(347, 836);
            this.pnlNavigateur.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Orange;
            this.lblLogo.Location = new System.Drawing.Point(90, 18);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(242, 75);
            this.lblLogo.TabIndex = 7;
            this.lblLogo.Text = "FireSpirit";
            // 
            // pcbLogo
            // 
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(3, 3);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(100, 100);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLogo.TabIndex = 6;
            this.pcbLogo.TabStop = false;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuitter.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnQuitter.FlatAppearance.BorderSize = 2;
            this.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitter.ForeColor = System.Drawing.Color.Black;
            this.btnQuitter.Location = new System.Drawing.Point(93, 753);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(160, 63);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // UCBtnNavStat
            // 
            this.UCBtnNavStat.BackColor = System.Drawing.Color.Yellow;
            this.UCBtnNavStat.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCBtnNavStat.Location = new System.Drawing.Point(12, 584);
            this.UCBtnNavStat.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.UCBtnNavStat.Name = "UCBtnNavStat";
            this.UCBtnNavStat.NomImage = ((System.Drawing.Image)(resources.GetObject("UCBtnNavStat.NomImage")));
            this.UCBtnNavStat.Size = new System.Drawing.Size(320, 95);
            this.UCBtnNavStat.TabIndex = 4;
            this.UCBtnNavStat.Texte = "Statistiques";
            // 
            // UCBtnNavPompier
            // 
            this.UCBtnNavPompier.BackColor = System.Drawing.Color.Yellow;
            this.UCBtnNavPompier.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCBtnNavPompier.Location = new System.Drawing.Point(12, 471);
            this.UCBtnNavPompier.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.UCBtnNavPompier.Name = "UCBtnNavPompier";
            this.UCBtnNavPompier.NomImage = ((System.Drawing.Image)(resources.GetObject("UCBtnNavPompier.NomImage")));
            this.UCBtnNavPompier.Size = new System.Drawing.Size(320, 95);
            this.UCBtnNavPompier.TabIndex = 3;
            this.UCBtnNavPompier.Texte = "Gestion Personnel";
            this.UCBtnNavPompier.Click += new System.EventHandler(this.UCBtnNavPompier_Click);
            // 
            // UCBtnNavMission
            // 
            this.UCBtnNavMission.BackColor = System.Drawing.Color.Yellow;
            this.UCBtnNavMission.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCBtnNavMission.Location = new System.Drawing.Point(12, 245);
            this.UCBtnNavMission.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.UCBtnNavMission.Name = "UCBtnNavMission";
            this.UCBtnNavMission.NomImage = ((System.Drawing.Image)(resources.GetObject("UCBtnNavMission.NomImage")));
            this.UCBtnNavMission.Size = new System.Drawing.Size(320, 95);
            this.UCBtnNavMission.TabIndex = 2;
            this.UCBtnNavMission.Texte = "Nouvelle Mission";
            this.UCBtnNavMission.Click += new System.EventHandler(this.UCBtnNavMission_Click);
            // 
            // UCBtnNavTableau
            // 
            this.UCBtnNavTableau.BackColor = System.Drawing.Color.Yellow;
            this.UCBtnNavTableau.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCBtnNavTableau.Location = new System.Drawing.Point(12, 132);
            this.UCBtnNavTableau.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.UCBtnNavTableau.Name = "UCBtnNavTableau";
            this.UCBtnNavTableau.NomImage = ((System.Drawing.Image)(resources.GetObject("UCBtnNavTableau.NomImage")));
            this.UCBtnNavTableau.Size = new System.Drawing.Size(320, 95);
            this.UCBtnNavTableau.TabIndex = 1;
            this.UCBtnNavTableau.Texte = "Tableau de Bord";
            this.UCBtnNavTableau.Click += new System.EventHandler(this.UCBtnNavTableau_Click);
            // 
            // UCBtnNavEngin
            // 
            this.UCBtnNavEngin.BackColor = System.Drawing.Color.Yellow;
            this.UCBtnNavEngin.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCBtnNavEngin.Location = new System.Drawing.Point(12, 358);
            this.UCBtnNavEngin.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.UCBtnNavEngin.Name = "UCBtnNavEngin";
            this.UCBtnNavEngin.NomImage = ((System.Drawing.Image)(resources.GetObject("UCBtnNavEngin.NomImage")));
            this.UCBtnNavEngin.Size = new System.Drawing.Size(320, 95);
            this.UCBtnNavEngin.TabIndex = 0;
            this.UCBtnNavEngin.Texte = "Gestion Engins";
            this.UCBtnNavEngin.Click += new System.EventHandler(this.UCBtnNavEngin_Click);
            // 
            // pnlPlaceHolder
            // 
            this.pnlPlaceHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlPlaceHolder.Controls.Add(this.UCTableauDeBord);
            this.pnlPlaceHolder.Controls.Add(this.UCCreationMission);
            this.pnlPlaceHolder.Controls.Add(this.UCGestionPompier);
            this.pnlPlaceHolder.Controls.Add(this.UCNavigationEngins);
            this.pnlPlaceHolder.Controls.Add(this.lblChargement);
            this.pnlPlaceHolder.Location = new System.Drawing.Point(366, 13);
            this.pnlPlaceHolder.Name = "pnlPlaceHolder";
            this.pnlPlaceHolder.Size = new System.Drawing.Size(1506, 836);
            this.pnlPlaceHolder.TabIndex = 1;
            // 
            // UCCreationMission
            // 
            this.UCCreationMission.AutoScroll = true;
            this.UCCreationMission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UCCreationMission.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCCreationMission.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UCCreationMission.Location = new System.Drawing.Point(6, 0);
            this.UCCreationMission.Margin = new System.Windows.Forms.Padding(6);
            this.UCCreationMission.Name = "UCCreationMission";
            this.UCCreationMission.Size = new System.Drawing.Size(1489, 836);
            this.UCCreationMission.TabIndex = 2;
            this.UCCreationMission.Visible = false;
            // 
            // UCNavigationEngins
            // 
            this.UCNavigationEngins.BackColor = System.Drawing.Color.MidnightBlue;
            this.UCNavigationEngins.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCNavigationEngins.Location = new System.Drawing.Point(0, 0);
            this.UCNavigationEngins.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.UCNavigationEngins.Name = "UCNavigationEngins";
            this.UCNavigationEngins.Size = new System.Drawing.Size(1506, 836);
            this.UCNavigationEngins.TabIndex = 2;
            this.UCNavigationEngins.Visible = false;
            // 
            // lblChargement
            // 
            this.lblChargement.AutoSize = true;
            this.lblChargement.Location = new System.Drawing.Point(632, 414);
            this.lblChargement.Name = "lblChargement";
            this.lblChargement.Size = new System.Drawing.Size(185, 37);
            this.lblChargement.TabIndex = 0;
            this.lblChargement.Text = "Chargement...";
            // 
            // UCGestionPompier
            // 
            this.UCGestionPompier.BackColor = System.Drawing.Color.MidnightBlue;
            this.UCGestionPompier.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCGestionPompier.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UCGestionPompier.Location = new System.Drawing.Point(0, 0);
            this.UCGestionPompier.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.UCGestionPompier.Name = "UCGestionPompier";
            this.UCGestionPompier.Size = new System.Drawing.Size(1506, 836);
            this.UCGestionPompier.TabIndex = 2;
            this.UCGestionPompier.Visible = false;
            // 
            // UCTableauDeBord
            // 
            this.UCTableauDeBord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UCTableauDeBord.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCTableauDeBord.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UCTableauDeBord.Location = new System.Drawing.Point(0, 0);
            this.UCTableauDeBord.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.UCTableauDeBord.Name = "UCTableauDeBord";
            this.UCTableauDeBord.Size = new System.Drawing.Size(1506, 836);
            this.UCTableauDeBord.TabIndex = 2;
            this.UCTableauDeBord.Visible = false;
            // 
            // frmFireSpirit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1878, 861);
            this.Controls.Add(this.pnlPlaceHolder);
            this.Controls.Add(this.pnlNavigateur);
            this.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "frmFireSpirit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FireSpirit";
            this.Load += new System.EventHandler(this.frmFireSpirit_Load);
            this.pnlNavigateur.ResumeLayout(false);
            this.pnlNavigateur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.pnlPlaceHolder.ResumeLayout(false);
            this.pnlPlaceHolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavigateur;
        private System.Windows.Forms.Panel pnlPlaceHolder;
        private System.Windows.Forms.Label lblChargement;
        private UCBoutonNavigation.UCBoutonNavigation UCBtnNavEngin;
        private UCBoutonNavigation.UCBoutonNavigation UCBtnNavStat;
        private UCBoutonNavigation.UCBoutonNavigation UCBtnNavPompier;
        private UCBoutonNavigation.UCBoutonNavigation UCBtnNavMission;
        private UCBoutonNavigation.UCBoutonNavigation UCBtnNavTableau;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.Label lblLogo;
        private NavigationEngins.UCNavigationEngins UCNavigationEngins;
        private UCGestionPompier.UCGestionPompier UCGestionPompier;
        private UCCreationMission.UCCreationMission UCCreationMission;
        private UCtableauDeBord.UCtableauDeBord UCTableauDeBord;
    }
}

