using System;
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
        DAOEstados daoEstados = DAOEstados.Instance();

        public void nuevoEstado(int idUsuario, string mensaje, string url)
        {
            Estados estado;
            try {
                if (mensaje == "") {
                    throw new Exception("Debe ingresar un mensaje");
                }
                estado = new Estados(mensaje, idUsuario, url);
                daoEstados.add(estado);
            } catch (Exception ex) {
                throw ex;
            }

        }
    }

}
