using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using System.Data;

namespace ApSocial.DAO.BaseDeDatos
{
    public class DAOFotos : DBCommonAccess, IDAO<Fotos>
    {
        private static DAOFotos _instance;

        public DAOFotos() { }

        public static DAOFotos Instance()
        {
            if (_instance == null) {
                _instance = new DAOFotos();
            }
            return _instance;
        }

        public List<Fotos> getAll()
        {
            string cmdText = "SELECT id, url, album_id FROM fotos";
            try {
                return this.searchBy(cmdText);
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        public void add(Fotos foto)
        {
            string cmdText = "INSERT INTO fotos (url, album_id) VALUES (@Url,@AlbumId)";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@Url", foto.Url);
            parametros.Add("@AlbumId", foto.AlbumId);
            try {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo insertar el estado en la base de datos", ex);
            }
        }

        public void modify(Fotos foto)
        {
            string cmdText = "UPDATE fotos SET url = @Url, album_id = @AlbumId, publico = @Publico WHERE id = @FotoId";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@Url", foto.Url);
            parametros.Add("@AlbumId", foto.AlbumId);
            parametros.Add("@FotoId", foto.Id);
            try {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo modificar la foto", ex);
            }
        }

        public void remove(Fotos foto)
        {
            string cmdText = "DELETE from fotos WHERE id = @FotoId";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@FotoId", foto.Id);
            try {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo borrar la foto", ex);
            }
        }

        public Fotos searchById(int id)
        {
            string cmdText = "SELECT id, url, album_id FROM fotos WHERE id = " + Convert.ToString(id);
            try {
                return this.searchOneBy(cmdText);
            } catch (Exception ex) {
                throw new Exception("No se encontro la foto con id " + Convert.ToString(id), ex);
            }
        }

        public List<Fotos> searchByAlbum(int Albumid)
        {
            string cmdText = "SELECT id, url, album_id FROM fotos WHERE album_id = " + Convert.ToString(Albumid);
            try {
                return this.searchBy(cmdText);
            } catch (Exception ex) {
                throw new Exception("No se encontraron fotos para el album con ID " + Convert.ToString(Albumid), ex);
            }
        }

        private Fotos searchOneBy(string cmdText)
        {
            try {
                DataTable dt = this.getData(cmdText);
                if (dt.Rows.Count > 1) {
                    throw new Exception("Se encontró más de un resultado");
                }

                foreach (DataRow dr in dt.Rows) {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    return this.getFotoFromDataRow(dr);
                }
                //Si no pasa por el foreach es porque no se encontro ninguna foto con el ID indicado
                throw new Exception("No se encontraron resultados");
            } catch (Exception ex) {
                throw new Exception("No se pudo ejecutar la consulta (DAO)", ex);
            }
        }

        private List<Fotos> searchBy(string cmdText)
        {
            try {
                DataTable dt = this.getData(cmdText);
                List<Fotos> lista = new List<Fotos>();
                foreach (DataRow dr in dt.Rows) {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    lista.Add(this.getFotoFromDataRow(dr));
                }
                return lista;
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        private Fotos getFotoFromDataRow(DataRow dr)
        {
            Fotos foto = new Fotos(
                    dr["url"].ToString(),
                    (int)dr["album_id"]
                );
            //Seteo el ID de la Foto
            foto.Id = (int)dr["id"];

            //Devuelvo la foto obtenida
            return foto;
        }
    }
}
