namespace UCGestionPompier
{
    partial class UCGestionPompier
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboPompier = new System.Windows.Forms.ComboBox();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.btnCreation = new System.Windows.Forms.Button();
            this.lblPompier = new System.Windows.Forms.Label();
            this.lblCaserne = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UCCreationPompier = new UCCreationPompier.UCCreationPompier();
            this.pnlAuthentification = new System.Windows.Forms.Panel();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnValiderAuth = new System.Windows.Forms.Button();
            this.btnAnnulerAuth = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.chkEnConge = new System.Windows.Forms.CheckBox();
            this.lblModeActuel = new System.Windows.Forms.Label();
            this.btnHabAjouter = new System.Windows.Forms.Button();
            this.btnLectureEdition = new System.Windows.Forms.Button();
            this.lblMode = new System.Windows.Forms.Label();
            this.ltbAffectation = new System.Windows.Forms.ListBox();
            this.ltbHabilitationsDisponible = new System.Windows.Forms.ListBox();
            this.ltbHabilitationsActuel = new System.Windows.Forms.ListBox();
            this.cboCaserneRattachement = new System.Windows.Forms.ComboBox();
            this.pcbGrade = new System.Windows.Forms.PictureBox();
            this.lblCaserneRattachement = new System.Windows.Forms.Label();
            this.lblHabilitations = new System.Windows.Forms.Label();
            this.lblAffectationsPassee = new System.Windows.Forms.Label();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.lblTelData = new System.Windows.Forms.Label();
            this.lblBipData = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblBip = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblDateEmbaucheData = new System.Windows.Forms.Label();
            this.rdbProfessionnel = new System.Windows.Forms.RadioButton();
            this.rdbVolontaire = new System.Windows.Forms.RadioButton();
            this.lblDateNaissanceData = new System.Windows.Forms.Label();
            this.lblMatriculeData = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.lblSexeData = new System.Windows.Forms.Label();
            this.lblPrenomData = new System.Windows.Forms.Label();
            this.lblNomData = new System.Windows.Forms.Label();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblDateEmbauche = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlAuthentification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.cboPompier);
            this.panel1.Controls.Add(this.cboCaserne);
            this.panel1.Controls.Add(this.btnCreation);
            this.panel1.Controls.Add(this.lblPompier);
            this.panel1.Controls.Add(this.lblCaserne);
            this.panel1.Location = new System.Drawing.Point(15, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1475, 128);
            this.panel1.TabIndex = 0;
            // 
            // cboPompier
            // 
            this.cboPompier.FormattingEnabled = true;
            this.cboPompier.Location = new System.Drawing.Point(578, 51);
            this.cboPompier.Name = "cboPompier";
            this.cboPompier.Size = new System.Drawing.Size(447, 45);
            this.cboPompier.TabIndex = 4;
            this.cboPompier.SelectedIndexChanged += new System.EventHandler(this.cboPompier_SelectedIndexChanged);
            // 
            // cboCaserne
            // 
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(54, 51);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(447, 45);
            this.cboCaserne.TabIndex = 3;
            this.cboCaserne.SelectedIndexChanged += new System.EventHandler(this.cboCaserne_SelectedIndexChanged);
            // 
            // btnCreation
            // 
            this.btnCreation.BackColor = System.Drawing.Color.Yellow;
            this.btnCreation.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnCreation.FlatAppearance.BorderSize = 5;
            this.btnCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreation.Location = new System.Drawing.Point(1090, 11);
            this.btnCreation.Name = "btnCreation";
            this.btnCreation.Size = new System.Drawing.Size(358, 101);
            this.btnCreation.TabIndex = 2;
            this.btnCreation.Text = "Créer Nouveau Pompier";
            this.btnCreation.UseVisualStyleBackColor = false;
            this.btnCreation.Click += new System.EventHandler(this.btnCreation_Click);
            // 
            // lblPompier
            // 
            this.lblPompier.AutoSize = true;
            this.lblPompier.Location = new System.Drawing.Point(571, 11);
            this.lblPompier.Name = "lblPompier";
            this.lblPompier.Size = new System.Drawing.Size(131, 37);
            this.lblPompier.TabIndex = 1;
            this.lblPompier.Text = "Pompier :";
            // 
            // lblCaserne
            // 
            this.lblCaserne.AutoSize = true;
            this.lblCaserne.Location = new System.Drawing.Point(47, 11);
            this.lblCaserne.Name = "lblCaserne";
            this.lblCaserne.Size = new System.Drawing.Size(132, 37);
            this.lblCaserne.TabIndex = 0;
            this.lblCaserne.Text = "Caserne :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.UCCreationPompier);
            this.panel2.Controls.Add(this.pnlAuthentification);
            this.panel2.Controls.Add(this.chkEnConge);
            this.panel2.Controls.Add(this.lblModeActuel);
            this.panel2.Controls.Add(this.btnHabAjouter);
            this.panel2.Controls.Add(this.btnLectureEdition);
            this.panel2.Controls.Add(this.lblMode);
            this.panel2.Controls.Add(this.ltbAffectation);
            this.panel2.Controls.Add(this.ltbHabilitationsDisponible);
            this.panel2.Controls.Add(this.ltbHabilitationsActuel);
            this.panel2.Controls.Add(this.cboCaserneRattachement);
            this.panel2.Controls.Add(this.pcbGrade);
            this.panel2.Controls.Add(this.lblCaserneRattachement);
            this.panel2.Controls.Add(this.lblHabilitations);
            this.panel2.Controls.Add(this.lblAffectationsPassee);
            this.panel2.Controls.Add(this.cboGrade);
            this.panel2.Controls.Add(this.lblTelData);
            this.panel2.Controls.Add(this.lblBipData);
            this.panel2.Controls.Add(this.lblTel);
            this.panel2.Controls.Add(this.lblBip);
            this.panel2.Controls.Add(this.lblGrade);
            this.panel2.Controls.Add(this.lblDateEmbaucheData);
            this.panel2.Controls.Add(this.rdbProfessionnel);
            this.panel2.Controls.Add(this.rdbVolontaire);
            this.panel2.Controls.Add(this.lblDateNaissanceData);
            this.panel2.Controls.Add(this.lblMatriculeData);
            this.panel2.Controls.Add(this.lblMatricule);
            this.panel2.Controls.Add(this.lblSexeData);
            this.panel2.Controls.Add(this.lblPrenomData);
            this.panel2.Controls.Add(this.lblNomData);
            this.panel2.Controls.Add(this.lblDateNaissance);
            this.panel2.Controls.Add(this.lblSexe);
            this.panel2.Controls.Add(this.lblPrenom);
            this.panel2.Controls.Add(this.lblNom);
            this.panel2.Controls.Add(this.btnModifier);
            this.panel2.Controls.Add(this.lblDateEmbauche);
            this.panel2.Location = new System.Drawing.Point(15, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1475, 657);
            this.panel2.TabIndex = 5;
            // 
            // UCCreationPompier
            // 
            this.UCCreationPompier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UCCreationPompier.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCCreationPompier.ForeColor = System.Drawing.Color.MidnightBlue;
            this.UCCreationPompier.Location = new System.Drawing.Point(0, 0);
            this.UCCreationPompier.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.UCCreationPompier.Name = "UCCreationPompier";
            this.UCCreationPompier.Size = new System.Drawing.Size(1475, 657);
            this.UCCreationPompier.TabIndex = 6;
            this.UCCreationPompier.Visible = false;
            // 
            // pnlAuthentification
            // 
            this.pnlAuthentification.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlAuthentification.Controls.Add(this.txtMdp);
            this.pnlAuthentification.Controls.Add(this.txtLogin);
            this.pnlAuthentification.Controls.Add(this.btnValiderAuth);
            this.pnlAuthentification.Controls.Add(this.btnAnnulerAuth);
            this.pnlAuthentification.Controls.Add(this.label2);
            this.pnlAuthentification.Controls.Add(this.lblLogin);
            this.pnlAuthentification.Location = new System.Drawing.Point(470, 216);
            this.pnlAuthentification.Name = "pnlAuthentification";
            this.pnlAuthentification.Size = new System.Drawing.Size(390, 222);
            this.pnlAuthentification.TabIndex = 36;
            this.pnlAuthentification.Visible = false;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(159, 79);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '*';
            this.txtMdp.Size = new System.Drawing.Size(203, 44);
            this.txtMdp.TabIndex = 40;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(159, 24);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(203, 44);
            this.txtLogin.TabIndex = 39;
            // 
            // btnValiderAuth
            // 
            this.btnValiderAuth.BackColor = System.Drawing.Color.Yellow;
            this.btnValiderAuth.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnValiderAuth.FlatAppearance.BorderSize = 5;
            this.btnValiderAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValiderAuth.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValiderAuth.Location = new System.Drawing.Point(169, 143);
            this.btnValiderAuth.Name = "btnValiderAuth";
            this.btnValiderAuth.Size = new System.Drawing.Size(193, 60);
            this.btnValiderAuth.TabIndex = 38;
            this.btnValiderAuth.Text = "Valider";
            this.btnValiderAuth.UseVisualStyleBackColor = false;
            this.btnValiderAuth.Click += new System.EventHandler(this.btnValiderAuth_Click);
            // 
            // btnAnnulerAuth
            // 
            this.btnAnnulerAuth.BackColor = System.Drawing.Color.Yellow;
            this.btnAnnulerAuth.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAnnulerAuth.FlatAppearance.BorderSize = 5;
            this.btnAnnulerAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnulerAuth.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerAuth.Location = new System.Drawing.Point(28, 143);
            this.btnAnnulerAuth.Name = "btnAnnulerAuth";
            this.btnAnnulerAuth.Size = new System.Drawing.Size(99, 60);
            this.btnAnnulerAuth.TabIndex = 37;
            this.btnAnnulerAuth.Text = "Annuler";
            this.btnAnnulerAuth.UseVisualStyleBackColor = false;
            this.btnAnnulerAuth.Click += new System.EventHandler(this.btnAnnulerAuth_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mot de passe :";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Yellow;
            this.lblLogin.Location = new System.Drawing.Point(17, 33);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(71, 29);
            this.lblLogin.TabIndex = 11;
            this.lblLogin.Text = "Login :";
            // 
            // chkEnConge
            // 
            this.chkEnConge.AutoSize = true;
            this.chkEnConge.Enabled = false;
            this.chkEnConge.Location = new System.Drawing.Point(1101, 125);
            this.chkEnConge.Name = "chkEnConge";
            this.chkEnConge.Size = new System.Drawing.Size(170, 41);
            this.chkEnConge.TabIndex = 35;
            this.chkEnConge.Text = "En Congée";
            this.chkEnConge.UseVisualStyleBackColor = true;
            // 
            // lblModeActuel
            // 
            this.lblModeActuel.AutoSize = true;
            this.lblModeActuel.BackColor = System.Drawing.Color.Yellow;
            this.lblModeActuel.Location = new System.Drawing.Point(901, 19);
            this.lblModeActuel.Name = "lblModeActuel";
            this.lblModeActuel.Size = new System.Drawing.Size(106, 37);
            this.lblModeActuel.TabIndex = 34;
            this.lblModeActuel.Text = "Lecture";
            // 
            // btnHabAjouter
            // 
            this.btnHabAjouter.BackColor = System.Drawing.Color.Yellow;
            this.btnHabAjouter.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnHabAjouter.FlatAppearance.BorderSize = 5;
            this.btnHabAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabAjouter.Location = new System.Drawing.Point(1017, 295);
            this.btnHabAjouter.Name = "btnHabAjouter";
            this.btnHabAjouter.Size = new System.Drawing.Size(60, 60);
            this.btnHabAjouter.TabIndex = 33;
            this.btnHabAjouter.Text = "<";
            this.btnHabAjouter.UseVisualStyleBackColor = false;
            this.btnHabAjouter.Click += new System.EventHandler(this.btnHabAjouter_Click);
            // 
            // btnLectureEdition
            // 
            this.btnLectureEdition.BackColor = System.Drawing.Color.Yellow;
            this.btnLectureEdition.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnLectureEdition.FlatAppearance.BorderSize = 5;
            this.btnLectureEdition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLectureEdition.Location = new System.Drawing.Point(1101, 425);
            this.btnLectureEdition.Name = "btnLectureEdition";
            this.btnLectureEdition.Size = new System.Drawing.Size(358, 101);
            this.btnLectureEdition.TabIndex = 31;
            this.btnLectureEdition.Text = "Passer en édition";
            this.btnLectureEdition.UseVisualStyleBackColor = false;
            this.btnLectureEdition.Click += new System.EventHandler(this.btnLectureEdition_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(809, 19);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(98, 37);
            this.lblMode.TabIndex = 30;
            this.lblMode.Text = "Mode :";
            // 
            // ltbAffectation
            // 
            this.ltbAffectation.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbAffectation.FormattingEnabled = true;
            this.ltbAffectation.HorizontalScrollbar = true;
            this.ltbAffectation.ItemHeight = 29;
            this.ltbAffectation.Location = new System.Drawing.Point(629, 444);
            this.ltbAffectation.Name = "ltbAffectation";
            this.ltbAffectation.Size = new System.Drawing.Size(434, 178);
            this.ltbAffectation.TabIndex = 29;
            // 
            // ltbHabilitationsDisponible
            // 
            this.ltbHabilitationsDisponible.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbHabilitationsDisponible.FormattingEnabled = true;
            this.ltbHabilitationsDisponible.HorizontalScrollbar = true;
            this.ltbHabilitationsDisponible.ItemHeight = 29;
            this.ltbHabilitationsDisponible.Location = new System.Drawing.Point(1090, 249);
            this.ltbHabilitationsDisponible.Name = "ltbHabilitationsDisponible";
            this.ltbHabilitationsDisponible.Size = new System.Drawing.Size(378, 149);
            this.ltbHabilitationsDisponible.TabIndex = 28;
            // 
            // ltbHabilitationsActuel
            // 
            this.ltbHabilitationsActuel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbHabilitationsActuel.FormattingEnabled = true;
            this.ltbHabilitationsActuel.HorizontalScrollbar = true;
            this.ltbHabilitationsActuel.ItemHeight = 29;
            this.ltbHabilitationsActuel.Location = new System.Drawing.Point(629, 249);
            this.ltbHabilitationsActuel.Name = "ltbHabilitationsActuel";
            this.ltbHabilitationsActuel.Size = new System.Drawing.Size(378, 149);
            this.ltbHabilitationsActuel.TabIndex = 27;
            // 
            // cboCaserneRattachement
            // 
            this.cboCaserneRattachement.Enabled = false;
            this.cboCaserneRattachement.FormattingEnabled = true;
            this.cboCaserneRattachement.Location = new System.Drawing.Point(629, 125);
            this.cboCaserneRattachement.Name = "cboCaserneRattachement";
            this.cboCaserneRattachement.Size = new System.Drawing.Size(427, 45);
            this.cboCaserneRattachement.TabIndex = 26;
            // 
            // pcbGrade
            // 
            this.pcbGrade.Location = new System.Drawing.Point(1298, 31);
            this.pcbGrade.Name = "pcbGrade";
            this.pcbGrade.Size = new System.Drawing.Size(150, 150);
            this.pcbGrade.TabIndex = 25;
            this.pcbGrade.TabStop = false;
            // 
            // lblCaserneRattachement
            // 
            this.lblCaserneRattachement.AutoSize = true;
            this.lblCaserneRattachement.Location = new System.Drawing.Point(632, 68);
            this.lblCaserneRattachement.Name = "lblCaserneRattachement";
            this.lblCaserneRattachement.Size = new System.Drawing.Size(331, 37);
            this.lblCaserneRattachement.TabIndex = 24;
            this.lblCaserneRattachement.Text = "Caserne de rattachement :";
            // 
            // lblHabilitations
            // 
            this.lblHabilitations.AutoSize = true;
            this.lblHabilitations.Location = new System.Drawing.Point(632, 200);
            this.lblHabilitations.Name = "lblHabilitations";
            this.lblHabilitations.Size = new System.Drawing.Size(176, 37);
            this.lblHabilitations.TabIndex = 23;
            this.lblHabilitations.Text = "Habilitations :";
            // 
            // lblAffectationsPassee
            // 
            this.lblAffectationsPassee.AutoSize = true;
            this.lblAffectationsPassee.Location = new System.Drawing.Point(632, 404);
            this.lblAffectationsPassee.Name = "lblAffectationsPassee";
            this.lblAffectationsPassee.Size = new System.Drawing.Size(275, 37);
            this.lblAffectationsPassee.TabIndex = 22;
            this.lblAffectationsPassee.Text = "Afféctations passées :";
            // 
            // cboGrade
            // 
            this.cboGrade.Enabled = false;
            this.cboGrade.FormattingEnabled = true;
            this.cboGrade.Location = new System.Drawing.Point(312, 465);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(285, 45);
            this.cboGrade.TabIndex = 21;
            // 
            // lblTelData
            // 
            this.lblTelData.AutoSize = true;
            this.lblTelData.Location = new System.Drawing.Point(305, 525);
            this.lblTelData.Name = "lblTelData";
            this.lblTelData.Size = new System.Drawing.Size(159, 37);
            this.lblTelData.TabIndex = 20;
            this.lblTelData.Text = "Placeholder";
            // 
            // lblBipData
            // 
            this.lblBipData.AutoSize = true;
            this.lblBipData.Location = new System.Drawing.Point(305, 593);
            this.lblBipData.Name = "lblBipData";
            this.lblBipData.Size = new System.Drawing.Size(159, 37);
            this.lblBipData.TabIndex = 19;
            this.lblBipData.Text = "Placeholder";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(47, 525);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(158, 37);
            this.lblTel.TabIndex = 18;
            this.lblTel.Text = "Téléphone :";
            // 
            // lblBip
            // 
            this.lblBip.AutoSize = true;
            this.lblBip.Location = new System.Drawing.Point(47, 593);
            this.lblBip.Name = "lblBip";
            this.lblBip.Size = new System.Drawing.Size(74, 37);
            this.lblBip.TabIndex = 17;
            this.lblBip.Text = "BIP :";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(48, 468);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(105, 37);
            this.lblGrade.TabIndex = 16;
            this.lblGrade.Text = "Grade :";
            // 
            // lblDateEmbaucheData
            // 
            this.lblDateEmbaucheData.AutoSize = true;
            this.lblDateEmbaucheData.Location = new System.Drawing.Point(305, 404);
            this.lblDateEmbaucheData.Name = "lblDateEmbaucheData";
            this.lblDateEmbaucheData.Size = new System.Drawing.Size(159, 37);
            this.lblDateEmbaucheData.TabIndex = 15;
            this.lblDateEmbaucheData.Text = "Placeholder";
            // 
            // rdbProfessionnel
            // 
            this.rdbProfessionnel.AutoSize = true;
            this.rdbProfessionnel.Enabled = false;
            this.rdbProfessionnel.Location = new System.Drawing.Point(79, 333);
            this.rdbProfessionnel.Name = "rdbProfessionnel";
            this.rdbProfessionnel.Size = new System.Drawing.Size(197, 41);
            this.rdbProfessionnel.TabIndex = 14;
            this.rdbProfessionnel.TabStop = true;
            this.rdbProfessionnel.Text = "Professionnel";
            this.rdbProfessionnel.UseVisualStyleBackColor = true;
            // 
            // rdbVolontaire
            // 
            this.rdbVolontaire.AutoSize = true;
            this.rdbVolontaire.Enabled = false;
            this.rdbVolontaire.Location = new System.Drawing.Point(292, 333);
            this.rdbVolontaire.Name = "rdbVolontaire";
            this.rdbVolontaire.Size = new System.Drawing.Size(156, 41);
            this.rdbVolontaire.TabIndex = 13;
            this.rdbVolontaire.TabStop = true;
            this.rdbVolontaire.Text = "Volontaire";
            this.rdbVolontaire.UseVisualStyleBackColor = true;
            // 
            // lblDateNaissanceData
            // 
            this.lblDateNaissanceData.AutoSize = true;
            this.lblDateNaissanceData.Location = new System.Drawing.Point(305, 269);
            this.lblDateNaissanceData.Name = "lblDateNaissanceData";
            this.lblDateNaissanceData.Size = new System.Drawing.Size(159, 37);
            this.lblDateNaissanceData.TabIndex = 12;
            this.lblDateNaissanceData.Text = "Placeholder";
            // 
            // lblMatriculeData
            // 
            this.lblMatriculeData.AutoSize = true;
            this.lblMatriculeData.Location = new System.Drawing.Point(255, 19);
            this.lblMatriculeData.Name = "lblMatriculeData";
            this.lblMatriculeData.Size = new System.Drawing.Size(159, 37);
            this.lblMatriculeData.TabIndex = 11;
            this.lblMatriculeData.Text = "Placeholder";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(110, 19);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(139, 37);
            this.lblMatricule.TabIndex = 10;
            this.lblMatricule.Text = "Matricule :";
            // 
            // lblSexeData
            // 
            this.lblSexeData.AutoSize = true;
            this.lblSexeData.Location = new System.Drawing.Point(305, 200);
            this.lblSexeData.Name = "lblSexeData";
            this.lblSexeData.Size = new System.Drawing.Size(159, 37);
            this.lblSexeData.TabIndex = 9;
            this.lblSexeData.Text = "Placeholder";
            // 
            // lblPrenomData
            // 
            this.lblPrenomData.AutoSize = true;
            this.lblPrenomData.Location = new System.Drawing.Point(305, 133);
            this.lblPrenomData.Name = "lblPrenomData";
            this.lblPrenomData.Size = new System.Drawing.Size(159, 37);
            this.lblPrenomData.TabIndex = 8;
            this.lblPrenomData.Text = "Placeholder";
            // 
            // lblNomData
            // 
            this.lblNomData.AutoSize = true;
            this.lblNomData.Location = new System.Drawing.Point(305, 68);
            this.lblNomData.Name = "lblNomData";
            this.lblNomData.Size = new System.Drawing.Size(159, 37);
            this.lblNomData.TabIndex = 7;
            this.lblNomData.Text = "Placeholder";
            // 
            // lblDateNaissance
            // 
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Location = new System.Drawing.Point(48, 269);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(251, 37);
            this.lblDateNaissance.TabIndex = 6;
            this.lblDateNaissance.Text = "Date de naissance :";
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(48, 200);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(92, 37);
            this.lblSexe.TabIndex = 5;
            this.lblSexe.Text = "Sexe :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(47, 133);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(125, 37);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(47, 68);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(87, 37);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Nom :";
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.Yellow;
            this.btnModifier.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnModifier.FlatAppearance.BorderSize = 5;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Location = new System.Drawing.Point(1101, 532);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(358, 101);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lblDateEmbauche
            // 
            this.lblDateEmbauche.AutoSize = true;
            this.lblDateEmbauche.Location = new System.Drawing.Point(47, 404);
            this.lblDateEmbauche.Name = "lblDateEmbauche";
            this.lblDateEmbauche.Size = new System.Drawing.Size(239, 37);
            this.lblDateEmbauche.TabIndex = 1;
            this.lblDateEmbauche.Text = "Date d\'embauche :";
            // 
            // UCGestionPompier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.Name = "UCGestionPompier";
            this.Size = new System.Drawing.Size(1506, 836);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlAuthentification.ResumeLayout(false);
            this.pnlAuthentification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGrade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboPompier;
        private System.Windows.Forms.ComboBox cboCaserne;
        private System.Windows.Forms.Button btnCreation;
        private System.Windows.Forms.Label lblPompier;
        private System.Windows.Forms.Label lblCaserne;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblDateEmbauche;
        private System.Windows.Forms.Label lblNomData;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblSexeData;
        private System.Windows.Forms.Label lblPrenomData;
        private System.Windows.Forms.Label lblMatriculeData;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Label lblDateNaissanceData;
        private System.Windows.Forms.RadioButton rdbProfessionnel;
        private System.Windows.Forms.RadioButton rdbVolontaire;
        private System.Windows.Forms.Label lblDateEmbaucheData;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.Label lblTelData;
        private System.Windows.Forms.Label lblBipData;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblBip;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblCaserneRattachement;
        private System.Windows.Forms.Label lblHabilitations;
        private System.Windows.Forms.Label lblAffectationsPassee;
        private System.Windows.Forms.PictureBox pcbGrade;
        private System.Windows.Forms.ListBox ltbHabilitationsDisponible;
        private System.Windows.Forms.ListBox ltbHabilitationsActuel;
        private System.Windows.Forms.ComboBox cboCaserneRattachement;
        private System.Windows.Forms.ListBox ltbAffectation;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Button btnLectureEdition;
        private System.Windows.Forms.Button btnHabAjouter;
        private System.Windows.Forms.Label lblModeActuel;
        private System.Windows.Forms.CheckBox chkEnConge;
        private System.Windows.Forms.Panel pnlAuthentification;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnValiderAuth;
        private System.Windows.Forms.Button btnAnnulerAuth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLogin;
        private UCCreationPompier.UCCreationPompier UCCreationPompier;
    }
}
