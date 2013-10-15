using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using ApSocial.DAO.Lista;
using ApSocial.Controladora.Amistades;
using ApSocial.Controladora.Usuarios;

namespace ApSocial.Controladora.Publicaciones
{
    /*
     ver muro me mustra las publicaciones mias y de mis amigos ordenadas por fecha
     */
    class PublicacionController
    {
        DAOPublicacion daoPublicacion = DAOPublicacion.Instance();
        private AmistadesController controladoraAmistad = new AmistadesController();
        private UsuarioController controladoraUsuario = new UsuarioController();
        private DAOUsuario_Grupo daoUsuarioGrupo = DAOUsuario_Grupo.Instance();


        public bool isPublic(Publicacion publicacion)
        { 
            /*bool rta=true;
            if (publicacion.Grupo_destino == -1) {
                rta = false;
            } return rta;
             */
            return true;             
       }

        

        public List<Publicacion> getPublicacionesByUsuario(int idUsuario) {
            try
            {
                return this.getPublicacionesByUsuario(idUsuario);
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public List<Publicacion> getPublicacionesPublicasByIDUsuario(int idUsuario) {
            try{
                List<Publicacion> todasLaspublicaciones= daoPublicacion.getPublicacionesByidUsuario(idUsuario);
                List<Publicacion> publicacionesPublicas=new List<Publicacion>();
                foreach(Publicacion publicacion in todasLaspublicaciones){
                    if(this.isPublic(publicacion)){
                        publicacionesPublicas.Add(publicacion);
                    }
                }return publicacionesPublicas;
            }catch (Exception ex){
                throw ex;
            }
        }

        public List<Publicacion> getPublicacionesPrivadasByIdUsuario(int idUsuario) {
            try{
                List<Publicacion> todasLaspublicaciones= daoPublicacion.getPublicacionesByidUsuario(idUsuario);
                List<Publicacion> publicacionesPrivadas=new List<Publicacion>();
                foreach(Publicacion publicacion in todasLaspublicaciones){
                    if (!this.isPublic(publicacion)) {
                        publicacionesPrivadas.Add(publicacion);
                    }

                }return publicacionesPrivadas;
            }catch (Exception ex){
                throw ex;
            }
        }
        
       
        public List<Publicacion> getPublicacionesPublicasDeMisAmigos(int idUsuario) {
            try{
                List<Usuario> usuariosAmigos= controladoraAmistad.getAllFriendsFromUser(idUsuario);
                List<Publicacion> publicaciones=new List<Publicacion>();
                foreach (Usuario usuario in usuariosAmigos) { 
                    publicaciones.Concat(getPublicacionesPublicasByIDUsuario(usuario.Id));
                }
                return publicaciones;
            }catch (Exception ex){
                throw ex;
            }
        }
      /*  public List<Publicacion> getPublicacionesPrivadasDeMisAmigos(int idUsuario)
        {
            try
            {
                List<Usuario> usuariosAmigos = controladoraAmistad.getAllFriendsFromUser(idUsuario);
                List<Publicacion> publicacionesPrivadas;
                List<Publicacion> publicacionesFiltradas = new List<Publicacion>();
                foreach (Usuario usuario in usuariosAmigos)
                {
                    publicacionesPrivadas = this.getPublicacionesPrivadasByIdUsuario(usuario.Id);
                    foreach (Publicacion publicacion in publicacionesPrivadas) { 
                        if(
                    }
                    
                }
                return publicacionesFiltradas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/

        public void nuevoEstado(int idUsuario, string mensaje, Fotos fotos) { 

            // fijarse de poasar todos los parametros para las fotos y hacer el new de fotos , captar excepciones
            //Estados estado = new Estados(idUsuario, DateTime.Today, mensaje, fotos);

        }





        
    }
}
