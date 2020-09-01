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
    public partial class frmDoWhile : Form
    {
        public frmDoWhile()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            int valor = 0;
            int valoringresado = 0;
            Random intAleatorio = new Random();
            valoringresado = Convert.ToInt32(txtValor.Text);
            valor = intAleatorio.Next(1, valoringresado + 1);
            MessageBox.Show("Salio : " + valor );
            while (!(valor == 1 | valor == valoringresado))
            {
                valor = intAleatorio.Next(1, valoringresado + 1);
                MessageBox.Show("Salio : " + valor);
            }
            if (valor == 1)
            {
                MessageBox.Show("Lo siento...perdio");
            }
            else if (valor == valoringresado)
            {
                MessageBox.Show("Felicitaciones, gano el premio");
            }

        }

       
    }
}
