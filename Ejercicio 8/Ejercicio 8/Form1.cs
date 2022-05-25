using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Data Source=195.62.47.122;Initial Catalog=Ejercicios;User ID=SA;Password=FantaCovid-19

namespace Ejercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConn_Click(object sender, EventArgs e)
        {
            Connect _conn = new Connect();
            _conn.Conn(txtServidor.Text, txtDatabase.Text);
            dgv_data.DataSource = _conn.fill_data(txtTable.Text);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Form2 _view = new Form2();
            _view.host = txtServidor.Text;
            _view.database = txtDatabase.Text;
            _view.table = txtTable.Text;

            _view.Show();
            this.Hide();
               
        }
    }
}
