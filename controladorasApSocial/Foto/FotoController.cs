using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using ApSocial.DAO.BaseDeDatos;
//using ApSocial.DAO.Lista;
using ApSocial.Controladora.Etiquetas;

namespace ApSocial.Controladora.Foto
{
    public class FotoController
    {
        DAOFotos daoFotos = DAOFotos.Instance();
        private EtiquetaController etiquetaController = new EtiquetaController();

        public Fotos nuevaFoto(int albumId, string url, List<Usuario> usuariosEtiquetados)
        {
            Fotos foto;
            try {
                foto = new Fotos(url, albumId);
                int fotoId = daoFotos.add(foto);
                foto.Id = fotoId;
            } catch (Exception ex) {
                throw ex;
            }

            //Una vez creada la foto se generan las etiquetas correspondientes para cada usuario
            foreach (Usuario usuario in usuariosEtiquetados) {
                try {
                    etiquetaController.newEtiqueta(foto, usuario);
                } catch (Exception ex) {
                    throw ex;
                }
            }
            return foto;
        }

        public Fotos buscarFoto(int id)
        {
            try {
                return daoFotos.searchById(id);
            } catch (Exception ex) {
                throw ex;
            }
        }

       public List<Fotos> buscarFotosPorAlbum(Album_fotos album)
        {
            try {
                return daoFotos.searchByAlbum(album.Id);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void borrarFoto(Fotos foto)
        {
            daoFotos.remove(foto);
        }

    }
}
