using System;
using System.Windows.Forms;

namespace GeoApp
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            FormRectangulo fr = new FormRectangulo();
            fr.ShowDialog();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            FormCirculo fc = new FormCirculo();
            fc.ShowDialog();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            FormTriangulo ft = new FormTriangulo();
            ft.ShowDialog();
        }
    }
}
