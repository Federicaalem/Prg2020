using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd//Codigo
{
    public class FacturaC
    {
        #region PROPIEDADES DE CODIGO

        //NUEVA FACTURA

        public DateTime Fecha;

        public string NumeroFactura = "";
        public string Cliente = "";
        public string CUIT = "";

        public decimal Neto = 0;
        public decimal Iva = 0;
        public decimal Total = 0;

        public RNGFactura[] ListaRngFactura = new RNGFactura[10];
        
        //El que me permite incorporar un elemento nuevo
        private int ContadorI = 0;

        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// CONSTRUCTOR de objeto de clase Factura
        /// </summary>
        public FacturaC()//mismo NMB que la clase
        {
            //inicializa
            //New fecha, maquina.
            Fecha = DateTime.Now;
        }
        #endregion

        #region METODOS

        public void AddRenglon(RNGFactura rngFacturaObj)
        {
            //TODO: Controlar error de exceso de arreglo.
            ListaRngFactura[ContadorI] = rngFacturaObj;
            ContadorI = ContadorI + 1;
            
            //Cada vez que se agregue un rng calculara
            CalculaPieF();//Calculos
        }

        public string MuestraRenglones()
        {
            string RenglonesTxt = "";

            for (int i = 0; i < ContadorI; i++)
            {
                RenglonesTxt = RenglonesTxt + ListaRngFactura[i].MuestraRenglon() + "\r\n";
            }

            return RenglonesTxt;
        }

        private void CalculaPieF()
        {
            decimal ResNeto = 0;
            for (int i = 0; i < ContadorI; i++)
            {           
                ResNeto = ResNeto + ListaRngFactura[i].TOTALRng();
            }
            this.Neto= ResNeto;

            Iva = Neto * 0.21M;
            Total = Neto + Iva;
        }

        //public void TotalFinal()
        //{
        //    for (int i = 0; i < RN.ListaRngFactura; i++)
        //    {

        //    }
        //    Iva = System.Convert.ToDecimal(lblIva.Text);
        //    Neto = System.Convert.ToDecimal(lblNeto.Text);
        //    Total = System.Convert.ToDecimal(lblTotal.Text);

        //    Iva = System.Convert.ToDecimal(txtTotalRNG.Text) * 21;
        //    Total = Neto + Iva;
        //}
        #endregion
    }

}
