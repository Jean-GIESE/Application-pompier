using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCMission
{
    public delegate void infosMissions(object sender, EventArgs eventArgs);
    public partial class UCMission: UserControl
    {
        public UCMission()
        {
            InitializeComponent();
        }

        public infosMissions infosM;

        public UCMission(string id, string dateHeureDepart, string motifAppel, string ville, string nature, string caserne, string image)
        {
            InitializeComponent();

            this.lblId.Text = "Id: " + id;
            this.lblDateHeureDepart.Text = "Date Départ: " + dateHeureDepart;
            this.lblMotifAppel.Text = "Motif d'appel: " + motifAppel;
            this.lblVille.Text = "Ville: " + ville;
            this.lblNature.Text = "Nature: " + nature;
            this.lblCaserne.Text = "Caserne: " + caserne;

            if (image != string.Empty)
            {
                pctImage.Image = Image.FromFile(image);
                pctImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        [Description("L'id de la mission")]
        public string idMission
        {
            get
            {
                return this.lblId.Text.Substring(4);
            }
            set
            {
                
            }
        }

        private void btnMission_Click(object sender, EventArgs e)
        {
            if (this.infosM != null)
            {
                this.infosM(sender, e);
            }
        }
    }
}
