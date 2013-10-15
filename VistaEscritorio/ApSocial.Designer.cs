namespace VistaEscritorio
{
    partial class ApSocial
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desloguearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaUsuarioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.amistadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListaDeAmigosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solictarNuevaAmistadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responderSolicitudesDeAmistadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publicacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaPublicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensajesPrivadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoMensajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMensajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.menu2ToolStripMenuItem,
            this.amistadesToolStripMenuItem,
            this.publicacionesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem,
            this.desloguearToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Acceso";
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.ingresarToolStripMenuItem.Text = "Ingresar";
            this.ingresarToolStripMenuItem.Click += new System.EventHandler(this.ingresarToolStripMenuItem_Click);
            // 
            // desloguearToolStripMenuItem
            // 
            this.desloguearToolStripMenuItem.Name = "desloguearToolStripMenuItem";
            this.desloguearToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.desloguearToolStripMenuItem.Text = "Desloguear";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // menu2ToolStripMenuItem
            // 
            this.menu2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoUsuarioToolStripMenuItem,
            this.modificarUsuarioMenuItem,
            this.bajaUsuarioMenuItem,
            this.listaDeUsuariosToolStripMenuItem});
            this.menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            this.menu2ToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.menu2ToolStripMenuItem.Text = "Manejo de Usuarios";
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario";
            this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
            // 
            // modificarUsuarioMenuItem
            // 
            this.modificarUsuarioMenuItem.Enabled = false;
            this.modificarUsuarioMenuItem.Name = "modificarUsuarioMenuItem";
            this.modificarUsuarioMenuItem.Size = new System.Drawing.Size(249, 22);
            this.modificarUsuarioMenuItem.Text = "Modificar Usuario";
            this.modificarUsuarioMenuItem.Click += new System.EventHandler(this.modificarUsuarioToolStripMenuItem_Click);
            // 
            // bajaUsuarioMenuItem
            // 
            this.bajaUsuarioMenuItem.Enabled = false;
            this.bajaUsuarioMenuItem.Name = "bajaUsuarioMenuItem";
            this.bajaUsuarioMenuItem.Size = new System.Drawing.Size(249, 22);
            this.bajaUsuarioMenuItem.Text = "Baja Usuario";
            this.bajaUsuarioMenuItem.Click += new System.EventHandler(this.bajaUsuarioToolStripMenuItem_Click);
            // 
            // listaDeUsuariosToolStripMenuItem
            // 
            this.listaDeUsuariosToolStripMenuItem.Name = "listaDeUsuariosToolStripMenuItem";
            this.listaDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.listaDeUsuariosToolStripMenuItem.Text = "Lista de Usuarios de la Aplicación";
            this.listaDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.listaDeUsuariosToolStripMenuItem_Click);
            // 
            // amistadesToolStripMenuItem
            // 
            this.amistadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verListaDeAmigosToolStripMenuItem,
            this.solictarNuevaAmistadToolStripMenuItem,
            this.responderSolicitudesDeAmistadToolStripMenuItem});
            this.amistadesToolStripMenuItem.Name = "amistadesToolStripMenuItem";
            this.amistadesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.amistadesToolStripMenuItem.Text = "Amistades";
            // 
            // verListaDeAmigosToolStripMenuItem
            // 
            this.verListaDeAmigosToolStripMenuItem.Name = "verListaDeAmigosToolStripMenuItem";
            this.verListaDeAmigosToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.verListaDeAmigosToolStripMenuItem.Text = "Ver lista de amigos";
            this.verListaDeAmigosToolStripMenuItem.Click += new System.EventHandler(this.verListaDeAmigosToolStripMenuItem_Click);
            // 
            // solictarNuevaAmistadToolStripMenuItem
            // 
            this.solictarNuevaAmistadToolStripMenuItem.Name = "solictarNuevaAmistadToolStripMenuItem";
            this.solictarNuevaAmistadToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.solictarNuevaAmistadToolStripMenuItem.Text = "Solicitar nueva amistad";
            this.solictarNuevaAmistadToolStripMenuItem.Click += new System.EventHandler(this.solictarNuevaAmistadToolStripMenuItem_Click);
            // 
            // responderSolicitudesDeAmistadToolStripMenuItem
            // 
            this.responderSolicitudesDeAmistadToolStripMenuItem.Name = "responderSolicitudesDeAmistadToolStripMenuItem";
            this.responderSolicitudesDeAmistadToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.responderSolicitudesDeAmistadToolStripMenuItem.Text = "Responder solicitudes de amistad";
            this.responderSolicitudesDeAmistadToolStripMenuItem.Click += new System.EventHandler(this.responderSolicitudesDeAmistadToolStripMenuItem_Click);
            // 
            // publicacionesToolStripMenuItem
            // 
            this.publicacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verMuroToolStripMenuItem,
            this.nuevaPublicaciónToolStripMenuItem,
            this.mensajesPrivadosToolStripMenuItem});
            this.publicacionesToolStripMenuItem.Name = "publicacionesToolStripMenuItem";
            this.publicacionesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.publicacionesToolStripMenuItem.Text = "Publicaciones";
            // 
            // verMuroToolStripMenuItem
            // 
            this.verMuroToolStripMenuItem.Name = "verMuroToolStripMenuItem";
            this.verMuroToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.verMuroToolStripMenuItem.Text = "Ver Muro";
            // 
            // nuevaPublicaciónToolStripMenuItem
            // 
            this.nuevaPublicaciónToolStripMenuItem.Name = "nuevaPublicaciónToolStripMenuItem";
            this.nuevaPublicaciónToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nuevaPublicaciónToolStripMenuItem.Text = "Nueva Publicación";
            // 
            // mensajesPrivadosToolStripMenuItem
            // 
            this.mensajesPrivadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoMensajeToolStripMenuItem,
            this.verMensajesToolStripMenuItem});
            this.mensajesPrivadosToolStripMenuItem.Name = "mensajesPrivadosToolStripMenuItem";
            this.mensajesPrivadosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.mensajesPrivadosToolStripMenuItem.Text = "Mensajes Privados";
            // 
            // nuevoMensajeToolStripMenuItem
            // 
            this.nuevoMensajeToolStripMenuItem.Name = "nuevoMensajeToolStripMenuItem";
            this.nuevoMensajeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.nuevoMensajeToolStripMenuItem.Text = "Nuevo Mensaje";
            // 
            // verMensajesToolStripMenuItem
            // 
            this.verMensajesToolStripMenuItem.Name = "verMensajesToolStripMenuItem";
            this.verMensajesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.verMensajesToolStripMenuItem.Text = "Ver Mensajes";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // ApSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ApSocial";
            this.Text = "ApSocial";
            this.Activated += new System.EventHandler(this.ApSocial_Activated);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaUsuarioMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desloguearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem amistadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListaDeAmigosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solictarNuevaAmistadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responderSolicitudesDeAmistadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem publicacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaPublicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensajesPrivadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoMensajeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMensajesToolStripMenuItem;
    }
}



