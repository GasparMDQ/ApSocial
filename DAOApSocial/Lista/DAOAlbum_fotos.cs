using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;

namespace ApSocial.DAO.Lista
{
    public class DAOAlbum_fotos:IDAO <Album_fotos>
    {
        List<Album_fotos> listaAlbum = new List<Album_fotos>();
        int contadorAlbum = 0;
        private static DAOAlbum_fotos _instance;

        public DAOAlbum_fotos()
        {
        }
        public static DAOAlbum_fotos Instance()
        {
            if (_instance == null)
            {
                _instance = new DAOAlbum_fotos();
            }
            return _instance;
        }
        private int getId()
        {
            contadorAlbum++;
            return contadorAlbum;
        }

        public void add(Album_fotos album) 
        {
            album.Id = getId();
            listaAlbum.Add(album);
        }
        public Album_fotos searchById(int id)
        {
            foreach (Album_fotos album in listaAlbum)
            {
                if (album.Id == id) { return album; }
            }
            throw new Exception("Album no encontrado con ese id");
        }

        public void remove(Album_fotos album)
        {
            try
            {
                this.searchById(album.Id);
            }
            catch (Exception ex) { throw ex; }
            listaAlbum.Remove(album);
        }

        public void modify(Album_fotos albumModificado)
        {
            try
            {
                Album_fotos aGuardado = searchById(albumModificado.Id);
                listaAlbum.Remove(aGuardado);
                listaAlbum.Add(albumModificado);
            }
            catch (Exception ex)
            {
                throw new Exception("El Album no pudo ser modificado ", ex);

            }
        }
        public List<Album_fotos> getAll() { return listaAlbum; }

        public List<Publicacion> albumByidUsuario(int idUsuario)
        {
            try
            {
                List<Publicacion> listaById = new List<Publicacion>();
                foreach (Publicacion publicacion in listaAlbum)
                {
                    if (publicacion.Usuario_origen == idUsuario)
                    {
                        listaById.Add(publicacion);
                    }
                } return listaById;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Album_fotos> searchByUserId(int id) 
        { 
            try{
                List<Album_fotos> albumsDeUnUsuario=new List<Album_fotos>;
                foreach(Album_fotos album in listaAlbum){
                    if(album.Usuario_origen==id){
                        albumsDeUnUsuario.Add(album);
                    }
                }return albumsDeUnUsuario;
            }catch(Exception ex){
                throw ex;
            }
        }


    }
}
