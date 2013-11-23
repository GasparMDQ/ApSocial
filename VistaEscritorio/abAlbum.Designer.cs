namespace VistaEscritorio
{
    partial class abAlbum
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
            this.albumNameTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarAlbum = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNuevaFoto = new System.Windows.Forms.Button();
            this.listFotos = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboMisAlbums = new System.Windows.Forms.ComboBox();
            this.borrarAlbumbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // albumNameTXT
            // 
            this.albumNameTXT.Location = new System.Drawing.Point(71, 169);
            this.albumNameTXT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.albumNameTXT.Name = "albumNameTXT";
            this.albumNameTXT.Size = new System.Drawing.Size(287, 22);
            this.albumNameTXT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el nombre del nuevo album";
            // 
            // btnGuardarAlbum
            // 
            this.btnGuardarAlbum.Location = new System.Drawing.Point(71, 417);
            this.btnGuardarAlbum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarAlbum.Name = "btnGuardarAlbum";
            this.btnGuardarAlbum.Size = new System.Drawing.Size(96, 27);
            this.btnGuardarAlbum.TabIndex = 2;
            this.btnGuardarAlbum.Text = "Guardar";
            this.btnGuardarAlbum.UseVisualStyleBackColor = true;
            this.btnGuardarAlbum.Click += new System.EventHandler(this.btnGuardarAlbum_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(235, 417);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 27);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevaFoto
            // 
            this.btnNuevaFoto.Location = new System.Drawing.Point(372, 205);
            this.btnNuevaFoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevaFoto.Name = "btnNuevaFoto";
            this.btnNuevaFoto.Size = new System.Drawing.Size(167, 27);
            this.btnNuevaFoto.TabIndex = 4;
            this.btnNuevaFoto.Text = "Cargar nueva foto";
            this.btnNuevaFoto.UseVisualStyleBackColor = true;
            this.btnNuevaFoto.Click += new System.EventHandler(this.btnNuevaFoto_Click);
            // 
            // listFotos
            // 
            this.listFotos.FormattingEnabled = true;
            this.listFotos.ItemHeight = 16;
            this.listFotos.Location = new System.Drawing.Point(69, 208);
            this.listFotos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listFotos.Name = "listFotos";
            this.listFotos.Size = new System.Drawing.Size(281, 164);
            this.listFotos.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 258);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Borrar Foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboMisAlbums
            // 
            this.comboMisAlbums.FormattingEnabled = true;
            this.comboMisAlbums.Location = new System.Drawing.Point(69, 62);
            this.comboMisAlbums.Name = "comboMisAlbums";
            this.comboMisAlbums.Size = new System.Drawing.Size(260, 24);
            this.comboMisAlbums.TabIndex = 7;
            // 
            // borrarAlbumbtn
            // 
            this.borrarAlbumbtn.Location = new System.Drawing.Point(373, 62);
            this.borrarAlbumbtn.Name = "borrarAlbumbtn";
            this.borrarAlbumbtn.Size = new System.Drawing.Size(75, 23);
            this.borrarAlbumbtn.TabIndex = 8;
            this.borrarAlbumbtn.Text = "Borrar Album";
            this.borrarAlbumbtn.UseVisualStyleBackColor = true;
            this.borrarAlbumbtn.Click += new System.EventHandler(this.borrarAlbumbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seleccione album a borrar";
            // 
            // abAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.borrarAlbumbtn);
            this.Controls.Add(this.comboMisAlbums);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listFotos);
            this.Controls.Add(this.btnNuevaFoto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarAlbum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albumNameTXT);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "abAlbum";
            this.Text = "albumForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox albumNameTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarAlbum;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNuevaFoto;
        private System.Windows.Forms.ListBox listFotos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboMisAlbums;
        private System.Windows.Forms.Button borrarAlbumbtn;
        private System.Windows.Forms.Label label2;
    }
}