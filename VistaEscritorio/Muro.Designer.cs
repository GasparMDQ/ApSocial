namespace VistaEscritorio
{
    partial class Muro
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
            this.imagen = new System.Windows.Forms.PictureBox();
            this.listPublicaciones = new System.Windows.Forms.ListBox();
            this.listComentarios = new System.Windows.Forms.ListBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // imagen
            // 
            this.imagen.Location = new System.Drawing.Point(295, 18);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(201, 132);
            this.imagen.TabIndex = 1;
            this.imagen.TabStop = false;
            // 
            // listPublicaciones
            // 
            this.listPublicaciones.FormattingEnabled = true;
            this.listPublicaciones.ItemHeight = 16;
            this.listPublicaciones.Location = new System.Drawing.Point(28, 18);
            this.listPublicaciones.Name = "listPublicaciones";
            this.listPublicaciones.Size = new System.Drawing.Size(261, 292);
            this.listPublicaciones.TabIndex = 2;
            this.listPublicaciones.SelectedIndexChanged += new System.EventHandler(this.listPublicaciones_SelectedIndexChanged);
            // 
            // listComentarios
            // 
            this.listComentarios.FormattingEnabled = true;
            this.listComentarios.ItemHeight = 16;
            this.listComentarios.Location = new System.Drawing.Point(512, 18);
            this.listComentarios.Name = "listComentarios";
            this.listComentarios.Size = new System.Drawing.Size(228, 132);
            this.listComentarios.TabIndex = 3;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Enabled = false;
            this.txtDetalle.Location = new System.Drawing.Point(305, 191);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(435, 119);
            this.txtDetalle.TabIndex = 4;
            // 
            // Muro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 401);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.listComentarios);
            this.Controls.Add(this.listPublicaciones);
            this.Controls.Add(this.imagen);
            this.Name = "Muro";
            this.Text = "Muro";
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.ListBox listPublicaciones;
        private System.Windows.Forms.ListBox listComentarios;
        private System.Windows.Forms.TextBox txtDetalle;
    }
}