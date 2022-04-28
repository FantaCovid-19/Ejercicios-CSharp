using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CmbProductList();
        }

        private void CmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbProduct.SelectedIndex == 0)
            {
                TxtValor.Text = "40000";
            }
            else if (CmbProduct.SelectedIndex == 1)
            {
                TxtValor.Text = "75000";
            }
            else if (CmbProduct.SelectedIndex == 2)
            {
                TxtValor.Text = "620000";
            }
        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (TxtCantidad.Text == String.Empty)
            {
                TxtTotal.Text = null;
                TxtIva.Text = null;
                TxtPagar.Text = null;

                return;
            }
        }

        private void txtCantCuotas_TextChanged(object sender, EventArgs e)
        {
            if (txtCantCuotas.Text == String.Empty)
            {
                TxtValCuotas.Text = null;
                TxtTotFinal.Text = null;

                return;
            }
        }

        private void CalCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Boolean valid = IsANumber(TxtCantidad.Text);

                if(TxtValor.Text == String.Empty)
                {
                    MessageBox.Show("Ingrese un producto");
                    return;
                }

                if (valid)
                {
                    double x = Double.Parse(TxtCantidad.Text);
                    double y = Double.Parse(TxtValor.Text);
                    double result_0 = x * y;
                    double result_1 = result_0 * 0.19;
                    double result_2 = result_0 + result_1;

                    TxtTotal.Text = result_0.ToString();
                    TxtIva.Text = result_1.ToString();
                    TxtPagar.Text = result_2.ToString();
                }
                else
                {
                    MessageBox.Show("Solo Numeros");
                }
            }
        }

        private void CalCuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Boolean valid = IsANumber(txtCantCuotas.Text);

                if (valid)
                {
                    double x = Double.Parse(TxtPagar.Text);
                    double y = Double.Parse(txtCantCuotas.Text);

                    if (y >= 1 && y <= 3) // 12%
                    {
                        double result_0 = x / y;
                        double result_1 = result_0 + (result_0 * 0.12);
                        double result_2 = result_1 + x;

                        TxtValCuotas.Text = result_1.ToString();
                        TxtTotFinal.Text = result_2.ToString();
                    }
                    else if (y >= 4 && y <= 7) // 18%
                    {
                        double result_0 = x / y;
                        double result_1 = result_0 + (result_0 * 0.18);
                        double result_2 = result_1 + x;

                        TxtValCuotas.Text = result_1.ToString();
                        TxtTotFinal.Text = result_2.ToString();
                    }
                    else if (y >= 8 && y <= 12) // 21%
                    {
                        double result_0 = x / y;
                        double result_1 = result_0 + (result_0 * 0.21);
                        double result_2 = result_1 + x;

                        TxtValCuotas.Text = result_1.ToString();
                        TxtTotFinal.Text = result_2.ToString();
                    }
                    else if (y > 12) // 32%
                    {
                        double result_0 = x / y;
                        double result_1 = result_0 + (result_0 * 0.32);
                        double result_2 = result_1 + x;

                        TxtValCuotas.Text = result_1.ToString();
                        TxtTotFinal.Text = result_2.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Solo Numeros");
                }
            }
        }

        private void CmbProductList()
        {
            CmbProduct.Items.Add("Memoria Ram");
            CmbProduct.Items.Add("Disco Duro");
            CmbProduct.Items.Add("Tarjeta Grafica");
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

        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            Form2 _ver = new Form2();
            _ver._name = TxtTotFinal.Text.ToString();
            _ver.Show();
        }
    }
}
