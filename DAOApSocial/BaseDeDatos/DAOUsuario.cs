using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using System.Data;

namespace ApSocial.DAO.BaseDeDatos
{
    public class DAOUsuario : DBCommonAccess, IDAO<Usuario>
    {
        private static DAOUsuario _instance;

        public DAOUsuario() { }

        public static DAOUsuario Instance()
        {
            if (_instance == null) {
                _instance = new DAOUsuario();
            }
            return _instance;
        }

        public List<Usuario> getAll()
        {
            string cmdText = "SELECT id, apellido, email, fechaDeNacimiento, nombre, password, residencia, foto_usuario, enabled, foto_stream FROM usuarios";
            try {
                return this.searchBy(cmdText);
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        public void add(Usuario usuario)
        {
            string cmdText = "insert into usuarios (apellido, nombre, email, password, residencia, foto_usuario, fechaDeNacimiento, enabled, foto_stream) values (@Apellido,@Nombre,@Email,@Password,@Residencia,@FotoUsuario,@FechaDeNacimiento,@Enabled,@fotoStream)";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@Apellido", usuario.Apellido);
            parametros.Add("@Nombre", usuario.Nombre);
            parametros.Add("@Email", usuario.Email);
            parametros.Add("@Password", usuario.Password);
            parametros.Add("@Residencia", usuario.Residencia);
            parametros.Add("@FotoUsuario", usuario.Foto_usuario);
            parametros.Add("@FechaDeNacimiento", usuario.FechaDeNacimiento);
            parametros.Add("@Enabled", usuario.isEnabled());
            parametros.Add("@FotoStream", (object)usuario.Foto_stream ?? DBNull.Value);
            try
            {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo insertar el usuario en la base de datos", ex);
            }
        }

        private Usuario searchOneBy(string cmdText)
        {
            try {

                DataTable dt = this.getData(cmdText);
                if (dt.Rows.Count > 1) {
                    throw new Exception("Se encontró más de un resultado");
                }

                foreach (DataRow dr in dt.Rows) {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    return this.getUsuarioFromDataRow(dr);
                }
                //Si no pasa por el foreach es porque no se encontro ningun usuario con el ID indicado
                throw new Exception("No se encontraron resultados");
            } catch (Exception ex) {
                throw new Exception("No se pudo ejecutar la consulta (DAO)", ex);
            }
        }

        private List<Usuario> searchBy(string cmdText)
        {
            try {
                DataTable dt = this.getData(cmdText);
                List<Usuario> lista = new List<Usuario>();
                foreach (DataRow dr in dt.Rows) {
                    //Chequear que traiga reconozca correctamente los tipos casteados
                    lista.Add(this.getUsuarioFromDataRow(dr));
                }
                return lista;
            } catch (Exception ex) {
                throw new Exception("No se pudieron cargar los datos (DAO)", ex);
            }
        }

        public Usuario searchById(int id)
        {
            string cmdText = "SELECT id, apellido, email, fechaDeNacimiento, nombre, password, residencia, foto_usuario, enabled, foto_stream FROM usuarios WHERE id = " + Convert.ToString(id);
            try
            {
                Usuario usuario = this.searchOneBy(cmdText);
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("No se encontro el usuario con id "+Convert.ToString(id), ex);
            }
        }

        public Usuario searchOneByEmail(string email)
        {
            string cmdText = "SELECT id, apellido, email, fechaDeNacimiento, nombre, password, residencia, foto_usuario, enabled, foto_stream FROM usuarios WHERE email = \'"+email+"\'";
            try {
                Usuario usuario = this.searchOneBy(cmdText);
                return usuario;
            } catch (Exception ex) {
                throw new Exception("El usuario con el email " + email + " no existe", ex);
            }
        }

        public bool isEmailInUse(string email)
        {
            try {
                Usuario usuario = this.searchOneByEmail(email);
            } catch (Exception ex) {
                return ex==null;
            }
            return true;
        }


        public void remove(Usuario usuario)
        {
            usuario.Disable();
            try {
                this.modify(usuario);
            } catch (Exception ex) {
                throw new Exception("No se pudo borrar el usuario", ex);
            }
        }

        public void modify(Usuario usuario)
        {
            string cmdText = "update usuarios set apellido = @Apellido, nombre = @Nombre, email = @Email, password = @Password, residencia = @Residencia, foto_usuario = @FotoUsuario, fechaDeNacimiento = @FechaDeNacimiento, enabled = @Enabled, foto_stream = @FotoStream WHERE id = @UsuarioId";
            Dictionary<string, Object> parametros = new Dictionary<string, Object>();
            parametros.Add("@Apellido", usuario.Apellido);
            parametros.Add("@Nombre", usuario.Nombre);
            parametros.Add("@Email", usuario.Email);
            parametros.Add("@Password", usuario.Password);
            parametros.Add("@Residencia", usuario.Residencia);
            parametros.Add("@FotoUsuario", usuario.Foto_usuario);
            parametros.Add("@FechaDeNacimiento", usuario.FechaDeNacimiento);
            parametros.Add("@Enabled", usuario.isEnabled());
            parametros.Add("@FotoStream", usuario.Foto_stream);
            parametros.Add("@UsuarioId", usuario.Id);
            try {
                this.setData(cmdText, parametros);
            } catch (Exception ex) {
                throw new Exception("No se pudo modificar el usuario", ex);
            }
        }

        public List<Usuario> getAllEnabled()
        {
            List<Usuario> listaEnabled = new List<Usuario>();
            foreach(Usuario usuario in this.getAll() ){
                if (usuario.isEnabled()) { listaEnabled.Add(usuario); }
            }
            return listaEnabled;
        }

        private Usuario getUsuarioFromDataRow(DataRow dr)
        {
            Usuario usuario = new Usuario(
                    dr["apellido"].ToString(),
                    dr["nombre"].ToString(),
                    dr["email"].ToString(),
                    dr["password"].ToString().Trim(),
                    dr["residencia"].ToString(),
                    (DateTime)dr["fechaDeNacimiento"],
                    dr["foto_usuario"].ToString()
                );
            //Seteo el ID del Usuario
            usuario.Id = (int)dr["id"];

            //Verifico si el usuario fue borrado (logicamente) o no
            if (!(bool)dr["enabled"]) { usuario.Disable(); }

            //Agrego el Stream de la Foto
            usuario.Foto_stream = (byte[])dr["foto_stream"];

            //Devuelvo el usuario obtenido
            return usuario;
        }
    } //End Class
} //End NameSpace