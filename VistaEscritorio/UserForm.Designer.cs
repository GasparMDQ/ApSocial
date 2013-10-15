namespace VistaEscritorio
{
    partial class UserForm
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
            this.emailLbl = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.nombreLbl = new System.Windows.Forms.Label();
            this.nombreBox = new System.Windows.Forms.TextBox();
            this.apellidoLbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.password_checkLbl = new System.Windows.Forms.Label();
            this.residenciaLbl = new System.Windows.Forms.Label();
            this.fdnLbl = new System.Windows.Forms.Label();
            this.fdnBox = new System.Windows.Forms.MonthCalendar();
            this.residenciaBox = new System.Windows.Forms.TextBox();
            this.apellidoBox = new System.Windows.Forms.TextBox();
            this.password_checkBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.botonBtn = new System.Windows.Forms.Button();
            this.tituloLbl = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fotoBox = new System.Windows.Forms.TextBox();
            this.fotoLbl = new System.Windows.Forms.Label();
            this.buscarArchivoBtn = new System.Windows.Forms.Button();
            this.fotoFrame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fotoFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(13, 58);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(32, 13);
            this.emailLbl.TabIndex = 0;
            this.emailLbl.Text = "Email";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(79, 55);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(164, 20);
            this.emailBox.TabIndex = 0;
            // 
            // nombreLbl
            // 
            this.nombreLbl.AutoSize = true;
            this.nombreLbl.Location = new System.Drawing.Point(13, 136);
            this.nombreLbl.Name = "nombreLbl";
            this.nombreLbl.Size = new System.Drawing.Size(44, 13);
            this.nombreLbl.TabIndex = 2;
            this.nombreLbl.Text = "Nombre";
            // 
            // nombreBox
            // 
            this.nombreBox.Location = new System.Drawing.Point(79, 133);
            this.nombreBox.Name = "nombreBox";
            this.nombreBox.Size = new System.Drawing.Size(164, 20);
            this.nombreBox.TabIndex = 3;
            // 
            // apellidoLbl
            // 
            this.apellidoLbl.AutoSize = true;
            this.apellidoLbl.Location = new System.Drawing.Point(13, 162);
            this.apellidoLbl.Name = "apellidoLbl";
            this.apellidoLbl.Size = new System.Drawing.Size(44, 13);
            this.apellidoLbl.TabIndex = 4;
            this.apellidoLbl.Text = "Apellido";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Location = new System.Drawing.Point(13, 84);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(53, 13);
            this.passwordlbl.TabIndex = 5;
            this.passwordlbl.Text = "Password";
            // 
            // password_checkLbl
            // 
            this.password_checkLbl.AutoSize = true;
            this.password_checkLbl.Location = new System.Drawing.Point(13, 110);
            this.password_checkLbl.Name = "password_checkLbl";
            this.password_checkLbl.Size = new System.Drawing.Size(53, 13);
            this.password_checkLbl.TabIndex = 6;
            this.password_checkLbl.Text = "Password";
            // 
            // residenciaLbl
            // 
            this.residenciaLbl.AutoSize = true;
            this.residenciaLbl.Location = new System.Drawing.Point(13, 188);
            this.residenciaLbl.Name = "residenciaLbl";
            this.residenciaLbl.Size = new System.Drawing.Size(60, 13);
            this.residenciaLbl.TabIndex = 7;
            this.residenciaLbl.Text = "Residencia";
            // 
            // fdnLbl
            // 
            this.fdnLbl.AutoSize = true;
            this.fdnLbl.Location = new System.Drawing.Point(356, 93);
            this.fdnLbl.Name = "fdnLbl";
            this.fdnLbl.Size = new System.Drawing.Size(108, 13);
            this.fdnLbl.TabIndex = 1;
            this.fdnLbl.Text = "Fecha de Nacimiento";
            // 
            // fdnBox
            // 
            this.fdnBox.Location = new System.Drawing.Point(294, 115);
            this.fdnBox.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.fdnBox.MaxSelectionCount = 1;
            this.fdnBox.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.fdnBox.Name = "fdnBox";
            this.fdnBox.TabIndex = 8;
            // 
            // residenciaBox
            // 
            this.residenciaBox.Location = new System.Drawing.Point(79, 185);
            this.residenciaBox.Name = "residenciaBox";
            this.residenciaBox.Size = new System.Drawing.Size(164, 20);
            this.residenciaBox.TabIndex = 5;
            // 
            // apellidoBox
            // 
            this.apellidoBox.Location = new System.Drawing.Point(79, 159);
            this.apellidoBox.Name = "apellidoBox";
            this.apellidoBox.Size = new System.Drawing.Size(164, 20);
            this.apellidoBox.TabIndex = 4;
            // 
            // password_checkBox
            // 
            this.password_checkBox.Location = new System.Drawing.Point(112, 107);
            this.password_checkBox.Name = "password_checkBox";
            this.password_checkBox.Size = new System.Drawing.Size(131, 20);
            this.password_checkBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(112, 81);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(131, 20);
            this.passwordBox.TabIndex = 1;
            // 
            // botonBtn
            // 
            this.botonBtn.Location = new System.Drawing.Point(16, 254);
            this.botonBtn.Name = "botonBtn";
            this.botonBtn.Size = new System.Drawing.Size(75, 23);
            this.botonBtn.TabIndex = 9;
            this.botonBtn.Text = "#text_btn#";
            this.botonBtn.UseVisualStyleBackColor = true;
            this.botonBtn.Click += new System.EventHandler(this.botonBtn_Click);
            // 
            // tituloLbl
            // 
            this.tituloLbl.AutoSize = true;
            this.tituloLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLbl.Location = new System.Drawing.Point(12, 9);
            this.tituloLbl.Name = "tituloLbl";
            this.tituloLbl.Size = new System.Drawing.Size(76, 24);
            this.tituloLbl.TabIndex = 15;
            this.tituloLbl.Text = "#titulo#";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // fotoBox
            // 
            this.fotoBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.fotoBox.Location = new System.Drawing.Point(79, 211);
            this.fotoBox.Name = "fotoBox";
            this.fotoBox.Size = new System.Drawing.Size(132, 20);
            this.fotoBox.TabIndex = 6;
            // 
            // fotoLbl
            // 
            this.fotoLbl.AutoSize = true;
            this.fotoLbl.Location = new System.Drawing.Point(13, 214);
            this.fotoLbl.Name = "fotoLbl";
            this.fotoLbl.Size = new System.Drawing.Size(28, 13);
            this.fotoLbl.TabIndex = 17;
            this.fotoLbl.Text = "Foto";
            // 
            // buscarArchivoBtn
            // 
            this.buscarArchivoBtn.Location = new System.Drawing.Point(217, 209);
            this.buscarArchivoBtn.Name = "buscarArchivoBtn";
            this.buscarArchivoBtn.Size = new System.Drawing.Size(26, 23);
            this.buscarArchivoBtn.TabIndex = 7;
            this.buscarArchivoBtn.Text = "...";
            this.buscarArchivoBtn.UseVisualStyleBackColor = true;
            this.buscarArchivoBtn.Click += new System.EventHandler(this.buscarArchivoBtn_Click);
            // 
            // fotoFrame
            // 
            this.fotoFrame.Location = new System.Drawing.Point(421, 12);
            this.fotoFrame.Name = "fotoFrame";
            this.fotoFrame.Size = new System.Drawing.Size(100, 78);
            this.fotoFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoFrame.TabIndex = 19;
            this.fotoFrame.TabStop = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 291);
            this.Controls.Add(this.fotoFrame);
            this.Controls.Add(this.buscarArchivoBtn);
            this.Controls.Add(this.fotoLbl);
            this.Controls.Add(this.fotoBox);
            this.Controls.Add(this.tituloLbl);
            this.Controls.Add(this.botonBtn);
            this.Controls.Add(this.password_checkBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.residenciaBox);
            this.Controls.Add(this.apellidoBox);
            this.Controls.Add(this.fdnBox);
            this.Controls.Add(this.fdnLbl);
            this.Controls.Add(this.residenciaLbl);
            this.Controls.Add(this.password_checkLbl);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.apellidoLbl);
            this.Controls.Add(this.nombreBox);
            this.Controls.Add(this.nombreLbl);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.emailLbl);
            this.Name = "UserForm";
            this.Text = "#titulo#";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotoFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label nombreLbl;
        private System.Windows.Forms.TextBox nombreBox;
        private System.Windows.Forms.Label apellidoLbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label password_checkLbl;
        private System.Windows.Forms.Label residenciaLbl;
        private System.Windows.Forms.Label fdnLbl;
        private System.Windows.Forms.MonthCalendar fdnBox;
        private System.Windows.Forms.TextBox residenciaBox;
        private System.Windows.Forms.TextBox apellidoBox;
        private System.Windows.Forms.TextBox password_checkBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button botonBtn;
        private System.Windows.Forms.Label tituloLbl;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox fotoBox;
        private System.Windows.Forms.Label fotoLbl;
        private System.Windows.Forms.Button buscarArchivoBtn;
        private System.Windows.Forms.PictureBox fotoFrame;
    }
}