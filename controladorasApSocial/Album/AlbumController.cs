using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
//using ApSocial.DAO.Lista;
using ApSocial.DAO.BaseDeDatos;

namespace ApSocial.Controladora.Album
{
   public class AlbumController
    {
        DAOAlbum_fotos daoAlbum = DAOAlbum_fotos.Instance();
        public void nuevoAlbum(string mensaje, bool publico, int usuario_origen, List<Fotos> lista_fotos)
        {
            Album_fotos album;
            try
            {
                album = new Album_fotos(DateTime.Today, mensaje, usuario_origen);
                daoAlbum.add(album);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
