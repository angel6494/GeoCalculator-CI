using GeoApp.Models;
using System;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class FormCirculo : Form
    {
        public FormCirculo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtRadio.Text, out double radio))
            {
                if (radio > 0)
                {
                    double resultado = Calculadora.AreaCirculo(radio);
                    MessageBox.Show("Área: " + resultado);
                }
                else
                {
                    MessageBox.Show("El radio debe ser mayor a 0.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
        }
    }
}
