namespace VistaEscritorio
{
    partial class verAlbum
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siguienteBTN = new System.Windows.Forms.Button();
            this.albumListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(322, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // siguienteBTN
            // 
            this.siguienteBTN.Location = new System.Drawing.Point(448, 281);
            this.siguienteBTN.Name = "siguienteBTN";
            this.siguienteBTN.Size = new System.Drawing.Size(75, 23);
            this.siguienteBTN.TabIndex = 1;
            this.siguienteBTN.Text = "Siguiente";
            this.siguienteBTN.UseVisualStyleBackColor = true;
            // 
            // albumListBox
            // 
            this.albumListBox.FormattingEnabled = true;
            this.albumListBox.ItemHeight = 16;
            this.albumListBox.Location = new System.Drawing.Point(35, 14);
            this.albumListBox.Name = "albumListBox";
            this.albumListBox.Size = new System.Drawing.Size(210, 244);
            this.albumListBox.TabIndex = 2;
            // 
            // verAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 327);
            this.Controls.Add(this.albumListBox);
            this.Controls.Add(this.siguienteBTN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "verAlbum";
            this.Text = "Album de fotos ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button siguienteBTN;
        private System.Windows.Forms.ListBox albumListBox;
    }
}