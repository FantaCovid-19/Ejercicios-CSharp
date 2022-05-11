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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InicioMenu.Visible = false;
            LoginMenu.Visible = true;
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Equals(LoginMenu))
            {
                Form2 _view = new Form2();
                _view.MdiParent = this;
                _view.Show();
            }
        }
    }
}
