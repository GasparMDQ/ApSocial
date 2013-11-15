using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;

namespace ApSocial.DAO.Lista
{
   public class DAOUsuario_Grupo
    {
        List<Usuario_Grupo> listaUsuarioGrupo = new List<Usuario_Grupo>();

        public List<Usuario_Grupo> ListaPublicaciones
        {
            get { return listaUsuarioGrupo; }
            set { listaUsuarioGrupo = value; }
        }
        int contadorUsuarioGrupo=0;
        
        private static DAOUsuario_Grupo _instance;

        public DAOUsuario_Grupo()
        {
        }

        private int getId(){
            contadorUsuarioGrupo++;
            return contadorUsuarioGrupo;
        }

        public static DAOUsuario_Grupo Instance()
        {
            if (_instance == null)
            {
                _instance = new DAOUsuario_Grupo();
            }
            return _instance;
        }
        public List<Usuario_Grupo> getAll() { return listaUsuarioGrupo; }


        public Usuario_Grupo searchById(int id)
        {
            foreach (Usuario_Grupo usuarioGrupo in this.listaUsuarioGrupo)
            {
                if (usuarioGrupo.Id == id) { return usuarioGrupo; }
            }

            throw new Exception("Usuario y grupos no encontrados con ese id");
        }

        public void add(Usuario_Grupo usuarioGrupo)
        {
            usuarioGrupo.Id= getId();
            listaUsuarioGrupo.Add(usuarioGrupo);

        }

        public void remove(Usuario_Grupo usuarioGrupo) 
        {
            try {
                this.searchById(usuarioGrupo.Id);
            }catch(Exception ex){ throw ex; }
            listaUsuarioGrupo.Remove(usuarioGrupo);
        }

        public void modify(Usuario_Grupo usuarioGrupoModificado)
        {
            try
            {
                Usuario_Grupo usuarioGrupoGrabado = searchById(usuarioGrupoModificado.Id);
                listaUsuarioGrupo.Remove(usuarioGrupoGrabado);
                listaUsuarioGrupo.Add(usuarioGrupoModificado);
            }
            catch (Exception ex){ 
                throw new Exception("No puede ser modificado el usuario Grupo" ,ex); 
            }
        
        }
        public bool perteneceAlGrupo(int idUsuario, int idGrupo)
        {
            foreach (Usuario_Grupo usuarioGrupo in listaUsuarioGrupo)
            {
                if (usuarioGrupo.IdUsuario == idUsuario && usuarioGrupo.IdGrupo==idGrupo) { return true; }
            }
            throw new Exception("El usuario no pertenece al grupo ");
        }
    }
}
