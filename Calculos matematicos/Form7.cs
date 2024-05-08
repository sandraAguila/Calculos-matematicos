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
    public partial class FormRaizCuadrada : Form
    {
        public FormRaizCuadrada()
        {
            InitializeComponent();
        }

        private void btnCalcularRaiz_Click(object sender, EventArgs e)
        {
            double valor = 0;
            double Result = 0;

            valor = Convert.ToDouble(txtNumero.Text);

            Result = Math.Sqrt(valor);

            txtRaizCuadrada.Text = Convert.ToString(Result);
           
        }
    }
}
