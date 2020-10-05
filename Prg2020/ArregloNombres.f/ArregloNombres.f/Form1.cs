using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArregloNombres.f
{
    public partial class frmNombres : Form
    {

        // string[] Lista = new string[3];
        string[] Lista;
        int Posicion = 0;

        public frmNombres()//Constructor
        {
            InitializeComponent();
            btnIngresar.Enabled = false;
            btnListar.Enabled = false;

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Cada click se agragara a la lista y aumentara posicion, despues de haber puesto
           // el nombre en el textBox. 

            Lista[Posicion] = txtNombre.Text;
            Posicion = Posicion + 1;

            //En el lbl va a mostrarse el valor que tenia Lbl anteriormente
            //, mas el nombre q se agrega, mas un salto de renglon.
            
            txtNombre.Text = "";
            txtNombre.Focus();//El cursor se me vuelva a poner en el textBox

           
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //Longitud del arreglo Lista
            for ( int i = 0; i < Lista.Length; i++)
            {
                lblLista.Text = lblLista.Text + Lista[i] + "\r\n";
            }
        }

        private void btnDimensional_Click(object sender, EventArgs e)
       
          //Dimensionamos desde aqui
        {
            Lista = new string[System.Convert.ToInt32(txtCantidad.Text)];
            Posicion = 0;//Redimensionar
            btnIngresar.Enabled = true;
            btnListar.Enabled = true;
        }
    }
}
