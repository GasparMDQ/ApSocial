using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using ApSocial.Controladora.Usuarios;

using ApSocial.DAO.BaseDeDatos;
//using ApSocial.DAO.Lista;

namespace ApSocial.Controladora.Grupos
{

    public class GruposController
    {
        DAOSolicitud_Amistad dataGrupos = DAOSolicitud_Amistad.Instance();
        private UsuarioController controladoraUsuario = new UsuarioController();

    }
}
