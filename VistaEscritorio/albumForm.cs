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
using ApSocial.Controladora.Foto;

namespace VistaEscritorio
{
    public partial class albumForm : Form
    {
        PublicacionController controladoraPublicacion = new PublicacionController();
        FotoController controladoraFoto = new FotoController();
        List<Fotos> fotosDelAlbum = new List<Fotos>();
        
        public albumForm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // ver que si cancelo tengo q borrar todas las fotos que habia cargado  
        }



        private void btnNuevaFoto_Click(object sender, EventArgs e)
        {
            try
            {
                nuevaFoto newPic = new nuevaFoto();
                newPic.ShowDialog();
                int fotoId = newPic.IdFoto;
                if (fotoId != -1)
                {
                    listFotos.Items.Add(controladoraFoto.buscarFoto(fotoId));
                }
            }
            catch (Exception ex){
                MessageBox.Show("error al cargar la foto  " + ex.Message);
            }

        }

        private void btnGuardarAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                    Album_fotos nuevoAlbum = new Album_fotos(DateTime.Today, albumNameTXT.Text, true, Session.IdUsuarioLogueado, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se guardar el album" + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection fotos = new ListBox.SelectedObjectCollection(listFotos);
            fotos = listFotos.SelectedItems;
            if (listFotos.SelectedIndex != -1)
            {
                Fotos foto = (Fotos)listFotos.SelectedItem;
                controladoraFoto.borrarFoto(foto);
                listFotos.Items.Remove(foto);

            }
            else {
                MessageBox.Show("Debe seleccionar un elemento de la lista");
            }
        }



    }
}
