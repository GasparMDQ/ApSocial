using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using System.Data;

namespace ApSocial.DAO.BaseDeDatos
{
    public class DAOSolicitud_Amistad : DBCommonAccess, IDAO<Solicitud_Amistad>
    {
        private static DAOSolicitud_Amistad _instance;

        public DAOSolicitud_Amistad() { }

        public static DAOSolicitud_Amistad Instance()
        {
            if (_instance == null) {
                _instance = new DAOSolicitud_Amistad();
            }
            return _instance;
        }

        public int add(Solicitud_Amistad solicitud)
        {
            string cmdText = "INSERT INTO solicitud_amistad (solicitante, solicitado, aceptada) VALUES (@Solicitante,@Solicitado,@Aceptada)";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@Solicitante", solicitud.Solicitante);
            parametros.Add("@Solicitado", solicitud.Solicitado);
            parametros.Add("@Aceptada", solicitud.Aceptada);
            try {
                return this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo insertar la solicitud en la base de datos", ex);
            }
        }

        public void remove(Solicitud_Amistad solicitud)
        {
            string cmdText = "DELETE from solicitud_amistad WHERE id = @SolicitudId";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@SolicitudId", solicitud.Id);
            try {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo borrar la solicitud", ex);
            }
        }


        public Solicitud_Amistad searchById(int id)
        {
            string cmdText = "SELECT id, solicitante, solicitada, aceptada FROM solicitud_amistad WHERE id = " + Convert.ToString(id);
            try {
                Solicitud_Amistad solicitud = this.searchOneBy(cmdText);
                return solicitud;
            } catch (Exception ex) {
                throw new Exception("No se encontro la solicitud con id " + Convert.ToString(id), ex);
            }
        }

        public void modify(Solicitud_Amistad solicitud) 
        {
            string cmdText = "UPDATE solicitud_amistad SET solicitante = @Solicitante, solicitado = @Solicitado, aceptada = @Aceptada WHERE id = @SolicitudId";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@Solicitante", solicitud.Solicitante);
            parametros.Add("@Solicitado", solicitud.Solicitado);
            parametros.Add("@Aceptada", solicitud.Aceptada);
            parametros.Add("@SolicitudId", solicitud.Id);
            try {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo modificar la solicitud", ex);
            }
        }

        public List<Solicitud_Amistad> getAll()
        {
            string cmdText = "SELECT id, solicitante, solicitado, aceptada FROM solicitud_amistad";
            try {
                return this.searchBy(cmdText);
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        public List<Solicitud_Amistad> getAllFromUser(Usuario usuario)
        {
            string cmdText = "SELECT id, solicitante, solicitado, aceptada FROM solicitud_amistad WHERE solicitante = " + usuario.Id;
            try {
                return this.searchBy(cmdText);
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        public List<Solicitud_Amistad> getAllToUser(Usuario usuario)
        {
            string cmdText = "SELECT id, solicitante, solicitado, aceptada FROM solicitud_amistad WHERE solicitado = " + usuario.Id;
            try {
                return this.searchBy(cmdText);
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        public List<Solicitud_Amistad> getAllFriendsFromUser(Usuario usuario)
        {
            string cmdText = "SELECT id, solicitante, solicitado, aceptada FROM solicitud_amistad WHERE aceptada = @Aceptada AND (solicitado = @Solicitado OR solicitante = @Solicitante)";
            try {
                Dictionary<string, Object> parametros = new Dictionary<string, Object>();
                parametros.Add("@Solicitante", usuario.Id);
                parametros.Add("@Solicitado", usuario.Id);
                parametros.Add("@Aceptada", true);
                return this.searchBy(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        public List<Solicitud_Amistad> getAllNotFriendsFromUser(Usuario usuario)
        {
            string cmdText = "SELECT id, solicitante, solicitado, aceptada FROM solicitud_amistad WHERE aceptada = @Aceptada AND solicitado = @Solicitado";
            try {
                Dictionary<string, Object> parametros = new Dictionary<string, Object>();
                parametros.Add("@Solicitado", usuario.Id);
                parametros.Add("@Aceptada", false);
                return this.searchBy(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        public Solicitud_Amistad getOneByUsers(int usuarioSolicitante, int usuarioSolicitado)
        {
            string cmdText = "SELECT id, solicitante, solicitado, aceptada FROM solicitud_amistad WHERE (solicitado = @Solicitado AND solicitante = @Solicitante) OR (solicitado = @Solicitante AND solicitante = @Solicitado)";
            try {
                Dictionary<string, Object> parametros = new Dictionary<string, Object>();
                parametros.Add("@Solicitante", usuarioSolicitante);
                parametros.Add("@Solicitado", usuarioSolicitado);
                return this.searchOneBy(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }



        private Solicitud_Amistad searchOneBy(string cmdText)
        {
            try {

                DataTable dt = this.getData(cmdText);
                if (dt.Rows.Count > 1) {
                    throw new Exception("Se encontró más de un resultado");
                }

                foreach (DataRow dr in dt.Rows) {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    return this.getSolicitudFromDataRow(dr);
                }
                //Si no pasa por el foreach es porque no se encontro ningun usuario con el ID indicado
                throw new Exception("No se encontraron resultados");
            } catch (Exception ex) {
                throw new Exception("No se pudo ejecutar la consulta (DAO)", ex);
            }
        }

        private Solicitud_Amistad searchOneBy(string cmdText, Dictionary<string, Object> listaParametros)
        {
            try {

                DataTable dt = this.getData(cmdText, listaParametros);
                if (dt.Rows.Count > 1) {
                    throw new Exception("Se encontró más de un resultado");
                }

                foreach (DataRow dr in dt.Rows) {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    return this.getSolicitudFromDataRow(dr);
                }
                //Si no pasa por el foreach es porque no se encontro ningun usuario con el ID indicado
                throw new Exception("No se encontraron resultados");
            } catch (Exception ex) {
                throw new Exception("No se pudo ejecutar la consulta (DAO)", ex);
            }
        }

        private List<Solicitud_Amistad> searchBy(string cmdText)
        {
            try {
                DataTable dt = this.getData(cmdText);
                List<Solicitud_Amistad> lista = new List<Solicitud_Amistad>();
                foreach (DataRow dr in dt.Rows) {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    lista.Add(this.getSolicitudFromDataRow(dr));
                }
                return lista;
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        private List<Solicitud_Amistad> searchBy(string cmdText, Dictionary<string, Object> listaParametros)
        {
            try {
                DataTable dt = this.getData(cmdText, listaParametros);
                List<Solicitud_Amistad> lista = new List<Solicitud_Amistad>();
                foreach (DataRow dr in dt.Rows) {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    lista.Add(this.getSolicitudFromDataRow(dr));
                }
                return lista;
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }


        private Solicitud_Amistad getSolicitudFromDataRow(DataRow dr)
        {

            Solicitud_Amistad solicitud = new Solicitud_Amistad(
                    (int)dr["solicitante"],
                    (int)dr["solicitado"]
                );
            //Seteo el ID de la Solicitud
            solicitud.Id = (int)dr["id"];

            //Verifico si la solicitud fue aceptada
            if ((bool)dr["aceptada"]) { solicitud.Aceptada = true; }

            //Devuelvo la solicitud obtenido
            return solicitud;
        }

    }
}
