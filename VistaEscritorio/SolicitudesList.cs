using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApSocial.Controladora.Amistades;
using ApSocial.Entidades;

namespace VistaEscritorio
{
    public partial class SolicitudesList : Form
    {
        private AmistadesController controladora = new AmistadesController();

        public SolicitudesList()
        {
            InitializeComponent();
            this.loadSolicitudesInList();
        }

        private void loadSolicitudesInList()
        {
            listaDeSolicitudes.DataSource = null;
            listaDeSolicitudes.DataSource = this.controladora.getAllUsuariosSolicitudesFromUser(Session.IdUsuarioLogueado);
            if (listaDeSolicitudes.Items.Count.Equals(0)) {
                MessageBox.Show("No hay solicitudes de amistad pendientes para este usuario", "Solicitudes de Amistad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void listaDeSolicitudes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)listaDeSolicitudes.SelectedItem;
            if (usuario != null) {
                this.loadFriendDataInForm(usuario);
            }
        }

        private void loadFriendDataInForm(Usuario usuario)
        {
            this.emailBox.Text = usuario.Email;
            this.fotoUsuario.ImageLocation = usuario.Foto_usuario;
        }

        private void rechazarBtn_Click(object sender, EventArgs e)
        {
            try {
                this.controladora.rechazarAmistad(Session.IdUsuarioLogueado, (Usuario)listaDeSolicitudes.SelectedItem);
                this.loadSolicitudesInList();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            try {
                this.controladora.aceptarAmistad(Session.IdUsuarioLogueado, (Usuario)listaDeSolicitudes.SelectedItem);
                this.loadSolicitudesInList();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
