using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Test();
        }

        private void TxtPromedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == ".")
            {
                e.Handled = true;
                this.TxtPromedio.Text += ",";
                SendKeys.Send("{END}");
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                Test();
            }
        }

        private void Test()
        {
            if (TxtPromedio.Text != String.Empty)
            {
                Boolean x = IsANumber(TxtPromedio.Text);

                if (x)
                {
                    double num_1 = Double.Parse(TxtPromedio.Text);

                    if (num_1 >= 4)
                    {
                        LblResult.Text = "Esta Aprobado";
                        LblResult.ForeColor = Color.Green;
                        LblResult.Visible = true;
                    }
                    else
                    {
                        LblResult.Text = "Esta Reprobado";
                        LblResult.ForeColor = Color.Red;
                        LblResult.Visible = true;
                    }
                } 
                else
                {
                    MessageBox.Show("Solo Numeros");
                }
            } 
            else
            {
                MessageBox.Show("Ingrese un Dato");
            }

            Clean();
        }

        private void Clean()
        {
            TxtPromedio.Text = null;
            TxtPromedio.Focus();
        }

        private bool IsANumber(String x)
        {
            foreach (char c in x)
            {
                if (char.IsDigit(c) && c != '.')
                {
                    return true;
                }
            }

            return false;
        }        
    }
}
