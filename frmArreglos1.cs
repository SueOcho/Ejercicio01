using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Evaluacion01_Estructuras
{
    public partial class frmArreglos1 : Form
    {
        //Se declara la instancia  objRandom de la clase random que permite generar numeros aleatorios
        Random objRandom = new Random();
        //matriz de numeros enteros
        int[] intNumeros = new int[100];
       

        public frmArreglos1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
           //Generamos los 100 numeros....
           for(short intValor = 0; intValor < 100; intValor++)
            {
                intNumeros[intValor] = objRandom.Next(100, 1001);
            }
            //Mostramos en la lista los valores generados
            lstNumeros.DataSource = null;//se limpia la lista
            lstNumeros.DataSource = intNumeros;//Se enalaza la lista a la matriz intNumeros
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int intBuscar = Convert.ToInt16(txtBuscar.Text);
                int intMenores = 0;
                int intMayores = 0;
                int intIguales = 0;
                //Empezamos la busqueda
                for (short intZ = 0; intZ < 100; intZ++)
                {
                    if (intNumeros[intZ] < intBuscar)
                    {
                        intMenores++;
                    }
                    if (intNumeros[intZ] > intBuscar)
                    {
                        intMayores++;
                    }
                    if (intNumeros[intZ] == intBuscar)
                    {
                        intIguales++;
                    }
                }
                //Mostramos Resultados
                lblMenores.Text = intMenores.ToString();
                lblMayores.Text = intMayores.ToString();
                lblIguales.Text = intIguales.ToString();

            }
            catch(Exception ex)
            {
               MessageBox.Show("Que fue loco ,pone bien los datos pes");
            }

        }
    }
}
