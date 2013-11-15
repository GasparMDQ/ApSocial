using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using ApSocial.DAO.Lista;

namespace ApSocial.Controladora.Foto
{
   public class FotoController
    {
        DAOFotos daoFotos = DAOFotos.Instance();
        public Fotos nuevaFoto(string nombre, string url, List<Usuario> usuariosEtiquetados)
        {
            Fotos foto;
            try
            {
                foto = new Fotos(url);
                daoFotos.add(foto);
            }
            catch (Exception ex)
            {
                throw ex;
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
