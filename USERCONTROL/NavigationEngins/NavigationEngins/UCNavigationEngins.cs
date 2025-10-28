using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavigationEngins
{
    public partial class UCNavigationEngins: UserControl
    {

        BindingSource bsEngins = new BindingSource();
        BindingSource bsCaserne = new BindingSource();
        public UCNavigationEngins()
        {
            InitializeComponent();
        }
        public void SetData(DataSet ds)
        {
            if (!ds.Relations.Contains("Caserne_Engins"))
            {
                ds.Relations.Add("Caserne_Engins",
                    ds.Tables["Caserne"].Columns["id"],
                    ds.Tables["Engin"].Columns["idCaserne"]);
            }
            // ComboBox casernes
            bsCaserne.DataSource = ds;
            bsCaserne.DataMember = "Caserne";

            cboCaserne.DataSource = bsCaserne;
            cboCaserne.DisplayMember = "nom";
            cboCaserne.ValueMember = "id";

            // Lier les engins via la relation "Caserne_Engins"
            bsEngins.DataSource = bsCaserne;
            bsEngins.DataMember = "Caserne_Engins";

            lblNumData.DataBindings.Clear();
            lblNumData.DataBindings.Add("Text", bsEngins, "numero");

            lblTypeData.DataBindings.Clear();
            lblTypeData.DataBindings.Add("Text", bsEngins, "codeTypeEngin");

            lblDateData.DataBindings.Clear();
            lblDateData.DataBindings.Add("Text", bsEngins, "dateReception");

            chkPanne.DataBindings.Clear();
            chkPanne.DataBindings.Add("Checked", bsEngins, "enPanne", true, DataSourceUpdateMode.OnPropertyChanged, false, "Convert.ToBoolean(value)");

            chkMission.DataBindings.Clear();
            chkMission.DataBindings.Add("Checked", bsEngins, "enMission", true, DataSourceUpdateMode.OnPropertyChanged, false, "Convert.ToBoolean(value)");

        }

        private void btnAvant_Click(object sender, EventArgs e)
        {
            if (bsEngins.Position < bsEngins.Count - 1)
            {
                bsEngins.MoveNext();
            }
        }

        private void btnArriere_Click(object sender, EventArgs e)
        {
            if (bsEngins.Position > 0)
            {
                bsEngins.MovePrevious();
            }
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            bsEngins.MoveLast();
        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            bsEngins.MoveFirst();
        }
    }
}
