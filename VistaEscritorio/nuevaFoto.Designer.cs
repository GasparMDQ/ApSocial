namespace VistaEscritorio
{
    partial class nuevaFoto
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
            this.aceptarBTN = new System.Windows.Forms.Button();
            this.buscarArchivoBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pathTXT = new System.Windows.Forms.TextBox();
            this.cancelarBTN = new System.Windows.Forms.Button();
            this.listUsuariosEtiquetados = new System.Windows.Forms.ListBox();
            this.etiquetarBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listAmigos = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aceptarBTN
            // 
            this.aceptarBTN.Location = new System.Drawing.Point(67, 120);
            this.aceptarBTN.Name = "aceptarBTN";
            this.aceptarBTN.Size = new System.Drawing.Size(110, 23);
            this.aceptarBTN.TabIndex = 0;
            this.aceptarBTN.Text = "Aceptar";
            this.aceptarBTN.UseVisualStyleBackColor = true;
            this.aceptarBTN.Click += new System.EventHandler(this.aceptarBTN_Click);
            // 
            // buscarArchivoBtn
            // 
            this.buscarArchivoBtn.Location = new System.Drawing.Point(248, 68);
            this.buscarArchivoBtn.Name = "buscarArchivoBtn";
            this.buscarArchivoBtn.Size = new System.Drawing.Size(26, 23);
            this.buscarArchivoBtn.TabIndex = 8;
            this.buscarArchivoBtn.Text = "...";
            this.buscarArchivoBtn.UseVisualStyleBackColor = true;
            this.buscarArchivoBtn.Click += new System.EventHandler(this.buscarArchivoBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pathTXT
            // 
            this.pathTXT.Location = new System.Drawing.Point(106, 68);
            this.pathTXT.Name = "pathTXT";
            this.pathTXT.Size = new System.Drawing.Size(136, 20);
            this.pathTXT.TabIndex = 9;
            // 
            // cancelarBTN
            // 
            this.cancelarBTN.Location = new System.Drawing.Point(198, 120);
            this.cancelarBTN.Name = "cancelarBTN";
            this.cancelarBTN.Size = new System.Drawing.Size(97, 23);
            this.cancelarBTN.TabIndex = 10;
            this.cancelarBTN.Text = "Cancelar";
            this.cancelarBTN.UseVisualStyleBackColor = true;
            this.cancelarBTN.Click += new System.EventHandler(this.cancelarBTN_Click);
            // 
            // listUsuariosEtiquetados
            // 
            this.listUsuariosEtiquetados.FormattingEnabled = true;
            this.listUsuariosEtiquetados.Location = new System.Drawing.Point(458, 48);
            this.listUsuariosEtiquetados.Name = "listUsuariosEtiquetados";
            this.listUsuariosEtiquetados.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listUsuariosEtiquetados.Size = new System.Drawing.Size(110, 108);
            this.listUsuariosEtiquetados.TabIndex = 11;
            // 
            // etiquetarBTN
            // 
            this.etiquetarBTN.Location = new System.Drawing.Point(327, 162);
            this.etiquetarBTN.Name = "etiquetarBTN";
            this.etiquetarBTN.Size = new System.Drawing.Size(110, 23);
            this.etiquetarBTN.TabIndex = 12;
            this.etiquetarBTN.Text = "Etiquetar Usuario";
            this.etiquetarBTN.UseVisualStyleBackColor = true;
            this.etiquetarBTN.Click += new System.EventHandler(this.etiquetarBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Usuarios Etiquetados";
            // 
            // nombreTXT
            // 
            this.nombreTXT.Location = new System.Drawing.Point(106, 42);
            this.nombreTXT.Name = "nombreTXT";
            this.nombreTXT.Size = new System.Drawing.Size(165, 20);
            this.nombreTXT.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Foto";
            // 
            // listAmigos
            // 
            this.listAmigos.FormattingEnabled = true;
            this.listAmigos.Location = new System.Drawing.Point(327, 48);
            this.listAmigos.Name = "listAmigos";
            this.listAmigos.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listAmigos.Size = new System.Drawing.Size(110, 108);
            this.listAmigos.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mis amigos";
            // 
            // nuevaFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 247);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listAmigos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.etiquetarBTN);
            this.Controls.Add(this.listUsuariosEtiquetados);
            this.Controls.Add(this.cancelarBTN);
            this.Controls.Add(this.pathTXT);
            this.Controls.Add(this.buscarArchivoBtn);
            this.Controls.Add(this.aceptarBTN);
            this.Name = "nuevaFoto";
            this.Text = "nuevaFoto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptarBTN;
        private System.Windows.Forms.Button buscarArchivoBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox pathTXT;
        private System.Windows.Forms.Button cancelarBTN;
        private System.Windows.Forms.ListBox listUsuariosEtiquetados;
        private System.Windows.Forms.Button etiquetarBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listAmigos;
        private System.Windows.Forms.Label label4;
    }
}