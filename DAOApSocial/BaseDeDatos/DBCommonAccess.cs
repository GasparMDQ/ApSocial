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
        //@todo Verificar que la DB con sus tablas exista. Ejecutar SCRIPTs correspondientes
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

        public void setData(string cmdText, Dictionary<string, Object> listaParametros)
        {
            using (SqlCommand cmd = new SqlCommand(cmdText, cn)) {
                foreach (KeyValuePair<string, Object> parametro in listaParametros) {
                    cmd.Parameters.AddWithValue(parametro.Key, parametro.Value);
                }

                Conectar();
                try {
                    int res = cmd.ExecuteNonQuery();
                } catch (Exception ex) {
                    throw new Exception("No se pudo insertar el dato", ex);
                } finally {
                    Desconectar();
                }
            }
        }

    }
}
