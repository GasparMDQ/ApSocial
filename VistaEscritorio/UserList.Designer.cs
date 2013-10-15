namespace VistaEscritorio
{
    partial class UserList
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
            this.listaUsuariosGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // listaUsuariosGrid
            // 
            this.listaUsuariosGrid.AllowUserToAddRows = false;
            this.listaUsuariosGrid.AllowUserToDeleteRows = false;
            this.listaUsuariosGrid.AllowUserToOrderColumns = true;
            this.listaUsuariosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaUsuariosGrid.Location = new System.Drawing.Point(12, 12);
            this.listaUsuariosGrid.MultiSelect = false;
            this.listaUsuariosGrid.Name = "listaUsuariosGrid";
            this.listaUsuariosGrid.ReadOnly = true;
            this.listaUsuariosGrid.Size = new System.Drawing.Size(708, 320);
            this.listaUsuariosGrid.TabIndex = 0;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 344);
            this.Controls.Add(this.listaUsuariosGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserList";
            this.Text = "Listado de Usuario";
            this.Load += new System.EventHandler(this.UserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaUsuariosGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listaUsuariosGrid;
    }
}