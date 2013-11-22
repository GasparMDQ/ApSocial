using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using ApSocial.DAO.Lista;
//using ApSocial.DAO.BaseDeDatos;
using ApSocial.Controladora.Amistades;
using ApSocial.Controladora.Usuarios;

namespace ApSocial.Controladora.Publicaciones
{
    /*
     ver muro me mustra las publicaciones mias y de mis amigos ordenadas por fecha
     */
    public class PublicacionController
    {
        private AmistadesController controladoraAmistad = new AmistadesController();
        private UsuarioController controladoraUsuario = new UsuarioController();
        private DAOUsuario_Grupo daoUsuarioGrupo = DAOUsuario_Grupo.Instance();
        DAOAlbum_fotos daoAlbum = DAOAlbum_fotos.Instance();
        DAOEstados daoEstados = DAOEstados.Instance();


        public List<Publicacion> getPublicacionesPublicasByIDUsuario(int idUsuario)
        {
            //me da las publicaciones publicas de un usuario la uso luego recorriendo la lista de mis amigos 
            try
            {
                List<Publicacion> todasLaspublicaciones = daoAlbum.albumByidUsuario(idUsuario);
                todasLaspublicaciones.AddRange(daoEstados.estadosByidUsuario(idUsuario));
                List<Publicacion> publicacionesPublicas = new List<Publicacion>();
                foreach (Publicacion publicacion in todasLaspublicaciones)
                {
                    if (publicacion.Publico)
                    {
                        publicacionesPublicas.Add(publicacion);
                    }
                } return publicacionesPublicas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Publicacion> getPublicacionesPrivadasByIdUsuario(int idUsuario)
        {
            //devuelve las publicaciones privadas de un usuario la uso luego para filtrar cuales podre ver yo
            try
            {
                List<Publicacion> todasLaspublicaciones = daoAlbum.albumByidUsuario(idUsuario);
                todasLaspublicaciones.AddRange(daoEstados.estadosByidUsuario(idUsuario));
                List<Publicacion> publicacionesPrivadas = new List<Publicacion>();
                foreach (Publicacion publicacion in todasLaspublicaciones)
                {
                    if (!publicacion.Publico)
                    {
                        publicacionesPrivadas.Add(publicacion);
                    }

                } return publicacionesPrivadas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Publicacion> getPublicacionesPublicasDeMisAmigosYmias(int idUsuario)
        {
            try
            {
                List<Usuario> usuariosAmigos = controladoraAmistad.getAllFriendsFromUser(idUsuario);
                List<Publicacion> publicaciones = new List<Publicacion>();
                foreach (Usuario usuario in usuariosAmigos)
                {
                    //voy concatenando todas las publicaciones que son publicas de mis amigos
                    publicaciones.AddRange(getPublicacionesPublicasByIDUsuario(usuario.Id));
                    
                }
                publicaciones.AddRange(daoEstados.estadosByidUsuario(idUsuario));
                
                return publicaciones;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Publicacion> getPublicacionesPrivadasDeMisAmigos(int idUsuario)
        {
           // me devuelve todas las publicaciones privadas de mis amigos que puedo ver
            List<Publicacion> publicacionesFiltradas = new List<Publicacion>();
            try
            {
                List<Usuario> usuariosAmigos = controladoraAmistad.getAllFriendsFromUser(idUsuario);
                List<Publicacion> publicacionesPrivadas;
                foreach (Usuario usuario in usuariosAmigos)
                {
                    publicacionesPrivadas = this.getPublicacionesPrivadasByIdUsuario(usuario.Id);
                    foreach (Publicacion publicacion in publicacionesPrivadas) { 
                        if( daoUsuarioGrupo.perteneceAlGrupo(idUsuario, publicacion.Grupo_destino)){
                            publicacionesFiltradas.Add(publicacion);
                        }
                    }
                }
                return publicacionesFiltradas;
            }catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Publicacion> verMuro(int usuarioId)
        {
            List<Publicacion> listaPublicaciones = new List<Publicacion>();
            try
            {
                crearObjetos();
                listaPublicaciones = this.getPublicacionesPublicasDeMisAmigosYmias(usuarioId);
                return listaPublicaciones;

            }
            catch (Exception ex) { 
                throw  ex; 
            }
        }

        public void crearObjetos()
        {
            Album_fotos album = new Album_fotos("album1", 1);
            Album_fotos album1 = new Album_fotos("album2", 2);
            Album_fotos album2 = new Album_fotos("album3", 3);
            Estados estado = new Estados("foto1", 1, "path");
            Estados estado2 = new Estados("foto2", 2, "path");
            Estados estado3 = new Estados("foto3", 3, "path");
            daoAlbum.add(album);
            daoAlbum.add(album1);
            daoAlbum.add(album2);
            daoEstados.add(estado);
            daoEstados.add(estado2);
            daoEstados.add(estado3);

        }
        



    }
}

