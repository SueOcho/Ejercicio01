namespace Evaluacion01_Estructuras
{
    partial class frmArreglos1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.lblIguales = new System.Windows.Forms.Label();
            this.lblMenores = new System.Windows.Forms.Label();
            this.lblMayores = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(328, 12);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(163, 212);
            this.lstNumeros.TabIndex = 16;
            // 
            // lblIguales
            // 
            this.lblIguales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIguales.Location = new System.Drawing.Point(192, 199);
            this.lblIguales.Name = "lblIguales";
            this.lblIguales.Size = new System.Drawing.Size(66, 21);
            this.lblIguales.TabIndex = 13;
            // 
            // lblMenores
            // 
            this.lblMenores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMenores.Location = new System.Drawing.Point(192, 164);
            this.lblMenores.Name = "lblMenores";
            this.lblMenores.Size = new System.Drawing.Size(66, 21);
            this.lblMenores.TabIndex = 14;
            // 
            // lblMayores
            // 
            this.lblMayores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMayores.Location = new System.Drawing.Point(192, 131);
            this.lblMayores.Name = "lblMayores";
            this.lblMayores.Size = new System.Drawing.Size(66, 21);
            this.lblMayores.TabIndex = 15;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(121, 74);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(49, 20);
            this.txtBuscar.TabIndex = 12;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(52, 199);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(103, 13);
            this.Label4.TabIndex = 11;
            this.Label4.Text = "Iguales que el Valor:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(52, 164);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(110, 13);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Menores que el Valor:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(52, 131);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(109, 13);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Mayores que el Valor:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(26, 76);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 13);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Ingrese Valor:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(204, 71);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(112, 24);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmArreglos1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 245);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.lblIguales);
            this.Controls.Add(this.lblMenores);
            this.Controls.Add(this.lblMayores);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGenerar);
            this.Name = "frmArreglos1";
            this.Text = "Ejemplo Arreglos 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox lstNumeros;
        internal System.Windows.Forms.Label lblIguales;
        internal System.Windows.Forms.Label lblMenores;
        internal System.Windows.Forms.Label lblMayores;
        internal System.Windows.Forms.TextBox txtBuscar;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.Button btnGenerar;
    }
}