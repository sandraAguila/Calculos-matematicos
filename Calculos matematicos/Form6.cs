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
    public partial class FormAreaRectangulo : Form
    {
        public FormAreaRectangulo()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularAreaRectangulo_Click(object sender, EventArgs e)
        {
            double Base = 0;
            double altura = 0;
            double result = 0;

            Base = Convert.ToDouble(txtBase.Text );
            altura = Convert.ToDouble(txtAltura.Text);

            result = Base * altura;

            Resultado.Text = Convert.ToString(result);

        }
    }
}
