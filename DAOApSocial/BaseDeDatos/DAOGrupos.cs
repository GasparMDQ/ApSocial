using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using System.Data;

namespace ApSocial.DAO.BaseDeDatos
{
    public class DAOGrupos : DBCommonAccess, IDAO<Grupos>
    {
        private static DAOGrupos _instance;

        public DAOGrupos() { }

        public static DAOGrupos Instance()
        {
            if (_instance == null) {
                _instance = new DAOGrupos();
            }
            return _instance;
        }

        public int add(Grupos grupo)
        {
            string cmdText = "INSERT INTO grupos (descripcion, sistema) VALUES (@Descripcion,@Sistema)";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@Descripcion", grupo.Descripcion);
            parametros.Add("@Sistema", grupo.Sistema);
            try {
                return this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo insertar el grupo en la base de datos", ex);
            }
        }


        public void remove(Grupos grupo)
        {
            string cmdText = "DELETE from grupos WHERE id = @GrupoId";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@GrupoId", grupo.Id);
            try {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo borrar el grupo", ex);
            }
        }


        public Grupos searchById(int id)
        {
            string cmdText = "SELECT id, descripcion, sistema FROM grupos WHERE id = " + Convert.ToString(id);
            try {
                Grupos grupo = this.searchOneBy(cmdText);
                return grupo;
            } catch (Exception ex) {
                throw new Exception("No se encontro el grupo con id " + Convert.ToString(id), ex);
            }
        }


        public void modify(Grupos grupo) 
        {
            string cmdText = "UPDATE grupos SET descripcion = @Descripcion, sistema = @Sistema WHERE id = @GrupoId";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@Descripcion", grupo.Descripcion);
            parametros.Add("@Sistema", grupo.Sistema);
            parametros.Add("@GrupoId", grupo.Id);
            try {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo modificar el grupo", ex);
            }
        }

        private List<Grupos> searchBy(string cmdText)
        {
            try {
                DataTable dt = this.getData(cmdText);
                List<Grupos> lista = new List<Grupos>();
                foreach (DataRow dr in dt.Rows) {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    lista.Add(this.getGrupoFromDataRow(dr));
                }
                return lista;
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        private Grupos searchOneBy(string cmdText)
        {
            try {

                DataTable dt = this.getData(cmdText);
                if (dt.Rows.Count > 1) {
                    throw new Exception("Se encontró más de un resultado");
                }

                foreach (DataRow dr in dt.Rows) {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    return this.getGrupoFromDataRow(dr);
                }
                //Si no pasa por el foreach es porque no se encontro ningun usuario con el ID indicado
                throw new Exception("No se encontraron resultados");
            } catch (Exception ex) {
                throw new Exception("No se pudo ejecutar la consulta (DAO)", ex);
            }
        }

        private Grupos getGrupoFromDataRow(DataRow dr)
        {

            Grupos grupo = new Grupos((string)dr["descripcion"]);
            //Seteo el ID de la Solicitud
            grupo.Id = (int)dr["id"];

            //Verifico si la solicitud fue aceptada
            if ((bool)dr["sistema"]) { grupo.Sistema = true; }

            //Devuelvo la solicitud obtenido
            return grupo;
        }


        public List<Grupos> getAll()
        {
            string cmdText = "SELECT id, descripcion, sistema FROM grupos";
            try {
                return this.searchBy(cmdText);
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

    }
}
