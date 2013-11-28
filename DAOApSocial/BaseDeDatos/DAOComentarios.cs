using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using System.Data;

namespace ApSocial.DAO.BaseDeDatos
{
    public class DAOComentarios : DBCommonAccess, IDAO<Comentarios>
    {
        private static DAOComentarios _instance;

        public DAOComentarios() { }

        public static DAOComentarios Instance()
        {
            if (_instance == null) {
                _instance = new DAOComentarios();
            }
            return _instance;
        }

        public List<Comentarios> getAll()
        {
            string cmdText = "SELECT id, idPublicacion, fechaCreacion, mensaje, usuarioId FROM comentarios";
            try {
                return this.searchBy(cmdText);
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        public void add(Comentarios comentario)
        {
            string cmdText;
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();

            cmdText = "INSERT INTO comentarios (idPublicacion, fechaCreacion, mensaje, usuarioId) OUTPUT INSERTED.ID VALUES (@Pub,@Fecha,@Mensaje,@Usuario)";
            parametros.Add("@Pub", comentario.IdPublicacion);
            parametros.Add("@Fecha", comentario.Fecha_creacion);
            parametros.Add("@Mensaje", comentario.Mensaje);
            parametros.Add("@Usuario", comentario.UsuarioId);
            try {
                int resultado = this.setData(cmdText, parametros, true);
            } catch (Exception ex) {
                throw new Exception("No se pudo insertar el comentario en la base de datos", ex);
            }
        }

        public void modify(Comentarios comentario)
        {
            string cmdText = "UPDATE comentarios SET idPublicacion = @Pub, fechaCreacion = @Fecha, mensaje = @Mensaje, usuarioId = @Usuario WHERE id = @CommentId";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@Pub", comentario.IdPublicacion);
            parametros.Add("@Fecha", comentario.Fecha_creacion);
            parametros.Add("@Mensaje", comentario.Mensaje);
            parametros.Add("@Usuario", comentario.UsuarioId);
            parametros.Add("@CommentId", comentario.Id);
            try {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo modificar el comentario", ex);
            }
        }

        public void remove(Comentarios comentario)
        {
            string cmdText = "DELETE from comentarios WHERE id = @CommentId";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@CommentId", comentario.Id);
            try {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo borrar el comentario", ex);
            }
        }

        public Comentarios searchById(int id)
        {
            string cmdText = "SELECT id, idPublicacion, fechaCreacion, mensaje, usuarioId FROM comentarios WHERE id = " + Convert.ToString(id);
            try {
                Comentarios comentario = this.searchOneBy(cmdText);
                return comentario;
            } catch (Exception ex) {
                throw new Exception("No se encontro el comentario con id " + Convert.ToString(id), ex);
            }
        }

        public List<Comentarios> searchByPublicacionId(int id)
        {
            string cmdText = "SELECT id, idPublicacion, fechaCreacion, mensaje, usuarioId FROM comentarios WHERE idPublicacion = " + Convert.ToString(id);
            try {
                List<Comentarios> comentarios = this.searchBy(cmdText);
                return comentarios;
            } catch (Exception ex) {
                throw new Exception("No se encontraron comentarios para la publicacion con id " + Convert.ToString(id), ex);
            }
        }

        private Comentarios searchOneBy(string cmdText)
        {
            try {

                DataTable dt = this.getData(cmdText);
                if (dt.Rows.Count > 1) {
                    throw new Exception("Se encontró más de un resultado");
                }

                foreach (DataRow dr in dt.Rows) {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    return this.getComentarioFromDataRow(dr);
                }
                //Si no pasa por el foreach es porque no se encontro ningun estado con el ID indicado
                throw new Exception("No se encontraron resultados");
            } catch (Exception ex) {
                throw new Exception("No se pudo ejecutar la consulta (DAO)", ex);
            }
        }

        private List<Comentarios> searchBy(string cmdText)
        {
            try {
                DataTable dt = this.getData(cmdText);
                List<Comentarios> lista = new List<Comentarios>();
                foreach (DataRow dr in dt.Rows) {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    lista.Add(this.getComentarioFromDataRow(dr));
                }
                return lista;
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        private Comentarios getComentarioFromDataRow(DataRow dr)
        {
            Comentarios comentario = new Comentarios(
                dr["mensaje"].ToString(),
                Convert.ToInt32(dr["usuarioId"].ToString()),
                Convert.ToInt32(dr["idPublicacion"].ToString())
            );

            //Seteo el ID del comentario y su fecha original de creacion
            comentario.Id = (int)dr["id"];
            comentario.Fecha_creacion = (DateTime)dr["fechaCreacion"];

            //Devuelvo el comentario obtenido
            return comentario;
        }
    }
}
