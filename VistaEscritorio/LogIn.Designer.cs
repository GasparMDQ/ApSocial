namespace VistaEscritorio
{
    partial class LogIn
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
            if (disposing && (components != null)) {
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
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.ingresarBtn = new System.Windows.Forms.Button();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(155, 20);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(132, 22);
            this.usernameTxt.TabIndex = 0;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(155, 52);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(132, 22);
            this.passwordTxt.TabIndex = 1;
            // 
            // ingresarBtn
            // 
            this.ingresarBtn.Location = new System.Drawing.Point(155, 84);
            this.ingresarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ingresarBtn.Name = "ingresarBtn";
            this.ingresarBtn.Size = new System.Drawing.Size(133, 28);
            this.ingresarBtn.TabIndex = 2;
            this.ingresarBtn.Text = "Ingresar";
            this.ingresarBtn.UseVisualStyleBackColor = true;
            this.ingresarBtn.Click += new System.EventHandler(this.ingresarBtn_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(16, 23);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(131, 17);
            this.usernameLbl.TabIndex = 3;
            this.usernameLbl.Text = "Nombre de Usuario";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(16, 55);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(69, 17);
            this.passwordLbl.TabIndex = 4;
            this.passwordLbl.Text = "Password";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(80, 129);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(145, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "recuperar contraseña";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 169);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.ingresarBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button ingresarBtn;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox usernameTxt;
    }
}