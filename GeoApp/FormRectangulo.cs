using GeoApp.Models;
using System;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class FormRectangulo : Form
    {
        public FormRectangulo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado = Calculadora.AreaRectangulo(
    double.Parse(txtBase.Text),
    double.Parse(txtAltura.Text));

            MessageBox.Show("Área: " + resultado);
        }
    }
}
