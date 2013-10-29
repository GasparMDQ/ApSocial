namespace VistaEscritorio
{
    partial class albumForm
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
            this.btnCrearAlbum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // albumNameTXT
            // 
            this.albumNameTXT.Location = new System.Drawing.Point(14, 37);
            this.albumNameTXT.Name = "albumNameTXT";
            this.albumNameTXT.Size = new System.Drawing.Size(216, 20);
            this.albumNameTXT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese el nombre del album";
            // 
            // btnGuardarAlbum
            // 
            this.btnGuardarAlbum.Location = new System.Drawing.Point(14, 92);
            this.btnGuardarAlbum.Name = "btnGuardarAlbum";
            this.btnGuardarAlbum.Size = new System.Drawing.Size(72, 22);
            this.btnGuardarAlbum.TabIndex = 2;
            this.btnGuardarAlbum.Text = "Guardar";
            this.btnGuardarAlbum.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(105, 92);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 22);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNuevaFoto
            // 
            this.btnNuevaFoto.Location = new System.Drawing.Point(12, 64);
            this.btnNuevaFoto.Name = "btnNuevaFoto";
            this.btnNuevaFoto.Size = new System.Drawing.Size(125, 22);
            this.btnNuevaFoto.TabIndex = 4;
            this.btnNuevaFoto.Text = "Cargar nueva foto";
            this.btnNuevaFoto.UseVisualStyleBackColor = true;

            // 
            // btnCrearAlbum
            // 
            this.btnCrearAlbum.Location = new System.Drawing.Point(155, 63);
            this.btnCrearAlbum.Name = "btnCrearAlbum";
            this.btnCrearAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnCrearAlbum.TabIndex = 5;
            this.btnCrearAlbum.Text = "Crear album";
            this.btnCrearAlbum.UseVisualStyleBackColor = true;
            // 
            // albumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 151);
            this.Controls.Add(this.btnCrearAlbum);
            this.Controls.Add(this.btnNuevaFoto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarAlbum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albumNameTXT);
            this.Name = "albumForm";
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
        private System.Windows.Forms.Button btnCrearAlbum;
    }
}