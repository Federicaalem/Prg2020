using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class RNGFactura
    {
        #region PROPIEDADES
        public decimal Cantidad = 0;
        public string Producto = "";
        public decimal precioUnitario = 0;
        #endregion

        #region CONSTRUCTOR

        #endregion

        #region METODOS
        public decimal TOTAL() 
        {
            return Cantidad * precioUnitario;
        }

        public string MuestraRenglon()
        {
            return Cantidad.ToString("#,##0.00") + " - "
                + Producto + "  "
                + precioUnitario.ToString("#,##0.00")
                + "  "
                + TOTAL().ToString("#,##0.00");
        }
       
        #endregion
    }
}
