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

        public void AddRenglon(RNGFactura renglon)
        {
            //TODO: Controlar error de exceso de arreglo.
            ListaRngFactura[ContadorI] = renglon;
            ContadorI = ContadorI + 1;
        }
        #endregion
    }

}
