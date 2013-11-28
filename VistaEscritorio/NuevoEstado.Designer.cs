namespace VistaEscritorio
{
    partial class NuevoEstado
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
            this.guardarEstadoBTN = new System.Windows.Forms.Button();
            this.mensajeTXT = new System.Windows.Forms.TextBox();
            this.buscarArchivoBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // guardarEstadoBTN
            // 
            this.guardarEstadoBTN.Location = new System.Drawing.Point(87, 174);
            this.guardarEstadoBTN.Name = "guardarEstadoBTN";
            this.guardarEstadoBTN.Size = new System.Drawing.Size(124, 23);
            this.guardarEstadoBTN.TabIndex = 0;
            this.guardarEstadoBTN.Text = "Guardar Estado";
            this.guardarEstadoBTN.UseVisualStyleBackColor = true;
            this.guardarEstadoBTN.Click += new System.EventHandler(this.guardarEstadoBTN_Click);
            // 
            // mensajeTXT
            // 
            this.mensajeTXT.Location = new System.Drawing.Point(41, 23);
            this.mensajeTXT.Multiline = true;
            this.mensajeTXT.Name = "mensajeTXT";
            this.mensajeTXT.Size = new System.Drawing.Size(210, 104);
            this.mensajeTXT.TabIndex = 1;
            // 
            // buscarArchivoBtn
            // 
            this.buscarArchivoBtn.Location = new System.Drawing.Point(216, 134);
            this.buscarArchivoBtn.Margin = new System.Windows.Forms.Padding(4);
            this.buscarArchivoBtn.Name = "buscarArchivoBtn";
            this.buscarArchivoBtn.Size = new System.Drawing.Size(35, 28);
            this.buscarArchivoBtn.TabIndex = 8;
            this.buscarArchivoBtn.Text = "...";
            this.buscarArchivoBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 22);
            this.textBox1.TabIndex = 9;
            // 
            // NuevoEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 206);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buscarArchivoBtn);
            this.Controls.Add(this.mensajeTXT);
            this.Controls.Add(this.guardarEstadoBTN);
            this.Name = "NuevoEstado";
            this.Text = "NuevoEstado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button guardarEstadoBTN;
        private System.Windows.Forms.TextBox mensajeTXT;
        private System.Windows.Forms.Button buscarArchivoBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}