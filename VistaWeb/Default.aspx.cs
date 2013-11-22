using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ApSocial.Controladora.Amistades;
using ApSocial.Controladora.Estado;
using ApSocial.Controladora.Publicaciones;
using ApSocial.Controladora.Usuarios;
using ApSocial.Entidades;

namespace VistaWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        private AmistadesController controladoraAmistad = new AmistadesController();
        private EstadoController controladoraEstado = new EstadoController();
        private PublicacionController controladoraPublicacion = new PublicacionController();
        private UsuarioController controladoraUsuario = new UsuarioController();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.loadFriends();
            this.loadStates();
        }

        public void loadFriends()
        {
            AmigosList.DataSource = null;
            AmigosList.DataSource = this.controladoraAmistad.getAllFriendsFromUser(Convert.ToInt32(Session["usuarioLogueado"].ToString()));
            this.AmigosList.DataBind();
        }

        public void loadStates()
        {
            List<Publicacion> publicaciones = controladoraPublicacion.verMuro(Convert.ToInt32(Session["usuarioLogueado"].ToString()));

            Publicaciones.Text = "";

            foreach (Publicacion publi in publicaciones) {
                Publicaciones.Text += controladoraUsuario.getUsuarioById(publi.Usuario_origen).FullName +
                    ": "+ publi.Mensaje + " | " + publi.Fecha_creado.ToString() + "<br />";
            }
            

        }

        protected void nuevoEstado_Click(object sender, EventArgs e)
        {
            try {
                string fotoUrl = this.UploadFile(estadoFoto);
                controladoraEstado.nuevoEstado(Convert.ToInt32(Session["usuarioLogueado"].ToString()), estadoMsg.Text, fotoUrl);
                estadoMsg.Text = "";
                estadoMsg.Attributes.Add("placeholder", "En que estas pensando ...");
                ContenedorFormulario.CssClass = "form-group";
                this.loadStates();
            } catch (Exception ex) {
                // Informar a la vista el error de la excepcion.
                estadoMsg.Attributes.Add("placeholder",ex.Message);
                ContenedorFormulario.CssClass = "form-group has-error";
            }
        }

        /**
         * Ver de mover este metodo a una clase base para que sea hereada por todas las paginas WEB que requieran de subida de fotos.
         * OPCIONAL - Parametrizar restricciones de tipo/tamaño
         */
        private string UploadFile(FileUpload Archivo)
        {
            if (Archivo.HasFile) {
                try {
                    if (Archivo.PostedFile.ContentType == "image/jpeg") {
                        if (estadoFoto.PostedFile.ContentLength < 1024000) {
                            string filename = Guid.NewGuid().ToString("N");
                            Archivo.SaveAs(Server.MapPath("~/images/") + filename);
                            return ResolveUrl("~/") + "images/" + filename;
                        } else {
                            throw new Exception("El archivo debe pesar menos de 1 mb!");
                        }
                    } else {
                        throw new Exception("Solo se aceptan archivos del tipo jpg!");
                    }
                } catch (Exception ex) {
                    throw ex;
                }
            } else {
                return null;
            }
        }

    }
}
