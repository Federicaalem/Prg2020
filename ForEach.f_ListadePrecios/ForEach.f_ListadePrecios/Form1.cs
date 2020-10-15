using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForEach.f_ListadePrecios
{
    public partial class frmListaPrecio : Form
    {
        //Definir propiedades del Arreglo

        private string[,] Producto = new string[3, 2];
        private decimal[] Precio = new decimal[3];

        private int Fila = 0;
        public frmListaPrecio()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (Fila > 2)
            {
                lblListaPrecios.Text = "Solo se aceptan 3 productos";

            }

            else
            {

                //Dos arreglos. Porque uno es tipo string y otro decimal.

                Producto[Fila, 0] = txtCódigo.Text;
                Producto[Fila, 1] = txtProducto.Text;

                //No ponemos la columna, ya que solo tiene una (0)
                Precio[Fila] = System.Convert.ToDecimal(txtPrecio.Text);
                
                //Cuando vuelva de nuevo, se cargara la fila 2(1)
                
                 Fila = Fila + 1;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lblListaPrecios.Text = "LISTA DE PRECIOS\r\n";

            for (int i = 0; i < Precio.Length; i++)
            {
                //Linea 36 y 37
                lblListaPrecios.Text = lblListaPrecios.Text
                                       + Producto[i, 0]
                                       + " - " + Producto[i, 1]
                                       + " - " + System.Convert.ToInt32(Precio[i])
                                       + "\r\n";
            }

        }


    }
}
