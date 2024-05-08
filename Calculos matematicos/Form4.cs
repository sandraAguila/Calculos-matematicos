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
    public partial class FormAreaTriangulo : Form
    {
        public FormAreaTriangulo()
        {
            InitializeComponent();
        }

        private void btnCalcularAreaTriangulo_Click(object sender, EventArgs e)
        {
            double ladoa= 0;
            double ladob  = 0;
            double ladoc = 0;
            double result = 0;

            ladoa = Convert.ToDouble(txtladoA.Text);
            ladob = Convert.ToDouble(txtladoB.Text);
            ladoc = Convert.ToDouble(txtladoC.Text);

            result = ladoa * ladob * ladoc;//re4visar formula de calculo

            Resultado.Text = Convert.ToString(result);



        }
    }
}
