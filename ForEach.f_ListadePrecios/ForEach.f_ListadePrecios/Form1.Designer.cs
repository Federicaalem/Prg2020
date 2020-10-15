namespace ForEach.f_ListadePrecios
{
    partial class frmListaPrecio
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
            this.txtCódigo = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblListaPrecios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCódigo
            // 
            this.txtCódigo.Location = new System.Drawing.Point(22, 51);
            this.txtCódigo.Name = "txtCódigo";
            this.txtCódigo.Size = new System.Drawing.Size(64, 20);
            this.txtCódigo.TabIndex = 0;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(92, 51);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(172, 20);
            this.txtProducto.TabIndex = 1;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(288, 51);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(429, 48);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(529, 48);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(88, 23);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(19, 35);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(40, 13);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio";
            // 
            // lblListaPrecios
            // 
            this.lblListaPrecios.AutoSize = true;
            this.lblListaPrecios.Location = new System.Drawing.Point(19, 88);
            this.lblListaPrecios.Name = "lblListaPrecios";
            this.lblListaPrecios.Size = new System.Drawing.Size(81, 13);
            this.lblListaPrecios.TabIndex = 8;
            this.lblListaPrecios.Text = "Lista de precios";
            // 
            // frmListaPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.lblListaPrecios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtCódigo);
            this.Name = "frmListaPrecio";
            this.Text = "Lista de precios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCódigo;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblListaPrecios;
    }
}

