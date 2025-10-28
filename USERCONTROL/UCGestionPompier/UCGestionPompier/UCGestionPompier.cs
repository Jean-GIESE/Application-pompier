using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace UCGestionPompier
{
    public partial class UCGestionPompier: UserControl
    {
        private SQLiteConnection _connexion;
        private bool estModeLecture = true;
        private bool creation = false;
        public UCGestionPompier()
        {
            InitializeComponent();
        }
        public void InitialiserConnexion(SQLiteConnection connexion)
        {
            _connexion = connexion;

            if (_connexion == null || _connexion.State != ConnectionState.Open)
            {
                MessageBox.Show("Connexion invalide ou fermée.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RemplirComboCaserne();

            if (cboCaserne.Items.Count > 0)
            {
                cboCaserne.SelectedIndex = 0;
            }
            UCCreationPompier.InitialiserConnexion(_connexion);
        }
        public void ChargerDonnees(SQLiteConnection con, int matriculePompier)
        {
            // Charger les listes des grades et casernes en premier
            cboGrade.Items.Clear();
            using (var cmd = new SQLiteCommand("SELECT libelle FROM Grade ORDER BY rang", con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cboGrade.Items.Add(reader["libelle"].ToString());
                    }
                }
            }

            cboCaserneRattachement.Items.Clear();
            using (var cmd = new SQLiteCommand("SELECT nom FROM Caserne ORDER BY nom", con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cboCaserneRattachement.Items.Add(reader["nom"].ToString());
                    }
                }
            }

            // Charger les infos du pompier sélectionné
            string gradeLibelle = null;
            string caserneRattachement = null;

            using (var cmd = new SQLiteCommand(@"
        SELECT p.nom, p.prenom, p.sexe, p.dateNaissance, p.type, p.portable, p.bip, p.enMission, p.enConge, p.codeGrade, p.dateEmbauche, g.libelle AS gradeLibelle
        FROM Pompier p 
        JOIN Grade g ON p.codeGrade = g.code
        WHERE p.matricule = @matricule", con))
            {
                cmd.Parameters.AddWithValue("@matricule", matriculePompier);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblMatriculeData.Text = matriculePompier.ToString();
                        lblNomData.Text = reader["nom"].ToString();
                        lblPrenomData.Text = reader["prenom"].ToString();
                        string sexe = reader["sexe"].ToString();
                        lblSexeData.Text = sexe == "m" ? "Masculin" : sexe == "f" ? "Féminin" : "Inconnu";
                        lblDateNaissanceData.Text = reader["dateNaissance"].ToString();
                        lblDateEmbaucheData.Text = reader["dateEmbauche"].ToString();

                        string type = reader["type"].ToString();
                        rdbProfessionnel.Checked = (type == "p");
                        rdbVolontaire.Checked = (type == "v");

                        lblTelData.Text = reader["portable"]?.ToString() ?? "";
                        lblBipData.Text = reader["bip"]?.ToString() ?? "";

                        chkEnConge.Checked = Convert.ToInt32(reader["enConge"]) == 1;

                        gradeLibelle = reader["gradeLibelle"].ToString();
                    }
                }
            }

            // Sélectionner l'item correspondant dans cboGrade
            cboGrade.SelectedItem = null;
            foreach (var item in cboGrade.Items)
            {
                if (item.ToString() == gradeLibelle)
                {
                    cboGrade.SelectedItem = item;
                    break;
                }
            }

            // Charger l'affectation actuelle
            // Puis sélectionner la caserne de rattachement dans cboCaserneRattachement
            using (var cmd = new SQLiteCommand(@"
        SELECT c.nom 
        FROM Affectation a
        JOIN Caserne c ON a.idCaserne = c.id
        WHERE a.matriculePompier = @matricule AND a.dateFin IS NULL", con))
            {
                cmd.Parameters.AddWithValue("@matricule", matriculePompier);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        caserneRattachement = reader["nom"].ToString();
                    }
                }
            }

            cboCaserneRattachement.SelectedItem = null;
            foreach (var item in cboCaserneRattachement.Items)
            {
                if (item.ToString() == caserneRattachement)
                {
                    cboCaserneRattachement.SelectedItem = item;
                    break;
                }
            }

            // Charger habilitations actuelles (passées par le pompier)
            ltbHabilitationsActuel.Items.Clear();
            using (var cmd = new SQLiteCommand(
                @"SELECT h.libelle 
          FROM Habilitation h 
          JOIN Passer p ON h.id = p.idHabilitation 
          WHERE p.matriculePompier = @matricule", con))
            {
                cmd.Parameters.AddWithValue("@matricule", matriculePompier);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ltbHabilitationsActuel.Items.Add(reader["libelle"].ToString());
                    }
                }
            }

            // Charger habilitations disponibles (non obtenues par le pompier)
            ltbHabilitationsDisponible.Items.Clear();
            using (var cmd = new SQLiteCommand(
                @"SELECT libelle FROM Habilitation WHERE id NOT IN (
            SELECT idHabilitation FROM Passer WHERE matriculePompier = @matricule
          )", con))
            {
                cmd.Parameters.AddWithValue("@matricule", matriculePompier);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ltbHabilitationsDisponible.Items.Add(reader["libelle"].ToString());
                    }
                }
            }

            // Charger les affectations passées (sans l'affectation actuelle, donc avec dateFin non nulle)
            ltbAffectation.Items.Clear();
            using (var cmd = new SQLiteCommand(
                @"SELECT a.dateA, a.dateFin, c.nom 
          FROM Affectation a 
          JOIN Caserne c ON a.idCaserne = c.id 
          WHERE a.matriculePompier = @matricule AND a.dateFin IS NOT NULL
          ORDER BY a.dateA DESC", con))
            {
                cmd.Parameters.AddWithValue("@matricule", matriculePompier);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string dateDebut = reader["dateA"].ToString();
                        string dateFin = reader["dateFin"]?.ToString();
                        string nomCaserne = reader["nom"].ToString();

                        string affectation = $"{nomCaserne} : {dateDebut} - {dateFin}";
                        ltbAffectation.Items.Add(affectation);
                    }
                }
            }
        }
        private void ChangerModeLectureEdition()
        {
            estModeLecture = !estModeLecture;

            cboGrade.Enabled = !estModeLecture;
            cboCaserneRattachement.Enabled = !estModeLecture;

            rdbProfessionnel.Enabled = !estModeLecture;
            rdbVolontaire.Enabled = !estModeLecture;

            chkEnConge.Enabled = !estModeLecture;

            btnLectureEdition.Text = estModeLecture ? "Passer en édition" : "Passer en lecture";
            lblModeActuel.Text = estModeLecture ? "Lecture" : "Edition";

        }

        private void btnLectureEdition_Click(object sender, EventArgs e)
        {
            ChangerModeLectureEdition();
        }

        private void btnHabAjouter_Click(object sender, EventArgs e)
        {
            if (estModeLecture)
            {
                MessageBox.Show("Vous devez être en mode édition pour ajouter une habilitation.", "Action non autorisée", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ltbHabilitationsDisponible.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner une habilitation disponible à ajouter.", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string habilitation = ltbHabilitationsDisponible.SelectedItem.ToString();

            if (!ltbHabilitationsActuel.Items.Contains(habilitation))
            {
                ltbHabilitationsActuel.Items.Add(habilitation);
                ltbHabilitationsDisponible.Items.Remove(habilitation);
            }
        }
        private void RemplirComboCaserne()
        {
            cboCaserne.Items.Clear();
            using (var cmd = new SQLiteCommand("SELECT nom FROM Caserne ORDER BY nom", _connexion))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cboCaserne.Items.Add(reader["nom"].ToString());
                    }
                }
            }
        }
        private void RemplirComboPompier()
        {
            cboPompier.Items.Clear();

            if (cboCaserne.SelectedItem == null)
                return;

            string caserne = cboCaserne.SelectedItem.ToString();

            string query = @"
        SELECT p.matricule, p.nom, p.prenom
        FROM Pompier p
        JOIN Affectation a ON p.matricule = a.matriculePompier
        JOIN Caserne c ON a.idCaserne = c.id
        WHERE c.nom = @caserne
        AND (a.dateFin IS NULL OR a.dateFin = '')";

            using (var cmd = new SQLiteCommand(query, _connexion))
            {
                cmd.Parameters.AddWithValue("@caserne", caserne);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int matricule = Convert.ToInt32(reader["matricule"]);
                        string nomComplet = $"{reader["nom"]} {reader["prenom"]}";
                        cboPompier.Items.Add(new ComboboxItem { Text = nomComplet, Value = matricule });
                    }
                }
            }
        }
        private int GetMatriculePompierSelectionne()
        {
            if (cboPompier.SelectedItem is ComboboxItem item)
            {
                return (int)item.Value;
            }
            return -1;
        }
        private class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }
            public override string ToString() => Text;
        }

        private void cboCaserne_SelectedIndexChanged(object sender, EventArgs e)
        {
            RemplirComboPompier();

            // Charger les données du premier pompier si la liste n'est pas vide
            if (cboPompier.Items.Count > 0)
            {
                cboPompier.SelectedIndex = 0;
                int matricule = GetMatriculePompierSelectionne();
                if (matricule != -1)
                {
                    ChargerDonnees(_connexion, matricule);
                }
            }
        }

        private void cboPompier_SelectedIndexChanged(object sender, EventArgs e)
        {
            int matricule = GetMatriculePompierSelectionne();
            if (matricule != -1)
            {
                ChargerDonnees(_connexion, matricule);
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            creation = false;
            pnlAuthentification.Visible = true;
        }

        private void btnAnnulerAuth_Click(object sender, EventArgs e)
        {
            pnlAuthentification.Visible = false;
            txtLogin.Text = "";
            txtMdp.Text = "";

        }

        private void btnValiderAuth_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string mdp = txtMdp.Text.Trim();

            if (EstAdministrateur(login, mdp))
            {
                pnlAuthentification.Visible = false;
                txtLogin.Text = "";
                txtMdp.Text = "";

                if (creation)
                {
                    UCCreationPompier.Visible = true;
                }
                else
                {
                    ModifierPompier();
                }
            }
            else
            {
                MessageBox.Show("Identifiants incorrects.");
            }
        }
        private bool EstAdministrateur(string login, string mdp)
        {
            string sql = "SELECT COUNT(*) FROM Admin WHERE login = @login AND mdp = @mdp";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _connexion))
            {
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@mdp", mdp); // Attention : mot de passe en clair !

                long count = (long)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        private void ModifierPompier()
        {
            int matricule = GetMatriculePompierSelectionne();
            if (matricule == -1)
            {
                MessageBox.Show("Aucun pompier sélectionné.");
                return;
            }

            string typeForm = rdbProfessionnel.Checked ? "p" : "v";
            bool enCongeForm = chkEnConge.Checked;
            string codeGradeForm = GetCodeGradeSelectionne();
            int idCaserneForm = GetIdCaserneSelectionnee();
            List<int> habilitationsForm = GetHabilitationsSelectionnees();
            string today = DateTime.Now.ToString("yyyy-MM-dd");

            using (SQLiteTransaction transaction = _connexion.BeginTransaction())
            {
                try
                {
                    // 1. Récupérer infos pompier actuelles
                    string selectPompierSql = "SELECT type, enConge, codeGrade FROM Pompier WHERE matricule = @matricule";
                    string typeActuel = null;
                    bool enCongeActuel = false;
                    string codeGradeActuel = null;

                    using (var cmd = new SQLiteCommand(selectPompierSql, _connexion, transaction))
                    {
                        cmd.Parameters.AddWithValue("@matricule", matricule);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                typeActuel = reader.GetString(0);
                                enCongeActuel = reader.GetInt32(1) == 1;
                                codeGradeActuel = reader.GetString(2);
                            }
                        }
                    }

                    // 2. Mettre à jour Pompier uniquement si info différente
                    if (typeForm != typeActuel || enCongeForm != enCongeActuel || codeGradeForm != codeGradeActuel)
                    {
                        string updatePompierSql = @"
                    UPDATE Pompier
                    SET type = @type,
                        enConge = @enConge,
                        codeGrade = @codeGrade
                    WHERE matricule = @matricule";

                        using (var cmd = new SQLiteCommand(updatePompierSql, _connexion, transaction))
                        {
                            cmd.Parameters.AddWithValue("@type", typeForm);
                            cmd.Parameters.AddWithValue("@enConge", enCongeForm ? 1 : 0);
                            cmd.Parameters.AddWithValue("@codeGrade", codeGradeForm);
                            cmd.Parameters.AddWithValue("@matricule", matricule);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // 3. Récupérer affectation actuelle (dateFin IS NULL)
                    string selectAffectSql = @"
                SELECT idCaserne FROM Affectation 
                WHERE matriculePompier = @matricule AND dateFin IS NULL";

                    int? idCaserneActuel = null;
                    using (var cmd = new SQLiteCommand(selectAffectSql, _connexion, transaction))
                    {
                        cmd.Parameters.AddWithValue("@matricule", matricule);
                        var result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                            idCaserneActuel = id;
                    }

                    // 4. Si caserne différente, clôturer ancienne affectation et en créer une nouvelle
                    if (!idCaserneActuel.HasValue || idCaserneActuel.Value != idCaserneForm)
                    {
                        // Clôturer l'ancienne affectation
                        string updateAffectationFin = @"
                    UPDATE Affectation
                    SET dateFin = @today
                    WHERE matriculePompier = @matricule AND dateFin IS NULL";

                        using (var cmd = new SQLiteCommand(updateAffectationFin, _connexion, transaction))
                        {
                            cmd.Parameters.AddWithValue("@today", today);
                            cmd.Parameters.AddWithValue("@matricule", matricule);
                            cmd.ExecuteNonQuery();
                        }

                        // Ajouter nouvelle affectation
                        string insertNewAffectation = @"
                    INSERT INTO Affectation (matriculePompier, dateA, dateFin, idCaserne)
                    VALUES (@matricule, @today, NULL, @idCaserne)";

                        using (var cmd = new SQLiteCommand(insertNewAffectation, _connexion, transaction))
                        {
                            cmd.Parameters.AddWithValue("@matricule", matricule);
                            cmd.Parameters.AddWithValue("@today", today);
                            cmd.Parameters.AddWithValue("@idCaserne", idCaserneForm);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // 5. Récupérer habilitations actuelles
                    List<int> habilitationsActuelles = new List<int>();
                    string selectHabilitationsSql = "SELECT idHabilitation FROM Passer WHERE matriculePompier = @matricule";

                    using (var cmd = new SQLiteCommand(selectHabilitationsSql, _connexion, transaction))
                    {
                        cmd.Parameters.AddWithValue("@matricule", matricule);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                habilitationsActuelles.Add(reader.GetInt32(0));
                            }
                        }
                    }

                    // 6. Comparer listes habilitations (simple méthode)
                    bool habilitationsDifferent = !habilitationsForm.OrderBy(x => x).SequenceEqual(habilitationsActuelles.OrderBy(x => x));

                    if (habilitationsDifferent)
                    {
                        // Supprimer anciennes habilitations
                        string deleteHabilitationsSql = "DELETE FROM Passer WHERE matriculePompier = @matricule";
                        using (var cmd = new SQLiteCommand(deleteHabilitationsSql, _connexion, transaction))
                        {
                            cmd.Parameters.AddWithValue("@matricule", matricule);
                            cmd.ExecuteNonQuery();
                        }

                        // Ajouter nouvelles habilitations
                        string insertPasserSql = "INSERT INTO Passer (matriculePompier, idHabilitation, dateObtention) VALUES (@matricule, @idHab, @today)";
                        foreach (int idHab in habilitationsForm)
                        {
                            using (var cmd = new SQLiteCommand(insertPasserSql, _connexion, transaction))
                            {
                                cmd.Parameters.AddWithValue("@matricule", matricule);
                                cmd.Parameters.AddWithValue("@idHab", idHab);
                                cmd.Parameters.AddWithValue("@today", today);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Le pompier a été modifié avec succès.");
                    ChargerDonnees(_connexion, matricule);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Erreur lors de la modification : " + ex.Message);
                }
            }
        }

        private string GetCodeGradeSelectionne()
        {
            if (cboGrade.SelectedItem == null)
                return null;

            string libelle = cboGrade.SelectedItem.ToString();

            string code = null;
            string sql = "SELECT code FROM Grade WHERE libelle = @libelle";

            using (var cmd = new SQLiteCommand(sql, _connexion))
            {
                cmd.Parameters.AddWithValue("@libelle", libelle);
                object result = cmd.ExecuteScalar();
                if (result != null)
                    code = result.ToString();
            }
            return code;
        }
        private int GetIdCaserneSelectionnee()
        {
            if (cboCaserneRattachement.SelectedItem == null)
                return -1;

            string nom = cboCaserneRattachement.SelectedItem.ToString();

            int id = -1;
            string sql = "SELECT id FROM Caserne WHERE nom = @nom";

            using (var cmd = new SQLiteCommand(sql, _connexion))
            {
                cmd.Parameters.AddWithValue("@nom", nom);
                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int parsedId))
                    id = parsedId;
            }
            return id;
        }
        private List<int> GetHabilitationsSelectionnees()
        {
            List<int> ids = new List<int>();

            foreach (var item in ltbHabilitationsActuel.Items)
            {
                string libelle = item.ToString();

                string sql = "SELECT id FROM Habilitation WHERE libelle = @libelle";
                using (var cmd = new SQLiteCommand(sql, _connexion))
                {
                    cmd.Parameters.AddWithValue("@libelle", libelle);
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int id))
                    {
                        ids.Add(id);
                    }
                }
            }

            return ids;
        }

        private void btnCreation_Click(object sender, EventArgs e)
        {
            creation =true;
            pnlAuthentification.Visible = true;
            UCCreationPompier.MettreAJourMatriculeSelonCaserne();
        }
    }
}
