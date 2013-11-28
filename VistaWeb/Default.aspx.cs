using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ApSocial.Controladora.Amistades;
using ApSocial.Controladora.Estado;
using ApSocial.Controladora.Usuarios;
using ApSocial.Controladora.Comentario;
using ApSocial.Entidades;

namespace VistaWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        private AmistadesController controladoraAmistad = new AmistadesController();
        private EstadoController controladoraEstado = new EstadoController();
        private UsuarioController controladoraUsuario = new UsuarioController();
        private ComentariosController controladoraComentario = new ComentariosController();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                this.refreshData();
            }
        }

        private void refreshData()
        {
            this.loadStates();
            this.FriendList.RefreshData();
        }

        public void loadStates()
        {
            List<Estados> estados = controladoraEstado.getEstadosForWallByUser(Convert.ToInt32(Session["usuarioLogueado"].ToString()));
            Publicaciones.DataSource = estados;
            Publicaciones.DataBind();
        }

        protected void nuevoEstado_Click(object sender, EventArgs e)
        {
            try {
                string fotoUrl = this.UploadFile(estadoFoto);
                controladoraEstado.nuevoEstado(Convert.ToInt32(Session["usuarioLogueado"].ToString()), estadoMsg.Text, fotoUrl);
                estadoMsg.Text = "";
                estadoMsg.Attributes.Add("placeholder", "En que estas pensando ...");
                ContenedorFormulario.CssClass = "form-group";
                this.refreshData();
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

        protected void Publicaciones_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "newComment") {
                int pubId = Convert.ToInt32(e.CommandArgument.ToString());
                Repeater repeater = (Repeater)source;
                Control FooterTemplate = repeater.Controls[repeater.Controls.Count - 1];
                TextBox messageBox = FooterTemplate.FindControl("newComentario") as TextBox;
                string mensaje = messageBox.Text;

                try {
                    controladoraComentario.nuevoComentario(Convert.ToInt32(Session["usuarioLogueado"].ToString()), mensaje, pubId);
                    this.refreshData();
                } catch (Exception ex) {
                    throw ex;
                }
            }
        }

    }
}
