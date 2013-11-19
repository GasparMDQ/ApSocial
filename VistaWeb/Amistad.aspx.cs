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
            String contenidoLiteral = "";
            foreach(Usuario user in lista){
                contenidoLiteral += "<option value=\""+user.Id+"\">"+user.Nombre+" "+user.Apellido+"</option>";
            }
            this.OpcionesSolicitud.Text = contenidoLiteral;

            //@todo implementar ajax para levantar los datos del usuario seleccionado en el select
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

    }
}
