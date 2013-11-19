using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using System.Data;

namespace ApSocial.DAO.BaseDeDatos
{
    public class DAOEstados : DBCommonAccess, IDAO<Estados>
    {
        private static DAOEstados _instance;

        public DAOEstados() { }

        public static DAOEstados Instance()
        {
            if (_instance == null) {
                _instance = new DAOEstados();
            }
            return _instance;
        }

        public List<Estados> getAll()
        {
            string cmdText = "SELECT id, fecha_creado, mensaje, publico, usuario_origen, foto FROM estados";
            try {
                return this.searchBy(cmdText);
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        public void add(Estados estado)
        {
            string cmdText = "INSERT INTO estados (fecha_creado, mensaje, publico, usuario_origen, foto) VALUES (@Fecha,@Mensaje,@Publico,@Usuario,@Foto)";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@Fecha", estado.Fecha_creado);
            parametros.Add("@Mensaje", estado.Mensaje);
            parametros.Add("@Publico", estado.Publico);
            parametros.Add("@Usuario", estado.Usuario_origen);
            parametros.Add("@Foto", estado.Foto_estado);
            try {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo insertar el estado en la base de datos", ex);
            }
        }

        public void modify(Estados estado)
        {
            string cmdText = "UPDATE estados SET fecha_creado = @Fecha, mensaje = @Mensaje, publico = @Publico, usuario_origen = @Usuario, foto = @Foto WHERE id = @EstadoId";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@Fecha", estado.Fecha_creado);
            parametros.Add("@Mensaje", estado.Mensaje);
            parametros.Add("@Publico", estado.Publico);
            parametros.Add("@Usuario", estado.Usuario_origen);
            parametros.Add("@Foto", estado.Foto_estado);
            parametros.Add("@EstadoId", estado.Id);
            try {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo modificar el estado", ex);
            }
        }

        public void remove(Estados estado)
        {
            string cmdText = "DELETE from estados WHERE id = @EstadoId";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@EstadoId", estado.Id);
            try {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo borrar el estado", ex);
            }
        }

        public Estados searchById(int id)
        {
            string cmdText = "SELECT id, fecha_creado, mensaje, publico, usuario_origen, foto FROM estados WHERE id = " + Convert.ToString(id);
            try {
                Estados estado = this.searchOneBy(cmdText);
                return estado;
            } catch (Exception ex) {
                throw new Exception("No se encontro el estado con id " + Convert.ToString(id), ex);
            }
        }

        private Estados searchOneBy(string cmdText)
        {
            try {

                DataTable dt = this.getData(cmdText);
                if (dt.Rows.Count > 1) {
                    throw new Exception("Se encontró más de un resultado");
                }

                foreach (DataRow dr in dt.Rows) {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    return this.getEstadoFromDataRow(dr);
                }
                //Si no pasa por el foreach es porque no se encontro ningun estado con el ID indicado
                throw new Exception("No se encontraron resultados");
            } catch (Exception ex) {
                throw new Exception("No se pudo ejecutar la consulta (DAO)", ex);
            }
        }

        private List<Estados> searchBy(string cmdText)
        {
            try {
                DataTable dt = this.getData(cmdText);
                List<Estados> lista = new List<Estados>();
                foreach (DataRow dr in dt.Rows) {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    lista.Add(this.getEstadoFromDataRow(dr));
                }
                return lista;
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        private Estados getEstadoFromDataRow(DataRow dr)
        {
            Estados estado;
            if (dr["grupo"].ToString() != null) {
                estado = new Estados(
                    dr["mensaje"].ToString(),
                    Convert.ToInt32(dr["usuario_origen"].ToString()),
                    Convert.ToInt32(dr["grupo"].ToString()),
                    dr["foto"].ToString()
                 );
            } else {
                estado = new Estados(
                    dr["mensaje"].ToString(),
                    Convert.ToInt32(dr["usuario_origen"].ToString()),
                    dr["foto"].ToString()
                );
            }
            //Seteo el ID del Estado
            estado.Id = (int)dr["id"];
            estado.Fecha_creado = (DateTime)dr["fecha_creado"];

            //Devuelvo el estado obtenido
            return estado;
        }
    }
}
