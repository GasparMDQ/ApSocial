using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using ApSocial.DAO.BaseDeDatos;

namespace ApSocial.Controladora.UsuarioGrupos
{
    class Usuario_GrupoController
    {
        DAOUsuarios_grupos daoUsuariosGrupos = DAOUsuarios_grupos.Instance();
        public Usuario_Grupo newUsuarioGrupo(Usuario usuario, Grupos grupo)
        {
            try
            {
                return this.newUsuarioGrupo(usuario.Id, grupo.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Usuario_Grupo newUsuarioGrupo(int idUsuario, int idGrupo)
        {
            Usuario_Grupo usuarioGrupo;
            try
            {
                usuarioGrupo = new Usuario_Grupo(idUsuario, idGrupo);
                daoUsuariosGrupos.add(usuarioGrupo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return usuarioGrupo;
        }
        public List<Usuario_Grupo> getAllByUsuario(Usuario usuario)
        {
            try
            {
                return this.getAllByUsuario(usuario.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Usuario_Grupo> getAllByUsuario(int userId)
        {
            try
            {
                return daoUsuariosGrupos.searchByUsuario(userId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Usuario_Grupo> getAllByGrupo(Grupos grupo)
        {
            try
            {
                return this.getAllByGrupo(grupo.Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Usuario_Grupo> getAllByGrupo(int grupoID)
        {
            try
            {
                return daoUsuariosGrupos.searchAllBygrupo(grupoID);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void removeUsuarioGrupo(Usuario usuario, Grupos  grupo)
        {
            try
            {
                Usuario_Grupo usuarioGrupo = daoUsuariosGrupos.searchByUserAndGroup(grupo.Id,usuario.Id);
                daoUsuariosGrupos.remove(usuarioGrupo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void removeUsuarioGrupo(Usuario_Grupo usuarioGrupo)
        {
            try
            {
                daoUsuariosGrupos.remove(daoUsuariosGrupos.searchByUserAndGroup(usuarioGrupo.IdGrupo, usuarioGrupo.IdUsuario));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool isUserInGroup(int userID, int groupId) {
            try
            {
                bool rta = daoUsuariosGrupos.existeUsuarioEnGrupo(userID, groupId);
                return rta;
            }
            catch (Exception ex){
                throw ex;
            }
        }
    }
}
