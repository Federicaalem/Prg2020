using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploFOR.F
{
    public partial class FrmContador : Form
    {
        public FrmContador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = System.Convert.ToInt32(txtDesde.Text);
                 i <= System.Convert.ToInt32(txtHasta.Text);//menor/= que hasta.
                 i = i + System.Convert.ToInt32(txtPaso.Text)) //Sumar de cuanto paso.
            {
                lblRess.Text = i.ToString();
                this.Refresh();

            }
        }
    }
}
