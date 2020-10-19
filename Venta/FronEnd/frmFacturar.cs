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

        FacturaC facturaObj;

        public frmFacturar()
        {
            InitializeComponent();
        }

         # region METODOS


        private void btnNueva_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            NuevaFactura();
            lblBruto.Text = "10,05";
        }
        private void LimpiarControles()
        {
            
            txtCliente.Text = "";
            txtCuit.Text = "";
            txtFecha.Text = "";            
            txtNumeroF.Text = "";            
            lblBruto.Text = "";
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            LimpiarBlancoEncab();
            //Validar datos
            //TxtCliente ya viene en blanco. 
            if (txtCliente.Text.Trim () =="" || txtNumeroF.Text == "" || txtCuit.Text =="")
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
   
        private void LimpiarBlancoEncab()
        {
            txtCliente.Text = txtCliente.Text.Trim();
            txtNumeroF.Text = txtCliente.Text.Trim();
            txtCuit.Text = txtCliente.Text.Trim();

        }
        #endregion
    }
}
