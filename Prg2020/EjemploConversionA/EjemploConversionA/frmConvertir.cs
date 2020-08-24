using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploConversionA
{
    public partial class frmConvertir : Form
    {
        public frmConvertir()
        {
            InitializeComponent();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            decimal Operador1 = System.Convert.ToDecimal(txtOper1.Text);//framework de .Net
            decimal Operador2 = System.Convert.ToDecimal(txtOper2.Text);

            decimal res = Operador1 + Operador2;

            lblResultado.Text = System.Convert.ToString(res);

        }
    }
}
