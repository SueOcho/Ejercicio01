namespace Evaluacion01_Estructuras
{
    partial class frmCondicional1
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
            this.btnCalcularComision3 = new System.Windows.Forms.Button();
            this.btnCalcularComision2 = new System.Windows.Forms.Button();
            this.btnCalcularComision1 = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLinea = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCalcularComision3
            // 
            this.btnCalcularComision3.Location = new System.Drawing.Point(83, 235);
            this.btnCalcularComision3.Name = "btnCalcularComision3";
            this.btnCalcularComision3.Size = new System.Drawing.Size(134, 23);
            this.btnCalcularComision3.TabIndex = 5;
            this.btnCalcularComision3.Text = "Calcular Comsion &3";
            this.btnCalcularComision3.UseVisualStyleBackColor = true;
            this.btnCalcularComision3.Click += new System.EventHandler(this.btnCalcularComision3_Click);
            // 
            // btnCalcularComision2
            // 
            this.btnCalcularComision2.Location = new System.Drawing.Point(83, 117);
            this.btnCalcularComision2.Name = "btnCalcularComision2";
            this.btnCalcularComision2.Size = new System.Drawing.Size(134, 23);
            this.btnCalcularComision2.TabIndex = 6;
            this.btnCalcularComision2.Text = "Calcular Comision &2";
            this.btnCalcularComision2.UseVisualStyleBackColor = true;
            this.btnCalcularComision2.Click += new System.EventHandler(this.btnCalcularComision2_Click);
            // 
            // btnCalcularComision1
            // 
            this.btnCalcularComision1.Location = new System.Drawing.Point(83, 75);
            this.btnCalcularComision1.Name = "btnCalcularComision1";
            this.btnCalcularComision1.Size = new System.Drawing.Size(134, 23);
            this.btnCalcularComision1.TabIndex = 7;
            this.btnCalcularComision1.Text = "Calcular Comsion &1";
            this.btnCalcularComision1.UseVisualStyleBackColor = true;
            this.btnCalcularComision1.Click += new System.EventHandler(this.btnCalcularComision1_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(132, 22);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 20);
            this.txtMonto.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(32, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(77, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Ingrese monto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese Linea:";
            // 
            // cboLinea
            // 
            this.cboLinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLinea.FormattingEnabled = true;
            this.cboLinea.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cboLinea.Location = new System.Drawing.Point(132, 177);
            this.cboLinea.Name = "cboLinea";
            this.cboLinea.Size = new System.Drawing.Size(100, 21);
            this.cboLinea.TabIndex = 8;
            // 
            // frmCondicional1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 315);
            this.Controls.Add(this.cboLinea);
            this.Controls.Add(this.btnCalcularComision3);
            this.Controls.Add(this.btnCalcularComision2);
            this.Controls.Add(this.btnCalcularComision1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Name = "frmCondicional1";
            this.Text = "Ejemplo Condicional 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCalcularComision3;
        internal System.Windows.Forms.Button btnCalcularComision2;
        internal System.Windows.Forms.Button btnCalcularComision1;
        internal System.Windows.Forms.TextBox txtMonto;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLinea;
    }
}