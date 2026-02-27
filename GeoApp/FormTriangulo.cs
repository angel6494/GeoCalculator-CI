using System;
using System.Windows.Forms;
using GeoApp.Models;

namespace GeoApp
{
    public partial class FormTriangulo : Form
    {
        public FormTriangulo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBase.Text, out double baseT) &&
    double.TryParse(txtAltura.Text, out double altura))
            {
                if (baseT > 0 && altura > 0)
                {
                    double resultado = Calculadora.AreaTriangulo(baseT, altura);
                    MessageBox.Show("Área: " + resultado);
                }
                else
                {
                    MessageBox.Show("Los valores deben ser mayores a 0.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos.");
            }
        }
    }


}

