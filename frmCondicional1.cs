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
    public partial class frmCondicional1 : Form
    {
        Single sngMonto = 0;
        Single sngComision1 = 0;
        Single sngComision2 = 0;
        Single sngComision3 = 0;
                public frmCondicional1()
        {
            InitializeComponent();
        }

                private void btnCalcularComision1_Click(object sender, EventArgs e)
                {
                    sngMonto = Convert.ToSingle(txtMonto.Text);
                    if (sngMonto <= 500)
                    {
                        sngComision1 = sngMonto * 0.1f;
                    }
                    else
                    {
                        sngComision1 = sngMonto * 0.2f;
                    }
                    MessageBox.Show("La Comision 1 sera de... " + sngComision1);


                }

                private void btnCalcularComision2_Click(object sender, EventArgs e)
                {
                    sngMonto = Convert.ToSingle(txtMonto.Text);
                    if (sngMonto <= 350)
                    {
                        sngComision2 = sngMonto * 0.08f;
                    }
                    else if (sngMonto <= 1000)
                    {
                        sngComision2 = sngMonto * 0.12f;
                    }
                    else if (sngMonto <= 1500)
                    {
                        sngComision2 = sngMonto * 0.18f;
                    }
                    else
                    {
                        sngComision2 = sngMonto * 0.2f;
                    }
                    MessageBox.Show("La Comision 2 sera de... " + sngComision2);
                }

                private void btnCalcularComision3_Click(object sender, EventArgs e)
                {
                    
                    // Si desea emplear la estructura Switch el valor a evaluar 
                    // debe ser integer  o char
                    sngMonto = Convert.ToSingle(txtMonto.Text);
                    switch (cboLinea.SelectedItem.ToString () )
                    {
                        case "A": 
                            sngComision3 = sngMonto * 0.08f;
                            break;
                        case "B": 
                            sngComision3 = sngMonto * 0.12f;
                            break;
                        case "C": 
                            sngComision3 = sngMonto * 0.18f;
                            break;
                        default:
                            sngComision3 = sngMonto * 0.2f;
                            break;
                    }
                    MessageBox.Show("La Comision 3 sera de... " + sngComision3);

                }

    }
}
