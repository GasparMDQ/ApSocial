using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ApSocial.Controladora.Amistades;
using ApSocial.Entidades;

namespace VistaWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        private AmistadesController controladoraAmistad = new AmistadesController();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.loadFriends();
        }

        public void loadFriends()
        {
            AmigosList.DataSource = null;
            AmigosList.DataSource = this.controladoraAmistad.getAllFriendsFromUser( Convert.ToInt32(Session["usuarioLogueado"].ToString()));
            this.AmigosList.DataBind();
        }
    }
}
