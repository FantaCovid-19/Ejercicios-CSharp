using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_8
{
    public partial class Form2 : Form
    {
        public string host;
        public string database;
        public string table;
        private bool Edit = false;

        public Form2()
        {
            InitializeComponent();
            CbListarCargos();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FillTable(host, database, table);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Connect _conn = new Connect();
            _conn.Conn(host, database);

           if (Edit == false)
           {
                try
                {
                    int Status;
                    string Cargos = cbGrade.Text;

                    if (checkOnDuty.Checked && !checkOffDuty.Checked)
                    {
                        Status = 1;
                    }
                    else
                    {
                        Status = 0;
                    }

                    _conn.insert(table, int.Parse(numTxtId.Text), txtRun.Text, txtName.Text, txtLastName.Text, float.Parse(numTxtHours.Text), Cargos, Status);

                    FillTable(host, database, table);
                    Clean();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

           if (Edit == true)
           {
                try
                {
                    int Status;

                    if (checkOnDuty.Checked && !checkOffDuty.Checked)
                    {
                        Status = 1;
                    }
                    else
                    {
                        Status = 0;
                    }

                    _conn.update(table, txtRun.Text, txtName.Text, txtLastName.Text, float.Parse(numTxtHours.Text), cbGrade.Text, Status, int.Parse(numTxtId.Text));

                    FillTable(host, database, table);
                    Clean();

                    Edit = false;
                }      
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
           }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvListJobs.SelectedRows.Count > 0)
            {
                int statusID;
                Edit = true;

                numTxtId.Text = dgvListJobs.CurrentRow.Cells["id"].Value.ToString();
                txtRun.Text = dgvListJobs.CurrentRow.Cells["run"].Value.ToString();
                txtName.Text = dgvListJobs.CurrentRow.Cells["name"].Value.ToString();
                txtLastName.Text = dgvListJobs.CurrentRow.Cells["last_name"].Value.ToString();
                numTxtHours.Text = dgvListJobs.CurrentRow.Cells["hours"].Value.ToString();
                cbGrade.Text = dgvListJobs.CurrentRow.Cells["grade"].Value.ToString();

                statusID = int.Parse(dgvListJobs.CurrentRow.Cells["status"].Value.ToString());

                if (statusID == 0)
                {
                    checkOffDuty.Checked = true;
                }
                else if (statusID == 1)
                {
                    checkOnDuty.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Seleccione una Fila");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Connect _conn = new Connect();
            _conn.Conn(host, database);

            if (dgvListJobs.SelectedRows.Count > 0)
            {
                string numTxtIdText = dgvListJobs.CurrentRow.Cells["id"].Value.ToString();

                _conn.delete(table, int.Parse(numTxtIdText));
                FillTable(host, database, table);
                Clean();
            }
        }

        private void CbListarCargos()
        {
            cbGrade.Items.Add("Bodeguero");
            cbGrade.Items.Add("Gerente");
            cbGrade.Items.Add("Reponedor");
            cbGrade.Items.Add("Cajero");
        }

        private void Clean()
        {
            numTxtId.Text = null;
            txtRun.Text = null;
            txtName.Text = null;
            txtLastName.Text = null;
            numTxtHours.Text = null;
            cbGrade.Text = null;
            checkOnDuty.Checked = false;
            checkOffDuty.Checked = false;
        }

        private void FillTable(string x, string y, string z)
        {
            Connect _conn = new Connect();
            _conn.Conn(x, y);

            dgvListJobs.DataSource = _conn.fill_data(z);
        }
    }
}
