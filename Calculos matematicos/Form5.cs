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
    public partial class FormPerimetroAreaCiIrulo : Form
    {
        public FormPerimetroAreaCiIrulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radio = 0;
            double perimetro = 0;
            double area = 0;

            radio = Convert.ToDouble (txtRadioCirculo.Text);

            perimetro = 2 * Math.PI * radio;
            area = Math.PI * (radio * radio);

            txtPerimetroCirculo.Text = Convert.ToString(perimetro);
            txtAreaCirculo.Text = Convert.ToString(area);



        }
    }
}
