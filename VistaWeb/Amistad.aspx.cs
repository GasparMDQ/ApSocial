using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ApSocial.Controladora.Amistades;
using ApSocial.Controladora.Usuarios;
using ApSocial.Entidades;

namespace VistaWeb
{
    public partial class Amistad : System.Web.UI.Page
    {

        AmistadesController controladoraAmistades = new AmistadesController();
        UsuarioController controladoraUsuario = new UsuarioController();
        int usuario;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.usuario = Convert.ToInt32(Session["usuarioLogueado"].ToString());
            this.setPendingRequests();
        }

        private void setPendingRequests()
        {
            int pendientes = this.controladoraAmistades.getAllUsuariosSolicitudesFromUser(this.usuario).Count();
            this.solicitudesPendientesLbl.Text = pendientes.ToString();

            //Cargar el Literal con la lista de solicitudes
            List<Usuario> lista =  this.controladoraAmistades.getAllUsuariosSolicitudesFromUser(this.usuario);
            ListaSolicitudes.DataValueField = "Id";
            ListaSolicitudes.DataTextField = "FullName";
            ListaSolicitudes.DataSource = lista;
            ListaSolicitudes.DataBind();
        }

        protected void enviarSolicitud_Click(object sender, EventArgs e)
        {
            try {
                controladoraAmistades.solicitarAmistad(this.usuario, emailSolicitud.Text);
                this.resultadoSolicitud.Text = "<div class=\"alert alert-success alert-dismissable\">";
                this.resultadoSolicitud.Text += "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button>";
                this.resultadoSolicitud.Text += "La solicitud fue enviada correctamente a <strong>" + emailSolicitud.Text + "</strong></div>";
            } catch (Exception ex) {
                this.resultadoSolicitud.Text = "<div class=\"alert alert-danger alert-dismissable\">";
                this.resultadoSolicitud.Text += "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button>";
                this.resultadoSolicitud.Text += "<strong>Error!</strong> " + ex.Message + "</div>";

            }
        }

        protected void AceptarAmistad_Click(object sender, EventArgs e)
        {
            try {
                controladoraAmistades.aceptarAmistad(this.usuario, Convert.ToInt32(this.idSolicitante.Value));
                // Indicar con una alerta que se acepto a fulano de tal
                setPendingRequests();
            } catch (Exception ex) {
                throw ex;
            }
        }

        protected void RechazarAmistad_Click(object sender, EventArgs e)
        {
            try {
                controladoraAmistades.rechazarAmistad(this.usuario, Convert.ToInt32(this.idSolicitante.Value));
                // Indicar con una alerta que se rechazo a fulano de tal
                setPendingRequests();
            } catch (Exception ex) {
                throw ex;
            }
        }

    }
}
