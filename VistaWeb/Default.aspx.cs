using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ApSocial.Controladora.Amistades;
using ApSocial.Controladora.Estado;
using ApSocial.Entidades;

namespace VistaWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        private AmistadesController controladoraAmistad = new AmistadesController();
        private EstadoController controladoraEstado = new EstadoController();

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

        protected void nuevoEstado_Click(object sender, EventArgs e)
        {
            try {
                //@TODO Verificar que el estado no este vacio!!!!!!!
                string fotoUrl = this.UploadFile(estadoFoto);
                controladoraEstado.nuevoEstado(Convert.ToInt32(Session["usuarioLogueado"].ToString()), estadoMsg.Text, fotoUrl);
                estadoMsg.Text = "";
            } catch (Exception ex) {
                throw ex;
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
