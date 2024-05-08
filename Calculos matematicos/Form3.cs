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
    public partial class FormVolumencilindro : System.Windows.Forms.Form
    {
        public FormVolumencilindro()
        {
            InitializeComponent();
        }

        private void btnCalcularVolumenCilindro_Click(object sender, EventArgs e)
        {
            //Dleclaro mis variables 
            double radio = 0;
            double altura = 0;
            double Result = 0;
           // double pi = 3.141516;

            //Covierto las variables de claradas a double dado que la extraigo como string desde los textbox
            radio = Convert.ToDouble(txtRadio.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            
            //aplico la formula
            Result = Math.PI  * (radio * radio)  * altura;//falta elevar al cuadro el radio
            //Convierto el resulto que es un double a un string que imprimira el label
            Resultado.Text = Convert.ToString(Result);

        }
    }
}
