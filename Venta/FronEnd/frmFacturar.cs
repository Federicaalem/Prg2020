using BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FronEnd //Formulario
{
    public partial class frmFacturar : Form
    {
        //Objeto tipo factura(clase)//Backend

        //Instanciamos los Obj
        #region PROPIEDADES
        FacturaC facturaObj;
        RNGFactura rngFacturaObj;
        #endregion

        #region CONSTRUCTOR
        public frmFacturar()
        {
            InitializeComponent();
        }
        #endregion
       
        #region EVENTOS
        private void btnNueva_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            NuevaFactura();
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            LimpiarBlancoEncab();
            //Validar datos
            //TxtCliente ya viene en blanco. 
            if (txtCliente.Text.Trim() == "" || txtNumeroF.Text == "" || txtCuit.Text == "")
            {
                lblErrorEncabezado.Text = "Faltan datos de encabezado";
                txtNumeroF.Focus();
            }
            else
            {
                //Propiedades de encabezado
                //Nueva factura
                facturaObj.NumeroFactura = txtNumeroF.Text;
                facturaObj.Cliente = txtCliente.Text;
                facturaObj.CUIT = txtCuit.Text;
                facturaObj.Fecha = System.Convert.ToDateTime(txtFecha.Text);

                //Se habilitará panel Renglones cuando aprete confirmar
                //Llenar las propiedades del encabezado
                lblErrorEncabezado.Text = "";
                panelRenglones.Enabled = true;
                txtCantidadP.Focus();
            }


        }

        private void btnNuevoRNG_Click(object sender, EventArgs e)
        {
            //Inicializamos el Obj
            rngFacturaObj = new RNGFactura();
            //Asignamos Valores
            rngFacturaObj.Cantidad = System.Convert.ToInt32(txtCantidadP.Text);
            rngFacturaObj.Producto = txtProducto.Text;
            rngFacturaObj.precioUnitario = System.Convert.ToDecimal(txtPrUnitario.Text);

            // txtTotalRNG.Text = System.Convert.ToString(rngFacturaObj.TOTAL());
            txtTotalRNG.Text = rngFacturaObj.TOTALRng().ToString("#,##0.00");

            facturaObj.AddRenglon(rngFacturaObj);
                        
            lblRenglones.Text = facturaObj.MuestraRenglones();//lista

          

            //Muestre los calculos
            lblNeto.Text= facturaObj.Neto.ToString();
            lblIva.Text = facturaObj.Iva.ToString();
            lblTotal.Text = facturaObj.Total.ToString();
        }
        #endregion

        #region METODOS
        private void LimpiarControles()
        {
            
            txtCliente.Text = "";
            txtCuit.Text = "";
            txtFecha.Text = "";            
            txtNumeroF.Text = "";            
            lblNeto.Text = "";
            lblIva.Text = "";
            lblTotal.Text = "";

            //El panel se habilitara cuando los datos esten cargados
            //en el panel Encabezado.
            panelRenglones.Enabled = false;
        }

        private void NuevaFactura()
        {
            //Inicializa
            facturaObj = new FacturaC();
            txtFecha.Text = facturaObj.Fecha.ToString("dd/MM/yyyy");

            txtNumeroF.Focus(); 
        }

        private void LimpiarBlancoEncab()
        {
            txtCliente.Text = txtCliente.Text.Trim();
            txtNumeroF.Text = txtCliente.Text.Trim();
            txtCuit.Text = txtCliente.Text.Trim();

        }

        

        #endregion
        
    }
}
