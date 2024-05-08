using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculos_matematicos
{
    public partial class MenuCalculos : System.Windows.Forms.Form
    {
        public MenuCalculos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolumenCilindro_Click(object sender, EventArgs e)
        {
            Form formulario = new FormVolumencilindro();
            formulario.Show();
            Hide();

        }

        private void MenuCalculos_Load(object sender, EventArgs e)
        {

        }

        private void btnPerimetroCircunferencia_Click(object sender, EventArgs e)
        {
            Form Formulario = new FormPerimetroAreaCiIrulo();
            Formulario.Show();
            Hide();
        }

        private void btnAreaRectangulo_Click(object sender, EventArgs e)
        {
            Form formulario = new FormAreaRectangulo();
            formulario.Show();
            Hide();
        }

        private void btnAreaTriangulo_Click(object sender, EventArgs e)
        {
            Form formulario = new FormAreaTriangulo();
            formulario.Show();
            Hide();
        }

        private void btnRaizCuadrada_Click(object sender, EventArgs e)
        {
            Form formulario = new FormRaizCuadrada();
            formulario.Show();
            Hide();


           
        }
    }
}
