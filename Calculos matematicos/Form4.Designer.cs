namespace Calculos_matematicos
{
    partial class FormAreaTriangulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAreaTriangulo));
            this.txtladoA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtladoC = new System.Windows.Forms.TextBox();
            this.txtladoB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcularAreaTriangulo = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtladoA
            // 
            this.txtladoA.Location = new System.Drawing.Point(152, 125);
            this.txtladoA.Margin = new System.Windows.Forms.Padding(4);
            this.txtladoA.Name = "txtladoA";
            this.txtladoA.Size = new System.Drawing.Size(168, 22);
            this.txtladoA.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese lado a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese lado c:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingrese lado b:";
            // 
            // txtladoC
            // 
            this.txtladoC.Location = new System.Drawing.Point(152, 305);
            this.txtladoC.Margin = new System.Windows.Forms.Padding(4);
            this.txtladoC.Name = "txtladoC";
            this.txtladoC.Size = new System.Drawing.Size(168, 22);
            this.txtladoC.TabIndex = 4;
            // 
            // txtladoB
            // 
            this.txtladoB.Location = new System.Drawing.Point(152, 225);
            this.txtladoB.Margin = new System.Windows.Forms.Padding(4);
            this.txtladoB.Name = "txtladoB";
            this.txtladoB.Size = new System.Drawing.Size(168, 22);
            this.txtladoB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 382);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "El Area del triángulo es :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(299, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cálculo del Area de un Triángulo";
            // 
            // btnCalcularAreaTriangulo
            // 
            this.btnCalcularAreaTriangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCalcularAreaTriangulo.Location = new System.Drawing.Point(152, 443);
            this.btnCalcularAreaTriangulo.Name = "btnCalcularAreaTriangulo";
            this.btnCalcularAreaTriangulo.Size = new System.Drawing.Size(142, 28);
            this.btnCalcularAreaTriangulo.TabIndex = 9;
            this.btnCalcularAreaTriangulo.Text = "Cálcular";
            this.btnCalcularAreaTriangulo.UseVisualStyleBackColor = true;
            this.btnCalcularAreaTriangulo.Click += new System.EventHandler(this.btnCalcularAreaTriangulo_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Resultado.Location = new System.Drawing.Point(232, 393);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(15, 16);
            this.Resultado.TabIndex = 13;
            this.Resultado.Text = "0";
            // 
            // FormAreaTriangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(427, 554);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.btnCalcularAreaTriangulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtladoB);
            this.Controls.Add(this.txtladoC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtladoA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAreaTriangulo";
            this.Text = "FormAreaTriangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtladoA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtladoC;
        private System.Windows.Forms.TextBox txtladoB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcularAreaTriangulo;
        private System.Windows.Forms.Label Resultado;
    }
}