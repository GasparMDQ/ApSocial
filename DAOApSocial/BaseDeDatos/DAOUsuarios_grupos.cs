using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using System.Data;

namespace ApSocial.DAO.BaseDeDatos
{
    public class DAOUsuarios_grupos: DBCommonAccess, IDAO<Usuario_Grupo>
    {
        private static DAOUsuarios_grupos _instance;

        public DAOUsuarios_grupos() { }

        public static DAOUsuarios_grupos Instance()
        {
            if (_instance == null) {
                _instance = new DAOUsuarios_grupos();
            }
            return _instance;
        }
        public Usuario_Grupo searchById(int id) {
            throw new Exception("No se puede buscar por ID una etiqueta");
        }
        public int add(Usuario_Grupo usuarioGrupo)
        {
            string cmdText = "INSERT INTO usuarios_grupos (idUsuario,idGrupo) VALUES (@idUsuario,@idGrupo)";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@idUsuario", usuarioGrupo.IdUsuario);
            parametros.Add("@idGrupo", usuarioGrupo.IdGrupo);
            try
            {
                return this.setData(cmdText, parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo insertar el usuario al grupo", ex);
            }
        }
        public void modify(Usuario_Grupo usuarioGrupo)
        {
            throw new Exception("No se puede modificar usuario-grupo");
        }
        public void remove(Usuario_Grupo usuarioGrupo)
        {
            string cmdText = "DELETE from usuarios_grupos WHERE idGrupo=@idGrupo  AND idUsuario = @idUsuario";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@idGrupo", usuarioGrupo.IdGrupo);
            parametros.Add("@idUsuario", usuarioGrupo.IdUsuario);
            try
            {
                this.setData(cmdText, parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo borrar la etiqueta", ex);
            }
        }
        public List<Usuario_Grupo> getAll()
        {
            string cmdText = "SELECT idGrupo, idUsuario FROM usuarios_grupos";
            try
            {
                return this.searchBy(cmdText);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }
        private List<Usuario_Grupo> searchBy(string cmdText)
        {
            try
            {
                DataTable dt = this.getData(cmdText);
                List<Usuario_Grupo> lista = new List<Usuario_Grupo>();
                foreach (DataRow dr in dt.Rows)
                {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    lista.Add(this.getUsuarioGrupoFromDataRow(dr));
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }
        private Usuario_Grupo getUsuarioGrupoFromDataRow(DataRow dr)
        {
            Usuario_Grupo usuarioGrupo = new Usuario_Grupo(
                    (int)dr["idUsuario"],
                    (int)dr["idGrupo"]
                );
            return usuarioGrupo;
        }
        public bool existeUsuarioEnGrupo(int userID, int groupId)
        {
            string cmdText = "SELECT idGrupo, idUsuario FROM usuarios_grupos WHERE idUsuario = \'" + userID + "\' AND idGrupo = \'" + groupId + "\'";
            Usuario_Grupo rta = null;
            try
            {
                rta= this.searchOneBy(cmdText);
                if (rta != null) { return true; }
                else { return false; }
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontro etiqueta para el usuario con ID " + userID + " en la foto con ID " + groupId, ex);
            }
        }
        private Usuario_Grupo searchOneBy(string cmdText)
        {
            try
            {

                DataTable dt = this.getData(cmdText);
                if (dt.Rows.Count > 1)
                {
                    throw new Exception("Se encontró más de un resultado");
                }

                foreach (DataRow dr in dt.Rows)
                {
                    return this.getUsuarioGrupoFromDataRow(dr);
                }
                throw new Exception("No se encontraron resultados");
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo ejecutar la consulta (DAO)", ex);
            }
        }
        public List<Usuario_Grupo> searchByUsuario(int userId)
        {
            string cmdText = "SELECT idGrupo, idUsuario FROM usuarios_grupos WHERE idUsuario = \'" + userId + "\'";
            try
            {
                List<Usuario_Grupo> lista = this.searchBy(cmdText);
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontraron grupos para el usuario con ID " + userId, ex);
            }
        }
        public List<Usuario_Grupo> searchAllBygrupo(int grupoID)
        {
            string cmdText = "SELECT idGrupo, idUsuario FROM usuarios_grupos WHERE idGrupo = \'" + grupoID + "\'";
            try
            {
                List<Usuario_Grupo> lista = this.searchBy(cmdText);
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontraron usuarios-grupos para el grupo con ID " + grupoID, ex);
            }
        }
        public Usuario_Grupo searchByUserAndGroup(int grupoID, int userId)
        {
            string cmdText = "SELECT idGrupo, idUsuario FROM usuarios_grupos WHERE idUsuario = \'" + userId + "\' AND idGrupo = \'" + grupoID + "\'";
            try
            {
                return this.searchOneBy(cmdText);
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontro UsuarioGrupo para el usuario con ID " + userId + " grupo con ID " + grupoID, ex);
            }
        }
 
    }
}
