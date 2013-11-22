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
            try
            {
                inicializarListaPublicaciones(controladoraPublicaciones.verMuro(Session.IdUsuarioLogueado));
            }catch (Exception ex){
                MessageBox.Show("error al cargar las publicaciones",ex.Message);
            }
        }



        public void inicializarListaPublicaciones(List<Publicacion> miLista) 
        {
            try
            {
              
                foreach (Publicacion publicacion in miLista)
                {
                    listPublicaciones.Items.Add(publicacion);

                }
            }
            catch {
                MessageBox.Show("error");
            } 
        }
        

        private void listPublicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Publicacion publicacion=(Publicacion)listPublicaciones.SelectedItem;
            txtDetalle.Text = publicacion.Mensaje;
        }
    }
}
