using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using ApSocial.DAO.Lista;

namespace ApSocial.Controladora.Estado
{
   public class EstadoController
    {
       DAOFotos daoFotos = DAOFotos.Instance();
       DAOEstados daoEstados = DAOEstados.Instance();
        public void nuevoEstado(int idUsuario, string mensaje, string nombreFoto, string url, List<Usuario> usuarios_etiquetados, bool publico)
        {
            Fotos foto;
            Estados estado;
            try
            {
                foto = new Fotos(nombreFoto, url, usuarios_etiquetados);
                daoFotos.add(foto);
                estado = new Estados(foto, DateTime.Today, mensaje, publico, idUsuario);
                daoEstados.add(estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
