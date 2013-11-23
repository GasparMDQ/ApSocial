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
using ApSocial.Controladora.Album;

namespace VistaEscritorio
{
    public partial class abAlbum : Form
    {
        PublicacionController controladoraPublicacion = new PublicacionController();
        FotoController controladoraFoto = new FotoController();
        AlbumController controladoraAlbum = new AlbumController();
        List<Fotos> fotosDelAlbum = new List<Fotos>();
        public int albumid = -1;
        
        public abAlbum()
        {
            InitializeComponent();
            cargarAlbums(comboMisAlbums);
        }

        public void cargarAlbums(ComboBox combo) {
            try
            {
                List<Album_fotos> list = controladoraAlbum.buscarPorUsuario(Session.IdUsuarioLogueado);
                combo.DataSource = list;
            }
            catch (Exception ex) {
                MessageBox.Show("no se pueden cargar los albums", ex.Message);
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // ver que si cancelo tengo q borrar todas las fotos que habia cargado  
        }



        private void btnNuevaFoto_Click(object sender, EventArgs e)
        {
            try
            {
                Album_fotos album = new Album_fotos(albumNameTXT.Text, Session.IdUsuarioLogueado);
                //albumid= necesito un metodo para buscar en el dao y q me devuelve el id del album q acabo de insertar
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
                    Album_fotos nuevoAlbum = new Album_fotos(albumNameTXT.Text, Session.IdUsuarioLogueado);
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

        private void borrarAlbumbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Album_fotos album = (Album_fotos)comboMisAlbums.SelectedItem;
                controladoraAlbum.eliminarAlbum(album.Id);
                cargarAlbums(comboMisAlbums);
            }
            catch (Exception ex) {
                MessageBox.Show("no se pudo borrar el album", ex.Message);
            }
        }



    }
}
