namespace Calculos_matematicos
{
    partial class FormPerimetroAreaCiIrulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerimetroAreaCiIrulo));
            this.label1 = new System.Windows.Forms.Label();
            this.txtRadioCirculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPerimetroCirculo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAreaCirculo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(50, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el radio del Circulo:";
            // 
            // txtRadioCirculo
            // 
            this.txtRadioCirculo.Location = new System.Drawing.Point(200, 117);
            this.txtRadioCirculo.Name = "txtRadioCirculo";
            this.txtRadioCirculo.Size = new System.Drawing.Size(121, 20);
            this.txtRadioCirculo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(61, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "El perimetro del circulo es :";
            // 
            // txtPerimetroCirculo
            // 
            this.txtPerimetroCirculo.Location = new System.Drawing.Point(210, 223);
            this.txtPerimetroCirculo.Name = "txtPerimetroCirculo";
            this.txtPerimetroCirculo.Size = new System.Drawing.Size(82, 20);
            this.txtPerimetroCirculo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(71, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "El área del Circulo es :";
            // 
            // txtAreaCirculo
            // 
            this.txtAreaCirculo.Location = new System.Drawing.Point(210, 288);
            this.txtAreaCirculo.Name = "txtAreaCirculo";
            this.txtAreaCirculo.Size = new System.Drawing.Size(82, 20);
            this.txtAreaCirculo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cálculo de Perimetro y Area de un Circulo";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(162, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPerimetroAreaCiIrulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAreaCirculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPerimetroCirculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRadioCirculo);
            this.Controls.Add(this.label1);
            this.Name = "FormPerimetroAreaCiIrulo";
            this.Text = "FormPerimetroAreaCiIrulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadioCirculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPerimetroCirculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAreaCirculo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}