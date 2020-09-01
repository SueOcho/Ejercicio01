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
    public partial class frmDatos : Form
    {
        public frmDatos()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           
            foreach (Control c in this.Controls)
            {
	            if (c is TextBox)
                {
                   c.Text = string.Empty;
                 }
           }
            btnGrabar.Enabled = false;
            txtCod.Focus();
        }

        private void frmDatos_KeyUp(object sender, KeyEventArgs e)
        {
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        if (c.Text == string.Empty)
                        {
                            btnGrabar.Enabled = false;
                            return;
                        }
                    }
                }
                btnGrabar.Enabled = true;
            }
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // No fue BackSpace
            if (e.KeyChar != 8)
            {
                if (char.IsDigit(e.KeyChar) == false)
                {
                    // Ni tampoco numero se atrapa el caracter y no  se imprime
                    e.Handled = true;
                }
            }
        }

        private void txtRUC_Validating(object sender, CancelEventArgs e)
        {
            if (txtRUC.Text.Trim().Length != 11 & txtRUC.Text.Trim().Length != 0)
            {
                //Se Cancela el ingreso
                e.Cancel = true;
                MessageBox.Show("El RUC consta de 11 digitos", "Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRUC.SelectAll();
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            // tras grabar en la bd respectiva
            btnLimpiar.PerformClick();
            txtCod.Focus();
        }

        private void txtRUC_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                TextBox txt = sender as TextBox;
                txt.CausesValidation = false;
                this.Close();
            }
        }

        private void txtRUC_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Accion Invalida");
                
            }
        }

      

     
    }
}
