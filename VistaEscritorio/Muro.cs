using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApSocial.Entidades;
using ApSocial.Controladora.Usuarios;
using ApSocial.Controladora.Publicaciones;

namespace VistaEscritorio
{
    public partial class Muro : Form
    {
        UsuarioController controladoraUsuarios = new UsuarioController();
        PublicacionController controladoraPublicaciones = new PublicacionController();

        public Muro()
        {
            InitializeComponent();
           // inicializarListaPublicaciones(controladoraPublicaciones.getPublicacionesPublicasDeMisAmigosYmias(Session.IdUsuarioLogueado));

        }



        public void inicializarListaPublicaciones(List<Publicacion> miLista) 
        {
            try
            {
                foreach (Publicacion publicacion in miLista)
                {
                    string nombre = "- " + (controladoraUsuarios.getUsuarioById(publicacion.Id)).Nombre + (controladoraUsuarios.getUsuarioById(publicacion.Id)).Apellido + " -";
                    listPublicaciones.Items.Add(publicacion.Mensaje.Substring(0, 30) + nombre);

                }
            }
            catch {
                MessageBox.Show("error");
            } 
        }

        private void listPublicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
