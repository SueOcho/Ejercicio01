namespace Evaluacion01_Estructuras
{
    partial class Calificaciones
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
            this.btnGnerar = new System.Windows.Forms.Button();
            this.lstAprobados = new System.Windows.Forms.ListBox();
            this.lstDesaprobados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAprobados = new System.Windows.Forms.TextBox();
            this.lblDesaprobados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGnerar
            // 
            this.btnGnerar.Location = new System.Drawing.Point(26, 24);
            this.btnGnerar.Name = "btnGnerar";
            this.btnGnerar.Size = new System.Drawing.Size(88, 23);
            this.btnGnerar.TabIndex = 0;
            this.btnGnerar.Text = "Generar Notas";
            this.btnGnerar.UseVisualStyleBackColor = true;
            this.btnGnerar.Click += new System.EventHandler(this.btnGnerar_Click);
            // 
            // lstAprobados
            // 
            this.lstAprobados.FormattingEnabled = true;
            this.lstAprobados.Location = new System.Drawing.Point(26, 66);
            this.lstAprobados.Name = "lstAprobados";
            this.lstAprobados.Size = new System.Drawing.Size(120, 160);
            this.lstAprobados.TabIndex = 1;
            // 
            // lstDesaprobados
            // 
            this.lstDesaprobados.FormattingEnabled = true;
            this.lstDesaprobados.Location = new System.Drawing.Point(163, 66);
            this.lstDesaprobados.Name = "lstDesaprobados";
            this.lstDesaprobados.Size = new System.Drawing.Size(120, 160);
            this.lstDesaprobados.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "% Desaprobados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "% Aprobados";
            // 
            // lblAprobados
            // 
            this.lblAprobados.Location = new System.Drawing.Point(393, 161);
            this.lblAprobados.Name = "lblAprobados";
            this.lblAprobados.Size = new System.Drawing.Size(100, 20);
            this.lblAprobados.TabIndex = 5;
            // 
            // lblDesaprobados
            // 
            this.lblDesaprobados.Location = new System.Drawing.Point(393, 111);
            this.lblDesaprobados.Name = "lblDesaprobados";
            this.lblDesaprobados.Size = new System.Drawing.Size(100, 20);
            this.lblDesaprobados.TabIndex = 6;
            // 
            // Calificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(524, 292);
            this.Controls.Add(this.lblDesaprobados);
            this.Controls.Add(this.lblAprobados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDesaprobados);
            this.Controls.Add(this.lstAprobados);
            this.Controls.Add(this.btnGnerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejemplo: Simulación de notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGnerar;
        private System.Windows.Forms.ListBox lstAprobados;
        private System.Windows.Forms.ListBox lstDesaprobados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblAprobados;
        private System.Windows.Forms.TextBox lblDesaprobados;
    }
}