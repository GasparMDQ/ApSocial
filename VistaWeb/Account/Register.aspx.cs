using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using ApSocial.Controladora.Usuarios;
using ApSocial.Entidades;

namespace VistaWeb.Account
{
    public partial class Register : System.Web.UI.Page
    {

        private UsuarioController controladora = new UsuarioController();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void CreateUserButton_Click(object sender, EventArgs e)
        {
            /**
             * Crear Usuario
             */
            try {
                string fotoUrl = this.UploadFile(Foto);
                DateTime fechaDeNacimiento = new DateTime(Convert.ToInt32(this.Anio.Text), Convert.ToInt32(this.Mes.SelectedValue), Convert.ToInt32(this.Dia.Text));
                controladora.nuevoUsuario(this.Email.Text, this.Password.Text, this.ConfirmPassword.Text, this.Nombre.Text, this.Apellido.Text, this.Residencia.Text, fechaDeNacimiento, fotoUrl);

                /** @todo autenticar y redireccionar al muro*/
            } catch (Exception ex) {
                var val = new CustomValidator() {
                    ErrorMessage = ex.Message,
                    Display = ValidatorDisplay.None,
                    IsValid = false,
                    ValidationGroup = "RegisterUserValidationGroup"
                };
                val.ServerValidate += (object source, ServerValidateEventArgs args) => { args.IsValid = false; };
                Page.Validators.Add(val);
                Page.Validate();
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
                        if (Foto.PostedFile.ContentLength < 1024000) {
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
                throw new Exception("No se seleccionó ningún archivo!");
            }
        }


    }
}
