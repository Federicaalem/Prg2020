namespace EjWhile.F
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
            this.LblEt = new System.Windows.Forms.Label();
            this.btnArrancar = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblEt
            // 
            this.LblEt.BackColor = System.Drawing.Color.Tomato;
            this.LblEt.Location = new System.Drawing.Point(0, 387);
            this.LblEt.Name = "LblEt";
            this.LblEt.Size = new System.Drawing.Size(51, 19);
            this.LblEt.TabIndex = 0;
            // 
            // btnArrancar
            // 
            this.btnArrancar.Location = new System.Drawing.Point(28, 26);
            this.btnArrancar.Name = "btnArrancar";
            this.btnArrancar.Size = new System.Drawing.Size(75, 23);
            this.btnArrancar.TabIndex = 1;
            this.btnArrancar.Text = "Arrancar";
            this.btnArrancar.UseVisualStyleBackColor = true;
            this.btnArrancar.Click += new System.EventHandler(this.btnArrancar_Click);
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(409, 82);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(0, 37);
            this.lblContador.TabIndex = 2;
            // 
            // Lbl2
            // 
            this.Lbl2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Lbl2.Location = new System.Drawing.Point(0, 150);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(51, 19);
            this.Lbl2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 564);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.btnArrancar);
            this.Controls.Add(this.LblEt);
            this.Name = "Form1";
            this.Text = "EjemploWhile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEt;
        private System.Windows.Forms.Button btnArrancar;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label Lbl2;
    }
}

