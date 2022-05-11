using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_7
{
    public partial class Form2 : Form
    {
        private int y = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Username usr = new Username(TxtUsername.Text, TxtPassword.Text);

            if (y >= 3)
            {
                ((Form1)this.MdiParent).Close();
            }

            if (usr.Validation())
            {
                ((Form1)this.MdiParent).InicioMenu.Visible = true;
                ((Form1)this.MdiParent).LoginMenu.Visible = false;

                this.Close();
            } 
            else
            {
                y++;
            }
        }
    }
}
