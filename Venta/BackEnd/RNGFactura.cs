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
        #endregion
    }
}
