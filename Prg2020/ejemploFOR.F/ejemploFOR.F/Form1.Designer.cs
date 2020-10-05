namespace ejemploFOR.F
{
    partial class FrmContador
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
            this.lblEt1 = new System.Windows.Forms.Label();
            this.lblRess = new System.Windows.Forms.Label();
            this.btnContar = new System.Windows.Forms.Button();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.lblEt2 = new System.Windows.Forms.Label();
            this.txtPaso = new System.Windows.Forms.TextBox();
            this.lblEt3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEt1
            // 
            this.lblEt1.AutoSize = true;
            this.lblEt1.Location = new System.Drawing.Point(58, 49);
            this.lblEt1.Name = "lblEt1";
            this.lblEt1.Size = new System.Drawing.Size(38, 13);
            this.lblEt1.TabIndex = 0;
            this.lblEt1.Text = "Desde";
            // 
            // lblRess
            // 
            this.lblRess.AutoSize = true;
            this.lblRess.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRess.Location = new System.Drawing.Point(204, 141);
            this.lblRess.Name = "lblRess";
            this.lblRess.Size = new System.Drawing.Size(0, 46);
            this.lblRess.TabIndex = 1;
            // 
            // btnContar
            // 
            this.btnContar.Location = new System.Drawing.Point(414, 81);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(75, 23);
            this.btnContar.TabIndex = 2;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = true;
            this.btnContar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(61, 85);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDesde.TabIndex = 3;
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(180, 85);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(100, 20);
            this.txtHasta.TabIndex = 4;
            // 
            // lblEt2
            // 
            this.lblEt2.AutoSize = true;
            this.lblEt2.Location = new System.Drawing.Point(190, 49);
            this.lblEt2.Name = "lblEt2";
            this.lblEt2.Size = new System.Drawing.Size(35, 13);
            this.lblEt2.TabIndex = 5;
            this.lblEt2.Text = "Hasta";
            // 
            // txtPaso
            // 
            this.txtPaso.Location = new System.Drawing.Point(298, 84);
            this.txtPaso.Name = "txtPaso";
            this.txtPaso.Size = new System.Drawing.Size(100, 20);
            this.txtPaso.TabIndex = 6;
            // 
            // lblEt3
            // 
            this.lblEt3.AutoSize = true;
            this.lblEt3.Location = new System.Drawing.Point(298, 49);
            this.lblEt3.Name = "lblEt3";
            this.lblEt3.Size = new System.Drawing.Size(31, 13);
            this.lblEt3.TabIndex = 7;
            this.lblEt3.Text = "Paso";
            // 
            // FrmContador
            // 
            this.AcceptButton = this.btnContar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 266);
            this.Controls.Add(this.lblEt3);
            this.Controls.Add(this.txtPaso);
            this.Controls.Add(this.lblEt2);
            this.Controls.Add(this.txtHasta);
            this.Controls.Add(this.txtDesde);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.lblRess);
            this.Controls.Add(this.lblEt1);
            this.Name = "FrmContador";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEt1;
        private System.Windows.Forms.Label lblRess;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label lblEt2;
        private System.Windows.Forms.TextBox txtPaso;
        private System.Windows.Forms.Label lblEt3;
    }
}

