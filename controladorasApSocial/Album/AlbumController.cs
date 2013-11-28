using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
//using ApSocial.DAO.Lista;
using ApSocial.DAO.BaseDeDatos;
using ApSocial.Controladora.Foto;
using ApSocial.Controladora.Etiquetas;

namespace ApSocial.Controladora.Album
{
    public class AlbumController
    {
        DAOAlbum_fotos daoAlbum = DAOAlbum_fotos.Instance();


        public int nuevoAlbum(string mensaje, int usuario_origen)
        {
            Album_fotos album;
            try {
                album = new Album_fotos(mensaje, usuario_origen);
                return daoAlbum.add(album);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void eliminarAlbum(int albumId)
        {
            //Para borrar un album, se debe eliminar previamente, sus fotos y etiquetas
            try {
                Album_fotos album = daoAlbum.searchById(albumId);
                FotoController fotoController = new FotoController();
                EtiquetaController etiquetaController = new EtiquetaController();
                // Se borran sus fotos
                foreach (Fotos foto in fotoController.buscarFotosPorAlbum(album)) {
                    // Borrar etiquetas de la foto (si las hubiera)
                    foreach (Etiqueta etiqueta in etiquetaController.getAllByFoto(foto)) {
                        // Se borra la etiqueta
                        etiquetaController.removeEtiqueta(etiqueta);
                    }
                    // Se borra la foto
                    fotoController.borrarFoto(foto);
                }
                // Se borra el album
                daoAlbum.remove(album);
            } catch (Exception ex) {
                throw new Exception("No se pudo eliminar el album con ID " + albumId, ex);
            }
        }
        public List<Album_fotos> buscarPorUsuario(int idUsuario) {
            try
            {
                return daoAlbum.searchByUserId(idUsuario);
            }
            catch (Exception ex){
                throw ex;
            }
        }
    }
}
