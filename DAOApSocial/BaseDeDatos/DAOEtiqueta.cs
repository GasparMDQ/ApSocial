using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using System.Data;

namespace ApSocial.DAO.BaseDeDatos
{
    public class DAOEtiqueta : DBCommonAccess, IDAO<Etiqueta>
    {
        private static DAOEtiqueta _instance;

        public DAOEtiqueta() { }

        public static DAOEtiqueta Instance()
        {
            if (_instance == null) {
                _instance = new DAOEtiqueta();
            }
            return _instance;
        }

        public List<Etiqueta> getAll()
        {
            string cmdText = "SELECT fotoId, usuarioId FROM etiqueta";
            try {
                return this.searchBy(cmdText);
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        public void add(Etiqueta etiqueta)
        {
            string cmdText = "INSERT INTO etiqueta (fotoId, usuarioId) VALUES (@FotoId,@UsuarioId)";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@FotoId", etiqueta.FotoId);
            parametros.Add("@UsuarioId", etiqueta.UsuarioId);
            try {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo insertar el estado en la base de datos", ex);
            }
        }

        public void modify(Etiqueta etiqueta)
        {
            throw new Exception("No se puede modificar una etiqueta");
        }

        public void remove(Etiqueta etiqueta)
        {
            string cmdText = "DELETE from etiqueta WHERE usuarioId = @UsuarioId AND fotoId = @FotoId";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@UsuarioId", etiqueta.UsuarioId);
            parametros.Add("@FotoId", etiqueta.FotoId);
            try {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo borrar la etiqueta", ex);
            }
        }

        public Etiqueta searchById(int id)
        {
            throw new Exception("No se puede buscar por ID una etiqueta");
        }

        private Etiqueta searchOneBy(string cmdText)
        {
            try {

                DataTable dt = this.getData(cmdText);
                if (dt.Rows.Count > 1) {
                    throw new Exception("Se encontró más de un resultado");
                }

                foreach (DataRow dr in dt.Rows) {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    return this.getEtiquetaFromDataRow(dr);
                }
                //Si no pasa por el foreach es porque no se encontro ninguna etiqueta con el ID indicado
                throw new Exception("No se encontraron resultados");
            } catch (Exception ex) {
                throw new Exception("No se pudo ejecutar la consulta (DAO)", ex);
            }
        }

        private List<Etiqueta> searchBy(string cmdText)
        {
            try {
                DataTable dt = this.getData(cmdText);
                List<Etiqueta> lista = new List<Etiqueta>();
                foreach (DataRow dr in dt.Rows) {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    lista.Add(this.getEtiquetaFromDataRow(dr));
                }
                return lista;
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        private Etiqueta getEtiquetaFromDataRow(DataRow dr)
        {
            Etiqueta etiqueta = new Etiqueta(
                    (int)dr["usuarioId"],
                    (int)dr["fotoId"]
                );

            //Devuelvo la etiqueta obtenida
            return etiqueta;
        }
    }
}
