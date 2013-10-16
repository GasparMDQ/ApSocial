using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using ApSocial.DAO.BaseDeDatos;
//using ApSocial.DAO.Lista;

namespace ApSocial.Controladora.Usuarios
{

    public class UsuarioController
    {
        DAOUsuario dataUsuario = DAOUsuario.Instance();

        public void nuevoUsuario(string email, string password, string password_check, string nombre, string apellido, string residencia, DateTime fdn, string foto, byte[] foto_stream)
        {
            Usuario usuario = new Usuario(apellido, nombre, email, password, residencia, fdn, foto);
            usuario.Foto_stream = foto_stream;

            Validator validador = this.validateUsuario(usuario, password_check);
            if (existeUsuario(usuario)) {
                validador.addError("-El usuario con el correo ingresado ya existe");
            }
            if (validador.Valid) {
                /** Llamar al DAO */
                dataUsuario.add(usuario);
            } else {
                /** Throw Exception */
                throw new Exception(validador.Message);
            }
        }

        public void nuevoUsuario(string email, string password, string password_check, string nombre, string apellido, string residencia, DateTime fdn, string foto)
        {
            Usuario usuario = new Usuario(apellido, nombre, email, password, residencia, fdn, foto);

            Validator validador = this.validateUsuario(usuario, password_check);
            if (existeUsuario(usuario)) {
                validador.addError("-El usuario con el correo ingresado ya existe");
            }
            if (validador.Valid) {
                /** Llamar al DAO */
                dataUsuario.add(usuario);
            } else {
                /** Throw Exception */
                throw new Exception(validador.Message);
            }
        }

        public void modificarUsuario(int id, string email, string password, string password_check, string nombre, string apellido, string residencia, DateTime fdn, string foto)
        {
            Usuario usuario = new Usuario(apellido, nombre, email, password, residencia, fdn, foto);

            Validator validador = this.validateUsuario(usuario, password_check);
            if (validador.Valid) {
                /** Llamar al DAO */
                usuario.Id = id;
                dataUsuario.modify(usuario);
            } else {
                /** Throw Exception */
                throw new Exception(validador.Message);
            }
        }

        public void borrarUsuario(int id, string password_check)
        {
            try {
                Usuario usuario = dataUsuario.searchById(id);
                Validator validador = this.validateUsuario(usuario, password_check);
                if (validador.Valid) {
                    /** Llamar al DAO */
                    dataUsuario.remove(usuario);
                } else {
                    /** Throw Exception */
                    throw new Exception(validador.Message);
                }
            } catch (Exception ex) {
                throw new Exception("No se pudo borrar el usuario", ex);
            }
        }

        private Validator validateUsuario(Usuario usuario)
        {
            /**
             * Datos obligatorios
             * 
             * -Nombre
             * -Foto (consultar)
             * -Email
             */
            Validator validador = new Validator();
            if (usuario.Nombre == "") {
                validador.addError("-Debe ingresar un nombre");
            }
            if (usuario.Email == "") {
                validador.addError("-Debe ingresar un email");
            }

            if (usuario.Password == "") {
                validador.addError("-Debe ingresar una contraseña");
            }

            if (usuario.Foto_usuario == "") {
                validador.addError("-Debe seleccionar una foto");
            }

            return validador;
        }

        private Validator validateUsuario(Usuario usuario, string password_check)
        {
            Validator validador = validateUsuario(usuario);
            if (usuario.Password != password_check) {
                validador.addError("-Las contraseñas no coinciden");
            }
            return validador;
        }

        public Usuario getUsuarioById(int id)
        {
            try {
                return dataUsuario.searchById(id);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public Usuario getUsuarioByEmail(string email)
        {
            try {
                return dataUsuario.searchOneByEmail(email);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public bool existeUsuario(Usuario usuario)
        {
            try {
                return dataUsuario.isEmailInUse(usuario.Email);
            } catch (Exception ex) {
                return ex == null;
            }
        }

        public bool existeUsuario(int id)
        {
            try {
                return dataUsuario.isEmailInUse(this.getUsuarioById(id).Email);
            } catch (Exception ex) {
                return ex == null;
            }
        }

        public List<Usuario> getAllUsers()
        {
            try {
                return dataUsuario.getAllEnabled();
            } catch (Exception ex) {
                throw ex;
            }
        }

        public int isCredentialValid(string email, string password)
        {
            try {
                Usuario usuario = dataUsuario.searchOneByEmail(email);
                if (password == usuario.Password) {
                    if (usuario.isEnabled()) {
                        return usuario.Id;
                    } else {
                        throw new Exception("El usuario fue borrado");
                    }
                } else {
                    throw new Exception("Contraseña Incorrecta");
                }
            } catch (Exception ex) {
                throw ex;
            }

        }
    }
}
