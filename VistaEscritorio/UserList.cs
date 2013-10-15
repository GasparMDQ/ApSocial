using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApSocial.Controladora.Usuarios;
using ApSocial.Entidades;

namespace VistaEscritorio
{
    public partial class UserList : Form
    {
        private UsuarioController controladora = new UsuarioController();

        public UserList()
        {
            InitializeComponent();

            listaUsuariosGrid.DataSource = null;
            listaUsuariosGrid.DataSource = this.controladora.getAllUsers();
            listaUsuariosGrid.Refresh();
        }

        private void UserList_Load(object sender, EventArgs e)
        {

        }
    }
}
