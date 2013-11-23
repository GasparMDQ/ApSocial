using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace ApSocial.DAO.BaseDeDatos
{
    public abstract class DBCommonAccess
    {
        SqlConnection cn = new SqlConnection(ApSocial.DAO.Properties.Settings.Default.AplicacionSocialConnectionString);

        /**
         * Conecta a la DB
         */
        private void Conectar()
        {
            if (cn.State == ConnectionState.Open) {
                throw new Exception("Conexion ya abierta");
            }
            cn.Open();
        }

        /**
         * Desconecta a la DB
         */

        private void Desconectar()
        {
            if (cn.State == ConnectionState.Closed) {
                throw new Exception("Conexión ya cerrada");
            }
            cn.Close();
        }

        /**
         * Carga datos en un DT
         */

        public DataTable getData(string cmdText)
        {
            DataTable dt = new DataTable();
            try {
                using (SqlCommand cmd = new SqlCommand(cmdText, cn)) {
                    Conectar();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    Desconectar();
                }
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DBCommonAccess)", ex);
            }
            return dt;
        }

        public DataTable getData(string cmdText, Dictionary<string, Object> listaParametros)
        {
            DataTable dt = new DataTable();
            try {
                using (SqlCommand cmd = new SqlCommand(cmdText, cn)) {
                    foreach (KeyValuePair<string, Object> parametro in listaParametros) {
                        cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
                    }
                    Conectar();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                    Desconectar();
                }
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DBCommonAccess)", ex);
            }
            return dt;
        }

        /**
         * Si se pasa TRUE el tercer parametro, la QUERY debe ser del tipo INSERT y con la cadena OUTPUD INSERTED.ID en ella
         * De esta manera, se devolvera el ID del registro insertado.
         * En caso de pasar FALSE el tercer parametro, el comportamiento es el mismo que si se omitiera
         */
        public int setData(string cmdText, Dictionary<string, Object> listaParametros, bool isNew)
        {
            int res;
            using (SqlCommand cmd = new SqlCommand(cmdText, cn)) {
                foreach (KeyValuePair<string, Object> parametro in listaParametros) {
                    cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
                }
                Conectar();
                try {
                    if (isNew) {
                        res = (int)cmd.ExecuteScalar();
                    } else {
                        res = cmd.ExecuteNonQuery();
                    }
                } catch (Exception ex) {
                    throw new Exception("No se pudo insertar el dato", ex);
                } finally {
                    Desconectar();
                }
            }
            return res;
        }

        /**
         * Se devuelve la cantidad de filas afectadas por la consulta
         */
        public int setData(string cmdText, Dictionary<string, Object> listaParametros)
        {
            int res;
            using (SqlCommand cmd = new SqlCommand(cmdText, cn)) {
                foreach (KeyValuePair<string, Object> parametro in listaParametros) {
                    cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
                }
                Conectar();
                try {
                    res = cmd.ExecuteNonQuery();
                } catch (Exception ex) {
                    throw new Exception("No se pudo insertar el dato", ex);
                } finally {
                    Desconectar();
                }
            }
            return res;
        }

    }
}
