using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using ApSocial.DAO.BaseDeDatos;
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
                daoFotos.add(foto);
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
            Fotos foto = daoFotos.searchById(id);
            return foto;
        }

        public void borrarFoto(Fotos foto)
        {
            daoFotos.remove(foto);
        }
    }
}
