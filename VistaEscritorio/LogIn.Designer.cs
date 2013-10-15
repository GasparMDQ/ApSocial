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
            this.usernameTxt.Location = new System.Drawing.Point(116, 16);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(100, 20);
            this.usernameTxt.TabIndex = 0;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(116, 42);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(100, 20);
            this.passwordTxt.TabIndex = 1;
            // 
            // ingresarBtn
            // 
            this.ingresarBtn.Location = new System.Drawing.Point(116, 68);
            this.ingresarBtn.Name = "ingresarBtn";
            this.ingresarBtn.Size = new System.Drawing.Size(100, 23);
            this.ingresarBtn.TabIndex = 2;
            this.ingresarBtn.Text = "Ingresar";
            this.ingresarBtn.UseVisualStyleBackColor = true;
            this.ingresarBtn.Click += new System.EventHandler(this.ingresarBtn_Click);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(12, 19);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(98, 13);
            this.usernameLbl.TabIndex = 3;
            this.usernameLbl.Text = "Nombre de Usuario";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(12, 45);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordLbl.TabIndex = 4;
            this.passwordLbl.Text = "Password";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(60, 105);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(108, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "recuperar contraseña";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 137);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.ingresarBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button ingresarBtn;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}