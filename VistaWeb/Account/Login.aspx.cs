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
    public partial class Login : System.Web.UI.Page
    {

        private UsuarioController controladora = new UsuarioController();

        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register.aspx?ReturnUrl=" + HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
        }

        protected void LoginUser_Authenticate(object sender, AuthenticateEventArgs e)
        {
            try {
                Session["usuarioLogueado"] = controladora.isCredentialValid(LoginUser.UserName, LoginUser.Password);
                e.Authenticated = true;
                FormsAuthentication.RedirectFromLoginPage(((Usuario)controladora.getUsuarioById(Convert.ToInt32(Session["usuarioLogueado"]))).ToString(), LoginUser.RememberMeSet);
            } catch (Exception ex) {
                LoginUser.FailureText = ex.Message;
            }

        }

    }
}
