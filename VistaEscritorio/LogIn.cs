using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApSocial.Controladora.Usuarios;

namespace VistaEscritorio
{
    public partial class LogIn : Form
    {
        private UsuarioController controladora = new UsuarioController();
        MenuStrip menu;

        public LogIn()
        {
            InitializeComponent();
        }
        public LogIn(MenuStrip m) {
            InitializeComponent();
            menu = m;
        }
        public void habilitarMenu(MenuStrip m)
        {
            if (Session.IdUsuarioLogueado > 0)
            {
                m.Items[2].Enabled = true;
                m.Items[3].Enabled = true;
            }
        }
        private void ingresarBtn_Click(object sender, EventArgs e)
        {
            try {
                Session.IdUsuarioLogueado = controladora.isCredentialValid(usernameTxt.Text, passwordTxt.Text);
                MessageBox.Show("Bienvenido "+controladora.getUsuarioById(Session.IdUsuarioLogueado).ToString(), "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                habilitarMenu(menu);
                this.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
