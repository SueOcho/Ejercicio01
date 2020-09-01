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
    public partial class frmForNext : Form
    {
        public frmForNext()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           int intValor = Convert.ToInt32(txtValor.Text);
            bool blnEsPrimo = true;
            for (int lngx = 1; lngx <= intValor; lngx++)
            {
                if (lngx != 1 & lngx != intValor)
                {
                    if (intValor % lngx == 0)
                    {
                        blnEsPrimo = false;
                        break; 
                    }
                }
            }
            if (blnEsPrimo == true)
            {
                MessageBox.Show("El valor es primo");
            }
            else
            {
                MessageBox.Show("El valor NO es primo");
            }

        }
    }
}
