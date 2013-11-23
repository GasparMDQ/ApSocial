using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ApSocial.Entidades;
using ApSocial.Controladora.Usuarios;

using ApSocial.DAO.BaseDeDatos;
//using ApSocial.DAO.Lista;

namespace ApSocial.Controladora.Grupo
{

    public class GruposController
    {
        DAOGrupos dataGrupos = DAOGrupos.Instance();
        private UsuarioController controladoraUsuario = new UsuarioController();

        public bool perteneceAlGrupo(int userId, int groupId)
        {
            try {
                //return controladoraGrupoUsuario.isUserInGroup(userId, groupId);
                return true;
            } catch (Exception ex) {
                throw new Exception("No se pudo verificar si el usuario ID "+userId +" pertence al grupo ID "+groupId, ex);
            }
        }

    }
}
