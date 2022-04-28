using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSum_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text != string.Empty && txtNum2.Text != string.Empty)
            {
                Boolean x = IsANumber(txtNum1.Text);
                Boolean y = IsANumber(txtNum2.Text);

                if(x && y)
                {
                    double num_1 = Double.Parse(txtNum1.Text);
                    double num_2 = Double.Parse(txtNum2.Text);
                    double result = (num_1 + num_2);

                    txtTotal.Text = result.ToString();
                    txtTotal.Visible = true;
                } 
                else
                {
                    MessageBox.Show("Los Campos estan vacidos o Ingreso algun Caracter");
                    Clear();
                }
            } 
            else
            {
                MessageBox.Show("Los Campos estan vacidos");
                Clear();
            }
        }

        private void BtnRest_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text != string.Empty && txtNum2.Text != string.Empty)
            {
                Boolean x = IsANumber(txtNum1.Text);
                Boolean y = IsANumber(txtNum2.Text);

                if (x && y)
                {
                    double num_1 = Double.Parse(txtNum1.Text);
                    double num_2 = Double.Parse(txtNum2.Text);
                    double result = (num_1 - num_2);

                    txtTotal.Text = result.ToString();
                    txtTotal.Visible = true;
                }
                else
                {
                    MessageBox.Show("Los Campos estan vacidos o Ingreso algun Caracter");
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Los Campos estan vacidos");
                Clear();
            }
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text != string.Empty && txtNum2.Text != string.Empty)
            {
                Boolean x = IsANumber(txtNum1.Text);
                Boolean y = IsANumber(txtNum2.Text);

                if (x && y)
                {
                    double num_1 = Double.Parse(txtNum1.Text);
                    double num_2 = Double.Parse(txtNum2.Text);
                    double result = (num_1 * num_2);

                    txtTotal.Text = result.ToString();
                    txtTotal.Visible = true;
                }
                else
                {
                    MessageBox.Show("Los Campos estan vacidos o Ingreso algun Caracter");
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Los Campos estan vacidos");
                Clear();
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text != string.Empty && txtNum2.Text != string.Empty)
            {
                Boolean x = IsANumber(txtNum1.Text);
                Boolean y = IsANumber(txtNum2.Text);

                if (x && y)
                {
                    double num_1 = Double.Parse(txtNum1.Text);
                    double num_2 = Double.Parse(txtNum2.Text);
                    double result = (num_1 / num_2);

                    txtTotal.Text = result.ToString();
                    txtTotal.Visible = true;
                }
                else
                {
                    MessageBox.Show("Los Campos estan vacidos o Ingreso algun Caracter");
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Los Campos estan vacidos");
                Clear();
            }
        }

        private void BtnPor_Click(object sender, EventArgs e)
        {
            if (txtNum1.Text != string.Empty && txtNum2.Text != string.Empty)
            {
                Boolean x = IsANumber(txtNum1.Text);
                Boolean y = IsANumber(txtNum2.Text);

                if (x && y)
                {
                    double num_1 = Double.Parse(txtNum1.Text);
                    double num_2 = Double.Parse(txtNum2.Text);
                    double result = (num_1 % num_2);

                    txtTotal.Text = result.ToString();
                    txtTotal.Visible = true;
                }
                else
                {
                    MessageBox.Show("Los Campos estan vacidos o Ingreso algun Caracter");
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Los Campos estan vacidos");
                Clear();
            }
        }

        private void Clear()
        {
            txtNum1.Text = null;
            txtNum2.Text = null;
        }

        public static bool IsANumber(string x)
        {
            foreach (char c in x)
            {
                if (!char.IsDigit(c) && c != '.')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
