using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using ApSocial.Controladora.Usuarios;
using ApSocial.Entidades;

namespace VistaWeb.Account
{
    public partial class Register : System.Web.UI.Page
    {

        private UsuarioController controladora = new UsuarioController();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void CreateUserButton_Click(object sender, EventArgs e)
        {
            /**
             * Crear Usuario
             */
            DateTime fechaDeNacimiento = new DateTime(Convert.ToInt32(this.Anio.Text),Convert.ToInt32(this.Mes.SelectedValue),Convert.ToInt32(this.Dia.Text));
            controladora.nuevoUsuario(this.Email.Text, this.Password.Text, this.PasswordCompare.Text, this.Nombre.Text, this.Apellido.Text, this.Residencia.Text, fechaDeNacimiento, this.Foto.FileName, this.Foto.FileBytes);

        }

    }
}
