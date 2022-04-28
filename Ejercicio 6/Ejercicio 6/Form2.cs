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
    public partial class Form2 : Form
    {

        public string _name;
        public double _amount;
        public int _fee;
        public Boolean _taxrelief;
        public Boolean _fire;
        public double segurosx;
        public double segurosy;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            isALoad();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            double x;
            double z = double.Parse(TxtTotSeguros.Text);
            double y = double.Parse(TxtValCuotas.Text);

            x = (z + y) / _fee;

            MessageBox.Show("Mensaje:" + "\n" +
                "Sr@: " + _name + "\n" +
                "Subcredito: " + TxtTotPagar.Text + "CLP" + "\n" +
                "Años: " + _fee + "\n" +
                "Valor Cuotas con seguros: " + x.ToString() + "CLP");
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            isClear();
        }

        private void isClear()
        {
            TxtInteres.Text = null;
            TxtTotPagar.Text = null;
            TxtTotSeguros.Text = null;
            TxtValCuotas.Text = null;

            Form1 _view = new Form1();
            _view._value = true;
            _view.Show();
            this.Hide();
        }

        private void isALoad()
        {
            if (_fee >= 1 && _fee <= 10) // 25%
            {
                double x = _amount * 32140;
                double result_0 = x / _fee;
                double result_1 = result_0 + (result_0 * 0.25);
                double result_2 = result_1 + x;

                TxtValCuotas.Text = result_0.ToString();
                TxtInteres.Text = result_1.ToString();
                TxtTotPagar.Text = result_2.ToString();
            }
            else if (_fee >= 11 && _fee <= 20) // 35%
            {
                double x = _amount * 32140;
                double result_0 = x / _fee;
                double result_1 = result_0 + (result_0 * 0.35);
                double result_2 = result_1 + x;

                TxtValCuotas.Text = result_0.ToString();
                TxtInteres.Text = result_1.ToString();
                TxtTotPagar.Text = result_2.ToString();
            }
            else if (_fee < 21) // 45%
            {
                double x = _amount * 32140;
                double result_0 = x / _fee;
                double result_1 = result_0 + (result_0 * 0.45);
                double result_2 = result_1 + x;

                TxtValCuotas.Text = result_0.ToString();
                TxtInteres.Text = result_1.ToString();
                TxtTotPagar.Text = result_2.ToString();
            }
            
            if (_taxrelief)
            {
                double x = _amount * 32140;
                segurosx = x + (0.35 * x);
            }
            
            if (_fire)
            {
                double x = _amount * 32140;
                segurosy = x + (0.30 * x);
            }

            if (segurosx > 0 && segurosy > 0)
            {
                double seguros;
                seguros = segurosx + segurosy;

                TxtTotSeguros.Text = seguros.ToString();
            }
            else if (segurosx > 0)
            {
                TxtTotSeguros.Text = segurosx.ToString();
            }
            else if (segurosy > 0)
            {
                TxtTotSeguros.Text = segurosy.ToString();
            }
        }
    }
}
