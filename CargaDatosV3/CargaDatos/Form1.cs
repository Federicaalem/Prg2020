﻿using Lib._1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargaDatos
{
    public partial class frmInicio : Form//FRONEND
    {
        //private string[] Nombres = new string[1];
        //private string[] Apellidos = new string[1];

        //objeto de Clase Lista
        private Lista nombres = new Lista();
        private Lista apellidos = new Lista();


        //int Indice = 0;

        public frmInicio()
        {
            InitializeComponent();
            //ListaDeNombres.Redimension();
            //ListaDeApellidos.Redimension();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            nombres.CargaDatos(txtApellido.Text);
            apellidos.CargaDatos(txtNombre.Text);
                        
            //if (Indice < Nombres.Length)
            //{
            //    //CargaDatos();

            //}
            //else
            //{
            //    //actualizo la dimensión de Nombres
            //    Nombres = Redimension(Nombres);


            //    Apellidos = Redimension(Apellidos);

            //    // CargaDatos();            
            //}
            lblSalida.Text = lblSalida.Text + "\r\n" + txtNombre.Text + " " + txtApellido.Text;
          
            txtNombre.Focus();
            txtNombre.SelectAll();
        }

        //private void CargaDatos()
        //{
        //    Nombres[Indice] = txtNombre.Text;
        //    Apellidos[Indice] = txtApellido.Text;
        //    Indice = Indice + 1;        
        //}
    }

    //public class Lista
    //{
    //    public string[] Redimension(string[] Dato)
    //    {
    //        string[] temp = new string[Dato.Length + 1];
    //        for (int i = 0; i < Dato.Length; i++)
    //        {
    //            temp[i] = Dato[i];
    //        }
    //        Dato = temp;

    //        return Dato;
    //    }

    //    public string[] OrdenarAlfabeticamente()
    //    {
    //        return new string[1];
    //    }

    //    public string Listar()
    //    {
    //    }

    //    public string[] agregar()
    //    {

    //    }
    //}
}
