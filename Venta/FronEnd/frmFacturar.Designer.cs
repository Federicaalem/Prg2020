namespace FronEnd
{
    partial class frmFacturar
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
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtNumeroF = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNueva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.panelRenglones = new System.Windows.Forms.Panel();
            this.lblRenglones = new System.Windows.Forms.Label();
            this.txtTotalRNG = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrUnitario = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtCantidadP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCargarProduc = new System.Windows.Forms.Button();
            this.panelPie = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBruto = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblErrorEncabezado = new System.Windows.Forms.Label();
            this.panelEncabezado.SuspendLayout();
            this.panelRenglones.SuspendLayout();
            this.panelPie.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEncabezado.Controls.Add(this.lblErrorEncabezado);
            this.panelEncabezado.Controls.Add(this.btnConfirmar);
            this.panelEncabezado.Controls.Add(this.txtCliente);
            this.panelEncabezado.Controls.Add(this.txtFecha);
            this.panelEncabezado.Controls.Add(this.txtNumeroF);
            this.panelEncabezado.Controls.Add(this.label6);
            this.panelEncabezado.Controls.Add(this.label5);
            this.panelEncabezado.Controls.Add(this.label2);
            this.panelEncabezado.Controls.Add(this.btnNueva);
            this.panelEncabezado.Controls.Add(this.label1);
            this.panelEncabezado.Controls.Add(this.txtCuit);
            this.panelEncabezado.Location = new System.Drawing.Point(12, 12);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(807, 110);
            this.panelEncabezado.TabIndex = 0;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(70, 47);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(210, 20);
            this.txtCliente.TabIndex = 12;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(657, 50);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(136, 20);
            this.txtFecha.TabIndex = 10;
            // 
            // txtNumeroF
            // 
            this.txtNumeroF.Location = new System.Drawing.Point(657, 6);
            this.txtNumeroF.Name = "txtNumeroF";
            this.txtNumeroF.Size = new System.Drawing.Size(138, 20);
            this.txtNumeroF.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "CUIT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha";
            // 
            // btnNueva
            // 
            this.btnNueva.Location = new System.Drawing.Point(16, 4);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(112, 23);
            this.btnNueva.TabIndex = 3;
            this.btnNueva.Text = "Nueva Factura";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "N° Factura";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(343, 47);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(139, 20);
            this.txtCuit.TabIndex = 0;
            // 
            // panelRenglones
            // 
            this.panelRenglones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRenglones.Controls.Add(this.lblRenglones);
            this.panelRenglones.Controls.Add(this.txtTotalRNG);
            this.panelRenglones.Controls.Add(this.label8);
            this.panelRenglones.Controls.Add(this.label7);
            this.panelRenglones.Controls.Add(this.label4);
            this.panelRenglones.Controls.Add(this.txtPrUnitario);
            this.panelRenglones.Controls.Add(this.textBox7);
            this.panelRenglones.Controls.Add(this.txtCantidadP);
            this.panelRenglones.Controls.Add(this.label3);
            this.panelRenglones.Controls.Add(this.btnCargarProduc);
            this.panelRenglones.Enabled = false;
            this.panelRenglones.Location = new System.Drawing.Point(13, 128);
            this.panelRenglones.Name = "panelRenglones";
            this.panelRenglones.Size = new System.Drawing.Size(807, 227);
            this.panelRenglones.TabIndex = 1;
            // 
            // lblRenglones
            // 
            this.lblRenglones.AutoSize = true;
            this.lblRenglones.Location = new System.Drawing.Point(28, 70);
            this.lblRenglones.Name = "lblRenglones";
            this.lblRenglones.Size = new System.Drawing.Size(0, 13);
            this.lblRenglones.TabIndex = 20;
            // 
            // txtTotalRNG
            // 
            this.txtTotalRNG.Location = new System.Drawing.Point(692, 33);
            this.txtTotalRNG.Name = "txtTotalRNG";
            this.txtTotalRNG.ReadOnly = true;
            this.txtTotalRNG.Size = new System.Drawing.Size(100, 20);
            this.txtTotalRNG.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(689, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "$ Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "$ Unitarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Producto";
            // 
            // txtPrUnitario
            // 
            this.txtPrUnitario.Location = new System.Drawing.Point(551, 33);
            this.txtPrUnitario.Name = "txtPrUnitario";
            this.txtPrUnitario.Size = new System.Drawing.Size(100, 20);
            this.txtPrUnitario.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(188, 33);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(324, 20);
            this.textBox7.TabIndex = 14;
            // 
            // txtCantidadP
            // 
            this.txtCantidadP.Location = new System.Drawing.Point(27, 33);
            this.txtCantidadP.Name = "txtCantidadP";
            this.txtCantidadP.Size = new System.Drawing.Size(127, 20);
            this.txtCantidadP.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cantidad de productos";
            // 
            // btnCargarProduc
            // 
            this.btnCargarProduc.Location = new System.Drawing.Point(692, 65);
            this.btnCargarProduc.Name = "btnCargarProduc";
            this.btnCargarProduc.Size = new System.Drawing.Size(102, 23);
            this.btnCargarProduc.TabIndex = 1;
            this.btnCargarProduc.Text = "Cargar Producto";
            this.btnCargarProduc.UseVisualStyleBackColor = true;
            // 
            // panelPie
            // 
            this.panelPie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPie.Controls.Add(this.lblTotal);
            this.panelPie.Controls.Add(this.lblIva);
            this.panelPie.Controls.Add(this.lblBruto);
            this.panelPie.Controls.Add(this.label11);
            this.panelPie.Controls.Add(this.label10);
            this.panelPie.Controls.Add(this.label9);
            this.panelPie.Location = new System.Drawing.Point(13, 361);
            this.panelPie.Name = "panelPie";
            this.panelPie.Size = new System.Drawing.Size(807, 111);
            this.panelPie.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(629, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "TOTAL";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(631, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "IVA";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(629, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "BRUTO";
            // 
            // lblBruto
            // 
            this.lblBruto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBruto.Location = new System.Drawing.Point(692, 3);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(100, 23);
            this.lblBruto.TabIndex = 6;
            this.lblBruto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblIva
            // 
            this.lblIva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(692, 41);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(100, 23);
            this.lblIva.TabIndex = 7;
            this.lblIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(692, 76);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(669, 82);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(115, 23);
            this.btnConfirmar.TabIndex = 21;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblErrorEncabezado
            // 
            this.lblErrorEncabezado.AutoSize = true;
            this.lblErrorEncabezado.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEncabezado.Location = new System.Drawing.Point(23, 82);
            this.lblErrorEncabezado.Name = "lblErrorEncabezado";
            this.lblErrorEncabezado.Size = new System.Drawing.Size(0, 13);
            this.lblErrorEncabezado.TabIndex = 22;
            // 
            // frmFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 484);
            this.Controls.Add(this.panelPie);
            this.Controls.Add(this.panelRenglones);
            this.Controls.Add(this.panelEncabezado);
            this.Name = "frmFacturar";
            this.Text = "Form1";
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panelRenglones.ResumeLayout(false);
            this.panelRenglones.PerformLayout();
            this.panelPie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtNumeroF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarProduc;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Panel panelRenglones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelPie;
        private System.Windows.Forms.TextBox txtPrUnitario;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtCantidadP;
        private System.Windows.Forms.TextBox txtTotalRNG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRenglones;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblBruto;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblErrorEncabezado;
    }
}

