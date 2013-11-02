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
    public partial class Amistad : System.Web.UI.Page
    {

        AmistadesController controladora = new AmistadesController();
        int usuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.usuario = Convert.ToInt32(Session["usuarioLogueado"].ToString());
            this.setPendingRequests();
        }

        private void setPendingRequests()
        {
            solicitudesPendientesLbl.Text = controladora.getAllUsuariosSolicitudesFromUser(this.usuario).Count().ToString();
        }

        protected void enviarSolicitud_Click(object sender, EventArgs e)
        {
            try {
                controladora.solicitarAmistad(this.usuario, emailSolicitud.Text);
                this.resultadoSolicitud.Text = "<div class=\"alert alert-success alert-dismissable\">";
                this.resultadoSolicitud.Text += "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button>";
                this.resultadoSolicitud.Text += "La solicitud fue enviada correctamente a <strong>" + emailSolicitud.Text + "</strong></div>";
            } catch (Exception ex) {
                this.resultadoSolicitud.Text = "<div class=\"alert alert-danger alert-dismissable\">";
                this.resultadoSolicitud.Text += "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button>";
                this.resultadoSolicitud.Text += "<strong>Error!</strong>" + ex.Message + "</div>";

            }
        }
    }
}
