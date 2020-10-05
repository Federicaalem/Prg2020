using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjWhile.F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArrancar_Click(object sender, EventArgs e)
        {
            Random Aleatorio = new Random();

            int anchoForm1;
            int anchoLabel;
            int anchoBorde;
            int paso;
            int X;
            int Repeticion = 0;//las veces que repite.
            //COMPARA.
            int totalRepeticiones = 4;//las veces que QUIERO repetir.

            //Inicializamos las variable para q cuando vuelva a arrancar, el LABEL vuelva a su
            //estado de original.
            LblEt.Width = 51;
            LblEt.Height = 19;
            Lbl2.Width = 51;
            Lbl2.Height = 19;

            //----Propiedades de configuracion----
            do
            {
                int contador = 0;
                contador = Repeticion + 1;//muestra con un contador
                Repeticion = Repeticion + 1;//compara
                anchoForm1 = this.Width; //Es igual al ancho de este form.
                anchoLabel = LblEt.Width;
                anchoLabel = Lbl2.Width;
                anchoBorde = 15;
                paso = 1;
                X = 0;
               
                while (X < (anchoForm1 - anchoLabel - anchoBorde))
                {
                    LblEt.Left = X;//propiedad left, mueve hacia la izquierda
                    
                    this.Refresh();//permite ver el movimiento
                    X = X + paso;
                }

                while (X > (anchoForm1 - anchoLabel - anchoBorde))
                {
                    Lbl2.Left = X;
                    this.Refresh();
                    X = X + paso;
                }
                


                lblContador.Text = System.Convert.ToString(contador);

                LblEt.Width = Aleatorio.Next(20, 200);
                LblEt.Height = Aleatorio.Next(2, 300);
                Lbl2.Width = Aleatorio.Next(20, 200);
                Lbl2.Height = Aleatorio.Next(2, 300);
                paso = Aleatorio.Next(1, 200);//velocidad

                //LblEt.Height = LblEt.Height * 2; //Se va haciendo mas alto
                //LblEt.Width = System.Convert.ToInt32(0.7 * LblEt.Width); //Se va achicando

            } while (Repeticion < totalRepeticiones);

        }
    }
}
