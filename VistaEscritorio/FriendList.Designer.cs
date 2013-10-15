namespace VistaEscritorio
{
    partial class FriendList
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
            this.listaAmigos = new System.Windows.Forms.ListBox();
            this.nacimentoBox = new System.Windows.Forms.MonthCalendar();
            this.fotoBox = new System.Windows.Forms.PictureBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.residenciaLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.nacimientoLbl = new System.Windows.Forms.Label();
            this.residenciaBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listaAmigos
            // 
            this.listaAmigos.FormattingEnabled = true;
            this.listaAmigos.Location = new System.Drawing.Point(12, 12);
            this.listaAmigos.Name = "listaAmigos";
            this.listaAmigos.Size = new System.Drawing.Size(180, 238);
            this.listaAmigos.Sorted = true;
            this.listaAmigos.TabIndex = 1;
            this.listaAmigos.SelectedIndexChanged += new System.EventHandler(this.listaAmigos_SelectedIndexChanged);
            // 
            // nacimentoBox
            // 
            this.nacimentoBox.Enabled = false;
            this.nacimentoBox.Location = new System.Drawing.Point(392, 39);
            this.nacimentoBox.Name = "nacimentoBox";
            this.nacimentoBox.TabIndex = 2;
            // 
            // fotoBox
            // 
            this.fotoBox.Location = new System.Drawing.Point(204, 12);
            this.fotoBox.Name = "fotoBox";
            this.fotoBox.Size = new System.Drawing.Size(155, 144);
            this.fotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoBox.TabIndex = 3;
            this.fotoBox.TabStop = false;
            // 
            // emailBox
            // 
            this.emailBox.Enabled = false;
            this.emailBox.Location = new System.Drawing.Point(204, 181);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(157, 20);
            this.emailBox.TabIndex = 4;
            // 
            // residenciaLbl
            // 
            this.residenciaLbl.AutoSize = true;
            this.residenciaLbl.Location = new System.Drawing.Point(201, 204);
            this.residenciaLbl.Name = "residenciaLbl";
            this.residenciaLbl.Size = new System.Drawing.Size(105, 13);
            this.residenciaLbl.TabIndex = 5;
            this.residenciaLbl.Text = "Lugar de Residencia";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(201, 165);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(32, 13);
            this.emailLbl.TabIndex = 6;
            this.emailLbl.Text = "Email";
            // 
            // nacimientoLbl
            // 
            this.nacimientoLbl.AutoSize = true;
            this.nacimientoLbl.Location = new System.Drawing.Point(389, 12);
            this.nacimientoLbl.Name = "nacimientoLbl";
            this.nacimientoLbl.Size = new System.Drawing.Size(108, 13);
            this.nacimientoLbl.TabIndex = 7;
            this.nacimientoLbl.Text = "Fecha de Nacimiento";
            // 
            // residenciaBox
            // 
            this.residenciaBox.Enabled = false;
            this.residenciaBox.Location = new System.Drawing.Point(204, 220);
            this.residenciaBox.Name = "residenciaBox";
            this.residenciaBox.Size = new System.Drawing.Size(157, 20);
            this.residenciaBox.TabIndex = 8;
            // 
            // FriendList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 259);
            this.Controls.Add(this.residenciaBox);
            this.Controls.Add(this.nacimientoLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.residenciaLbl);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.fotoBox);
            this.Controls.Add(this.nacimentoBox);
            this.Controls.Add(this.listaAmigos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FriendList";
            this.Text = "Listado de Amigos";
            this.Load += new System.EventHandler(this.UserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaAmigos;
        private System.Windows.Forms.MonthCalendar nacimentoBox;
        private System.Windows.Forms.PictureBox fotoBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label residenciaLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label nacimientoLbl;
        private System.Windows.Forms.TextBox residenciaBox;
    }
}