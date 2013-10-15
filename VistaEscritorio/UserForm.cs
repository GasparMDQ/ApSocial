using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApSocial.Controladora.Usuarios;
using ApSocial.Entidades;

namespace VistaEscritorio
{
    public partial class UserForm : Form
    {
        public static string ALTA="ALTA";
        public static string BAJA = "BAJA";
        public static string MODIFICAR = "MODIFICAR";

        private string intention;
        private UsuarioController controladora = new UsuarioController();

        public string Intention
        {
            get { return intention; }
            set { intention = value; }
        }

        public UserForm(string intencion)
        {
            InitializeComponent();

            Intention = intencion;
            fdnBox.MaxDate = DateTime.Today;

            switch (Intention) {
                case "BAJA":
                    tituloLbl.Text = this.Text = "Baja de Usuario";
                    botonBtn.Text = "Dar de Baja";
                    this.setBajaForm();
                    break;
                case "MODIFICAR":
                    tituloLbl.Text = this.Text = "Modificar Usuario";
                    botonBtn.Text = "Modificar";
                    this.setModiForm();
                    break;
                case "ALTA":
                    tituloLbl.Text = this.Text = "Alta de Nuevo Usuario";
                    botonBtn.Text = "Crear";
                    break;
                default:
                    throw new Exception("Intention no válida");
            }
        }

        private void setModiForm()
        {
            Usuario usuario = controladora.getUsuarioById(Session.IdUsuarioLogueado);
            this.setData(usuario);

            //Deshabilita los campos que no se utilizan con este intention
            emailBox.Enabled = false;
        }

        private void setBajaForm()
        {
            Usuario usuario = controladora.getUsuarioById(Session.IdUsuarioLogueado);
            this.setData(usuario);

            //Deshabilita los campos que no se utilizan con este intention
            emailBox.Enabled = false;
            nombreBox.Enabled = false;
            apellidoBox.Enabled = false;
            residenciaBox.Enabled = false;
            fdnBox.Enabled = false;
            fotoBox.Enabled = false;
            buscarArchivoBtn.Enabled = false;
        }

        private void setData(Usuario usuario)
        {
            emailBox.Text = usuario.Email;
            nombreBox.Text = usuario.Nombre;
            apellidoBox.Text = usuario.Apellido;
            residenciaBox.Text = usuario.Residencia;
            fdnBox.SetDate(usuario.FechaDeNacimiento);
            fotoBox.Text = usuario.Foto_usuario;
            fotoFrame.ImageLocation = usuario.Foto_usuario;
        }


        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void botonBtn_Click(object sender, EventArgs e)
        {
            switch (this.Intention) {
                case "BAJA":
                    try {
                        controladora.borrarUsuario(Session.IdUsuarioLogueado, password_checkBox.Text);
                        this.Close();
                        //do LogOut
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message, "Datos Invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "MODIFICAR":
                    try {
                        controladora.modificarUsuario(Session.IdUsuarioLogueado, emailBox.Text, passwordBox.Text, password_checkBox.Text, nombreBox.Text, apellidoBox.Text, residenciaBox.Text, fdnBox.SelectionStart, fotoBox.Text);
                        this.Close();
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message, "Datos Invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case "ALTA":
                default:
                    try {
                        controladora.nuevoUsuario(emailBox.Text, passwordBox.Text, password_checkBox.Text, nombreBox.Text, apellidoBox.Text, residenciaBox.Text, fdnBox.SelectionStart, fotoBox.Text);
                        this.Close();
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message, "Datos Invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
            }
            
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            fotoBox.Text = openFileDialog.FileName;
        }

        private void buscarArchivoBtn_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }
    }
}
