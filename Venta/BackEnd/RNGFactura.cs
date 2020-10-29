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
        public int Cantidad = 0;
        public string Producto = "";
        public decimal precioUnitario = 0;
        #endregion

        #region CONSTRUCTOR

        #endregion

        #region METODOS
        public decimal TOTALRng() 
        {
            return Cantidad * precioUnitario;
        }

        public string MuestraRenglon()
        {            
            return Cantidad + " - "
                + Producto + "  "
                + precioUnitario.ToString(" c/u $" + "#,##0.00")
                + "  "
                + TOTALRng().ToString("T $" + "#,##0.00");

        }



        

        #endregion
    }
}
