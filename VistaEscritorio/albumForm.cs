using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ApSocial.Controladora.Publicaciones;
using ApSocial.Entidades;

namespace VistaEscritorio
{
    public partial class albumForm : Form
    {
        PublicacionController controladoraPublicacion = new PublicacionController();
        
        public albumForm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // ver que si cancelo tengo q borrar todas las fotos que habia cargado  
        }

      /*  private void btnNuevaFoto_Click(object sender, EventArgs e)
        {
            Album_fotos unAlbum;
            if (albumNameTXT.Text != "") {
                if (controladoraPublicacion.existePublicacion(albumNameTXT.Text)) { 
                    unAlbum=
                }
            }
        }*/
    }
}
