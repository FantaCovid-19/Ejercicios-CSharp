using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {

        public bool _value = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_value)
            {
                isClean();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            Form2 _view = new Form2();

            Boolean isValidEmpty = IsAEmpty();
            Boolean isValidNum = IsANumber(TxtMonto.Text);

            if (isValidEmpty)
            {
                _view._name = TxtName.Text;

                if (isValidNum)
                {
                    _view._amount = Double.Parse(TxtMonto.Text);
                }
                else
                {
                    MessageBox.Show("Solo Numeros");
                    return;
                }
                
                _view._fee = (int)TxtCuotas.Value;

                if (RBtnTaxTrue.Checked && !RBtnTaxFalse.Checked)
                {
                    _view._taxrelief = true;
                } 
                else
                {
                    _view._taxrelief = false;
                }

                if (RBtnFireTrue.Checked && !RBtnFireFalse.Checked)
                {
                    _view._fire = true;
                }
                else
                {
                    _view._fire = false;
                }
                
                _view.Show();

                this.Hide();
            }
            else
            {
                return;
            }
        }

        private void isClean()
        {
            TxtCuotas.Text = null;
            TxtMonto.Text = null;
            TxtName.Text = null;
        }

        private Boolean IsAEmpty()
        {
            if (TxtName.Text == String.Empty)
            {
                MessageBox.Show("Ingrese un Nombre");
                return false;
            }
            else if (TxtMonto.Text == String.Empty)
            {
                MessageBox.Show("Solo Numeros");
                return false;
            }
            else if (TxtCuotas.Value == 0)
            {
                MessageBox.Show("Ingrese almenos 1 cuota");
                return false;
            }
            else if (!RBtnTaxTrue.Checked && !RBtnTaxFalse.Checked)
            {
                MessageBox.Show("Seleciona una Opcion");
                return false;
            }
            else if (!RBtnFireTrue.Checked && !RBtnFireFalse.Checked)
            {
                MessageBox.Show("Seleciona una Opcion");
                return false;
            }
            else
            {
                return true;
            }
        }

        private Boolean IsANumber(String x)
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
