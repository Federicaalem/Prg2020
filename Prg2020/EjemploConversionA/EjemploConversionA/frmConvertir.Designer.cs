namespace EjemploConversionA
{
    partial class frmConvertir
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
            this.txtOper1 = new System.Windows.Forms.TextBox();
            this.txtOper2 = new System.Windows.Forms.TextBox();
            this.btnIgual = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOper1
            // 
            this.txtOper1.Location = new System.Drawing.Point(65, 48);
            this.txtOper1.Name = "txtOper1";
            this.txtOper1.Size = new System.Drawing.Size(100, 20);
            this.txtOper1.TabIndex = 0;
            // 
            // txtOper2
            // 
            this.txtOper2.Location = new System.Drawing.Point(232, 47);
            this.txtOper2.Name = "txtOper2";
            this.txtOper2.Size = new System.Drawing.Size(100, 20);
            this.txtOper2.TabIndex = 1;
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(349, 45);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(42, 23);
            this.btnIgual.TabIndex = 2;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(190, 47);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(21, 21);
            this.lblSuma.TabIndex = 3;
            this.lblSuma.Text = "+";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(407, 48);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 24);
            this.lblResultado.TabIndex = 4;
            // 
            // frmConvertir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 171);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.txtOper2);
            this.Controls.Add(this.txtOper1);
            this.Name = "frmConvertir";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOper1;
        private System.Windows.Forms.TextBox txtOper2;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblResultado;
    }
}

