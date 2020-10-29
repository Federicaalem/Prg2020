using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumador.f
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Sumar objSuma = new Sumar();
            objSuma.Sumando1 = 10;
            objSuma.Sumando2 = 20;

            Sumar otraSuma = new Sumar();

            //    int Sumando1 = System.Convert.ToInt32(txtSumando1.Text);
            //    int Sumando2 = System.Convert.ToInt32(txtSumando2.Text);

            //    int Resultado = Sumando1 + Sumando2;
            //    txtResultado.Text = System.Convert.ToString(Resultado);
        }
    }
}
