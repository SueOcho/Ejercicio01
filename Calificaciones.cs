using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion01_Estructuras
{
    public partial class Calificaciones : Form
    {
        //Creo el objeto random
        Random objRandom = new Random();
        //Creo el vector  para guardar las 100 calificaciones
        int [] calificaciones= new int[100];
        //variables para calcular el %
        int aprobados;
        int desaprobados;

        public Calificaciones()
        {
            InitializeComponent();
        }

        private void btnGnerar_Click(object sender, EventArgs e)
        {
            //Ocultamos los elementos ingresados anteriormente
            lstAprobados.Items.Clear();
            lstDesaprobados.Items.Clear();

            //Reiniciamoms los contadores
            desaprobados = aprobados = 0; 

            //Generamos los 100 numeros
            for (short calificacion = 0; calificacion < 100; calificacion++)
            {
                calificaciones[calificacion] = objRandom.Next(0, 21);
            }

            //mostramos en la lista los valores en cada tabla(aprobados y desaprobados) y su determinamos su cantidad
            for(short intZ = 0; intZ < 100; intZ++)
            {
                if (calificaciones[intZ]>12.5)
                {
                    lstAprobados.Items.Add(calificaciones[intZ]);
                    aprobados++;  
                }
                if (calificaciones[intZ] < 12.5)
                {
                    lstDesaprobados.Items.Add(calificaciones[intZ]);
                    desaprobados++;
                }     
            }

            //mostramos el procentaje
            lblAprobados.Text = aprobados.ToString() + " %";
            lblDesaprobados.Text = desaprobados.ToString() + " %";
        }
    }
}
