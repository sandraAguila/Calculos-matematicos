namespace Calculos_matematicos
{
    partial class FormRaizCuadrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRaizCuadrada));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcularRaiz = new System.Windows.Forms.Button();
            this.txtRaizCuadrada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(110, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raíz Cuadrada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(40, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(172, 133);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(91, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(51, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "La raíz cuadrada es:";
            // 
            // btnCalcularRaiz
            // 
            this.btnCalcularRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCalcularRaiz.Location = new System.Drawing.Point(121, 385);
            this.btnCalcularRaiz.Name = "btnCalcularRaiz";
            this.btnCalcularRaiz.Size = new System.Drawing.Size(142, 28);
            this.btnCalcularRaiz.TabIndex = 5;
            this.btnCalcularRaiz.Text = "Cálcular";
            this.btnCalcularRaiz.UseVisualStyleBackColor = true;
            this.btnCalcularRaiz.Click += new System.EventHandler(this.btnCalcularRaiz_Click);
            // 
            // txtRaizCuadrada
            // 
            this.txtRaizCuadrada.AutoSize = true;
            this.txtRaizCuadrada.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRaizCuadrada.Location = new System.Drawing.Point(205, 224);
            this.txtRaizCuadrada.Name = "txtRaizCuadrada";
            this.txtRaizCuadrada.Size = new System.Drawing.Size(13, 13);
            this.txtRaizCuadrada.TabIndex = 15;
            this.txtRaizCuadrada.Text = "0";
            // 
            // FormRaizCuadrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.txtRaizCuadrada);
            this.Controls.Add(this.btnCalcularRaiz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRaizCuadrada";
            this.Text = "FormRaizCuadrada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcularRaiz;
        private System.Windows.Forms.Label txtRaizCuadrada;
    }
}