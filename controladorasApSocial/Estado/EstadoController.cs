﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
//using ApSocial.DAO.Lista;
using ApSocial.DAO.BaseDeDatos;

namespace ApSocial.Controladora.Estado
{
   public class EstadoController
    {
       DAOFotos daoFotos = DAOFotos.Instance();
       DAOEstados daoEstados = DAOEstados.Instance();
        public void nuevoEstado(int idUsuario, string mensaje, string nombreFoto, string url, List<Usuario> usuarios_etiquetados)
        {
            Fotos foto;
            Estados estado;
            try
            {
                foto = new Fotos(url,1);//Fix THIS
                daoFotos.add(foto);
                estado = new Estados(DateTime.Today, mensaje, idUsuario, foto.ToString());
                daoEstados.add(estado);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }


}
