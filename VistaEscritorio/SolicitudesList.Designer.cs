namespace VistaEscritorio
{
    partial class SolicitudesList
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
            this.emailBox = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.rechazarBtn = new System.Windows.Forms.Button();
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.fotoUsuario = new System.Windows.Forms.PictureBox();
            this.listaDeSolicitudes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // emailBox
            // 
            this.emailBox.Enabled = false;
            this.emailBox.Location = new System.Drawing.Point(251, 144);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(108, 20);
            this.emailBox.TabIndex = 11;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(210, 147);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(35, 13);
            this.emailLbl.TabIndex = 10;
            this.emailLbl.Text = "Email:";
            // 
            // rechazarBtn
            // 
            this.rechazarBtn.Location = new System.Drawing.Point(213, 199);
            this.rechazarBtn.Name = "rechazarBtn";
            this.rechazarBtn.Size = new System.Drawing.Size(146, 23);
            this.rechazarBtn.TabIndex = 9;
            this.rechazarBtn.Text = "Rechazar Solicitud";
            this.rechazarBtn.UseVisualStyleBackColor = true;
            this.rechazarBtn.Click += new System.EventHandler(this.rechazarBtn_Click);
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.Location = new System.Drawing.Point(213, 170);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(146, 23);
            this.aceptarBtn.TabIndex = 8;
            this.aceptarBtn.Text = "Aceptar Solicitud";
            this.aceptarBtn.UseVisualStyleBackColor = true;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // fotoUsuario
            // 
            this.fotoUsuario.Location = new System.Drawing.Point(213, 10);
            this.fotoUsuario.Name = "fotoUsuario";
            this.fotoUsuario.Size = new System.Drawing.Size(146, 128);
            this.fotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoUsuario.TabIndex = 7;
            this.fotoUsuario.TabStop = false;
            // 
            // listaDeSolicitudes
            // 
            this.listaDeSolicitudes.FormattingEnabled = true;
            this.listaDeSolicitudes.Location = new System.Drawing.Point(12, 10);
            this.listaDeSolicitudes.Name = "listaDeSolicitudes";
            this.listaDeSolicitudes.Size = new System.Drawing.Size(177, 212);
            this.listaDeSolicitudes.TabIndex = 6;
            this.listaDeSolicitudes.SelectedIndexChanged += new System.EventHandler(this.listaDeSolicitudes_SelectedIndexChanged);
            // 
            // SolicitudesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 233);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.rechazarBtn);
            this.Controls.Add(this.aceptarBtn);
            this.Controls.Add(this.fotoUsuario);
            this.Controls.Add(this.listaDeSolicitudes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SolicitudesList";
            this.Text = "Solicitudes de Amistad";
            ((System.ComponentModel.ISupportInitialize)(this.fotoUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Button rechazarBtn;
        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.PictureBox fotoUsuario;
        private System.Windows.Forms.ListBox listaDeSolicitudes;


    }
}