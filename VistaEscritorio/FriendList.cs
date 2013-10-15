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
    public partial class FriendList : Form
    {
        private AmistadesController controladora = new AmistadesController();

        public FriendList()
        {
            InitializeComponent();

            listaAmigos.DataSource = null;
            listaAmigos.DataSource = this.controladora.getAllFriendsFromUser(Session.IdUsuarioLogueado);

        }

        private void UserList_Load(object sender, EventArgs e)
        {

        }

        private void listaAmigos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.loadFriendDataInForm((Usuario)listaAmigos.SelectedItem);
        }

        private void loadFriendDataInForm(Usuario usuario)
        {
            this.emailBox.Text = usuario.Email;
            this.fotoBox.ImageLocation = usuario.Foto_usuario;
            this.nacimentoBox.SetDate(usuario.FechaDeNacimiento);
            this.residenciaBox.Text = usuario.Residencia;
        }
    }
}
