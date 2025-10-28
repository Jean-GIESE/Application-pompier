using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace UCBoutonNavigation
{
    public partial class UCBoutonNavigation : UserControl
    {
        public UCBoutonNavigation()
        {
            InitializeComponent();
            RendreClicGlobal(this);
        }

        [Description("Définit le texte affiché sur le label")]
        public string Texte
        {
            get => this.lblVollet.Text;
            set => this.lblVollet.Text = value;
        }

        [Description("Définit l'image affichée dans la PictureBox")]
        public Image NomImage
        {
            get => this.pctLogo.Image;
            set => this.pctLogo.Image = value;
        }

        /// <summary>
        /// Attache MouseUp à tous les contrôles pour relayer l'événement Click.
        /// </summary>
        private void RendreClicGlobal(Control ctrl)
        {
            ctrl.MouseUp += RelayerClick;
            foreach (Control enfant in ctrl.Controls)
            {
                RendreClicGlobal(enfant);
            }
        }

        /// <summary>
        /// Déclenche le Click du UserControl peu importe où on clique.
        /// </summary>
        private void RelayerClick(object sender, MouseEventArgs e)
        {
            this.OnClick(EventArgs.Empty);
        }
    }
}
