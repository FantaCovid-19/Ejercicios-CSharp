using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            InitComBox();
        }

        public void InitComBox()
        {
            string[] x = { "Informatica" , "Construcción", "Administración" };

            foreach(string s in x)
            {
                ComBoxUniversity.Items.Add(s);
            }
        }

        private void ComBoxUniversity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComBoxUniversity.SelectedIndex == 1)
            {
                TxtArancel.Text("1.500.000");
            } else if (ComBoxUniversity.SelectedIndex == 2)
            {

            }
        }
    }
}
