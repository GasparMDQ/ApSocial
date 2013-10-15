namespace VistaEscritorio
{
    partial class AmistadSolicitud
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
            this.SolicitarBox = new System.Windows.Forms.TextBox();
            this.SolicitarLbl = new System.Windows.Forms.Label();
            this.SolicitarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SolicitarBox
            // 
            this.SolicitarBox.Location = new System.Drawing.Point(167, 6);
            this.SolicitarBox.Name = "SolicitarBox";
            this.SolicitarBox.Size = new System.Drawing.Size(247, 20);
            this.SolicitarBox.TabIndex = 0;
            // 
            // SolicitarLbl
            // 
            this.SolicitarLbl.AutoSize = true;
            this.SolicitarLbl.Location = new System.Drawing.Point(12, 9);
            this.SolicitarLbl.Name = "SolicitarLbl";
            this.SolicitarLbl.Size = new System.Drawing.Size(140, 13);
            this.SolicitarLbl.TabIndex = 1;
            this.SolicitarLbl.Text = "Ingrese el email de su amigo";
            // 
            // SolicitarBtn
            // 
            this.SolicitarBtn.Location = new System.Drawing.Point(303, 32);
            this.SolicitarBtn.Name = "SolicitarBtn";
            this.SolicitarBtn.Size = new System.Drawing.Size(111, 23);
            this.SolicitarBtn.TabIndex = 2;
            this.SolicitarBtn.Text = "Solicitar amistad";
            this.SolicitarBtn.UseVisualStyleBackColor = true;
            this.SolicitarBtn.Click += new System.EventHandler(this.Solicitud_Click);
            // 
            // AmistadSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 65);
            this.Controls.Add(this.SolicitarBtn);
            this.Controls.Add(this.SolicitarLbl);
            this.Controls.Add(this.SolicitarBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AmistadSolicitud";
            this.Text = "Solicitar nueva Amistad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SolicitarBox;
        private System.Windows.Forms.Label SolicitarLbl;
        private System.Windows.Forms.Button SolicitarBtn;
    }
}