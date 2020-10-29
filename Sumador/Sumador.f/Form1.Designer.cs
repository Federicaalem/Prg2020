namespace Sumador.f
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSumando1 = new System.Windows.Forms.TextBox();
            this.txtSumando2 = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.LblSigno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSumando1
            // 
            this.txtSumando1.Location = new System.Drawing.Point(12, 32);
            this.txtSumando1.Name = "txtSumando1";
            this.txtSumando1.Size = new System.Drawing.Size(100, 20);
            this.txtSumando1.TabIndex = 0;
            // 
            // txtSumando2
            // 
            this.txtSumando2.Location = new System.Drawing.Point(178, 34);
            this.txtSumando2.Name = "txtSumando2";
            this.txtSumando2.Size = new System.Drawing.Size(100, 20);
            this.txtSumando2.TabIndex = 1;
            // 
            // btnSuma
            // 
            this.btnSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuma.Location = new System.Drawing.Point(312, 21);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 37);
            this.btnSuma.TabIndex = 2;
            this.btnSuma.Text = "=";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(426, 32);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 3;
            // 
            // LblSigno
            // 
            this.LblSigno.AutoSize = true;
            this.LblSigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSigno.Location = new System.Drawing.Point(131, 29);
            this.LblSigno.Name = "LblSigno";
            this.LblSigno.Size = new System.Drawing.Size(28, 29);
            this.LblSigno.TabIndex = 4;
            this.LblSigno.Text = "+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 104);
            this.Controls.Add(this.LblSigno);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.txtSumando2);
            this.Controls.Add(this.txtSumando1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSumando1;
        private System.Windows.Forms.TextBox txtSumando2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label LblSigno;
    }
}

