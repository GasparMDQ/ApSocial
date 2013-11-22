using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using System.Data;

namespace ApSocial.DAO.BaseDeDatos
{
    public class DAOAlbum_fotos : DBCommonAccess, IDAO<Album_fotos>
    {
        private static DAOAlbum_fotos _instance;

        public DAOAlbum_fotos() { }

        public static DAOAlbum_fotos Instance()
        {
            if (_instance == null) {
                _instance = new DAOAlbum_fotos();
            }
            return _instance;
        }

        public List<Album_fotos> getAll()
        {
            string cmdText = "SELECT id, fecha_creado, mensaje, publico, usuario_origen FROM album_fotos";
            try {
                return this.searchBy(cmdText);
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        public void add(Album_fotos album_fotos)
        {
            string cmdText = "INSERT INTO album_fotos (fecha_creado, mensaje, publico, usuario_origen) VALUES (@Fecha, @Mensaje, @Publico, @Usuario)";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@Fecha", album_fotos.Fecha_creado);
            parametros.Add("@Mensaje", album_fotos.Mensaje);
            parametros.Add("@Publico", album_fotos.Publico);
            parametros.Add("@Usuario", album_fotos.Usuario_origen);
            try {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo insertar el estado en la base de datos", ex);
            }
        }

        public void modify(Album_fotos album_fotos)
        {
            string cmdText = "UPDATE album_fotos SET fecha_creado = @Fecha, mensaje = @Mensaje, publico = @Publico, usuario_origen = @Usuario WHERE id = @AlbumId";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@Fecha", album_fotos.Fecha_creado);
            parametros.Add("@Mensaje", album_fotos.Mensaje);
            parametros.Add("@Publico", album_fotos.Publico);
            parametros.Add("@Usuario", album_fotos.Usuario_origen);
            parametros.Add("@AlbumId", album_fotos.Id);
            try {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo modificar el album de fotos", ex);
            }
        }

        public void remove(Album_fotos album_fotos)
        {
            string cmdText = "DELETE from album_fotos WHERE id = @AlbumId";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@AlbumId", album_fotos.Id);
            try {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo borrar el estado", ex);
            }
        }

        public Album_fotos searchById(int id)
        {
            string cmdText = "SELECT id, fecha_creado, mensaje, publico, usuario_origen FROM album_fotos WHERE id = " + Convert.ToString(id);
            try {
                Album_fotos album_fotos = this.searchOneBy(cmdText);
                return album_fotos;
            } catch (Exception ex) {
                throw new Exception("No se encontro el album de fotos con id " + Convert.ToString(id), ex);
            }
        }

        public List<Album_fotos> searchByUserId(int id)
        {
            string cmdText = "SELECT id, fecha_creado, mensaje, publico, usuario_origen FROM album_fotos WHERE usuario_origen = " + Convert.ToString(id);
            try {
                List<Album_fotos> album_fotos = this.searchBy(cmdText);
                return album_fotos;
            } catch (Exception ex) {
                throw new Exception("No se encontraron albumes de fotos del usuario id " + Convert.ToString(id), ex);
            }
        }

        private Album_fotos searchOneBy(string cmdText)
        {
            try {

                DataTable dt = this.getData(cmdText);
                if (dt.Rows.Count > 1) {
                    throw new Exception("Se encontró más de un resultado");
                }

                foreach (DataRow dr in dt.Rows) {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    return this.getAlbumFotosFromDataRow(dr);
                }
                //Si no pasa por el foreach es porque no se encontro ningun album de fotos con el ID indicado
                throw new Exception("No se encontraron resultados");
            } catch (Exception ex) {
                throw new Exception("No se pudo ejecutar la consulta (DAO)", ex);
            }
        }

        private List<Album_fotos> searchBy(string cmdText)
        {
            try {
                DataTable dt = this.getData(cmdText);
                List<Album_fotos> lista = new List<Album_fotos>();
                foreach (DataRow dr in dt.Rows) {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    lista.Add(this.getAlbumFotosFromDataRow(dr));
                }
                return lista;
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        private Album_fotos getAlbumFotosFromDataRow(DataRow dr)
        {
            Album_fotos album_fotos = new Album_fotos(
                    dr["mensaje"].ToString(),
                    Convert.ToInt32(dr["usuario_origen"].ToString())
                );
            //Seteo el ID del Album de Fotos
            album_fotos.Id = (int)dr["id"];
            album_fotos.Fecha_creado = (DateTime)dr["fecha_creado"];

            //Devuelvo el album de fotos obtenido
            return album_fotos;
        }

    }
}
