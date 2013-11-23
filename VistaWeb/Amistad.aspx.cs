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
            this.refreshData();
        }

        private void refreshData()
        {
            this.setPendingRequests();
            this.FriendList.RefreshData();
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
                this.showSuccess("La solicitud fue enviada correctamente a <strong>" + emailSolicitud.Text + "</strong>");
            } catch (Exception ex) {
                this.showError(ex.Message);
            }
        }

        protected void AceptarAmistad_Click(object sender, EventArgs e)
        {

            try {
                Usuario solictante = controladoraUsuario.getUsuarioById(Convert.ToInt32(this.idSolicitante.Value));
                controladoraAmistades.aceptarAmistad(this.usuario, solictante.Id);
                // Indicar con una alerta que se acepto a fulano de tal
                this.showSuccess("Se acepto la solicitud de <strong>" + solictante.FullName + "</strong>");
                this.refreshData();
                this.idSolicitante.Value = "0";
            } catch (Exception ex) {
                this.showError(ex.Message);
            }
        }

        protected void RechazarAmistad_Click(object sender, EventArgs e)
        {
            try {
                Usuario solictante = controladoraUsuario.getUsuarioById(Convert.ToInt32(this.idSolicitante.Value));
                controladoraAmistades.rechazarAmistad(this.usuario, solictante.Id);
                // Indicar con una alerta que se rechazo a fulano de tal
                this.showSuccess("Se rechazó la solicitud de <strong>" + solictante.FullName + "</strong>");
                this.refreshData();
                this.idSolicitante.Value = "0";
            } catch (Exception ex) {
                this.showError(ex.Message);
            }
        }

        private void showSuccess(string msg)
        {
            this.resultadoSolicitud.Text = "<div class=\"alert alert-success alert-dismissable\">";
            this.resultadoSolicitud.Text += "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button>";
            this.resultadoSolicitud.Text += msg + "</div>";
        }

        private void showError(string msg)
        {
            this.resultadoSolicitud.Text = "<div class=\"alert alert-danger alert-dismissable\">";
            this.resultadoSolicitud.Text += "<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button>";
            this.resultadoSolicitud.Text += "<strong>Error!</strong> " + msg + "</div>";
        }

    }
}
