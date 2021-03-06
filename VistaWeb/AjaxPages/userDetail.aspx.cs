﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using ApSocial.Entidades;
using ApSocial.Controladora.Usuarios;

namespace VistaWeb.AjaxPages
{
    public partial class userDetail : System.Web.UI.Page
    {

        UsuarioController controladora = new UsuarioController();

        protected void Page_Load(object sender, EventArgs e)
        {
            int uid;
            string rUid = Request.QueryString["uid"];
            if ( rUid != null && rUid != "" ) {
                uid = Convert.ToInt32(rUid);
                if ( this.controladora.existeUsuario(uid) ) {
                    Usuario user = controladora.getUsuarioById(uid);
                    this.codeSpace.Text = user.Email;
                    this.userImage.ImageUrl = user.Foto_usuario;
                }
            } else {
                this.codeSpace.Text = "";
                this.userImage.ImageUrl = "";
            }
        }
    }
}