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
    public partial class NavigationEngins: UserControl
    {

        BindingSource bsEngins = new BindingSource();
        BindingSource bsCaserne = new BindingSource();
        public NavigationEngins()
        {
            InitializeComponent();
        }
        public void SetData(DataSet ds)
        {
            bsEngins.DataSource = ds;
            bsEngins.DataMember = "Engins";

            // Lier la caserne à l'engin via la relation
            bsCaserne.DataSource = bsEngins;
            bsCaserne.DataMember = "Engin_Caserne";

            // Nom de l'engin (champ direct)
            //lblNomEngin.DataBindings.Clear();
            //lblNomEngin.DataBindings.Add("Text", bsEngins, "nomEngin");

            // Nom de la caserne (champ via relation)
            //lblNomCaserne.DataBindings.Clear();
            //lblNomCaserne.DataBindings.Add("Text", bsCaserne, "nomCaserne");
        }
    }
}
