using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;

namespace ApSocial.DAO.Lista
{
    public class DAOUsuario:IDAO<Usuario>
    {
        List<Usuario> listaUsuarios = new List<Usuario>();
        int contador = 0;
        private static DAOUsuario _instance;

        public DAOUsuario()
        {
        }

        public static DAOUsuario Instance()
        {
            if (_instance == null)
            {
                _instance = new DAOUsuario();
            }
            return _instance;
        }

        public List<Usuario> getAll() { return listaUsuarios; }

        private int getId()
        {
            contador++;
            return contador;
        }


        public void add(Usuario usuario)
        {
            usuario.Id = this.getId();
            listaUsuarios.Add(usuario);
        }

        public Usuario searchById(int id)
        {
            foreach (Usuario usuario in listaUsuarios){
                if (usuario.Id == id){ return usuario; }
            }
            throw new Exception("El usuario con el id " + id.ToString() + " no existe");
        }

        public Usuario searchUsuarioByEmail(string email)
        {
            foreach (Usuario usuario in listaUsuarios){
                if (usuario.Email == email){ return usuario; }
            }
            throw new Exception("El usuario con el email "+email+" no existe");
        }

        public bool isEmailInUse(string email)
        {
            try {
                Usuario usuario = this.searchUsuarioByEmail(email);
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
            try {
                Usuario usuarioOld = this.searchById(usuario.Id);
                this.listaUsuarios.Remove(usuarioOld);
                this.add(usuario);
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
        public Usuario searchOneByEmail(string email) 
        {
            foreach (Usuario usuario in listaUsuarios)
            {
                if (usuario.Email == email) { return usuario; }
            }
            throw new Exception("no se encontro usuario con ese email");
        }
        }

}
