﻿using System;
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
    public class PublicacionController
    {
        DAOPublicacion daoPublicacion = DAOPublicacion.Instance();
        private AmistadesController controladoraAmistad = new AmistadesController();
        private UsuarioController controladoraUsuario = new UsuarioController();
        private DAOUsuario_Grupo daoUsuarioGrupo = DAOUsuario_Grupo.Instance();


        public bool isPublic(Publicacion publicacion)
        {
            bool rta = true;
            if (publicacion.Grupo_destino == -1)
            {
                rta = false;
            } return rta;
        }





        public List<Publicacion> getPublicacionesPublicasByIDUsuario(int idUsuario)
        {
            //me da las publicaciones publicas de un usuario la uso luego recorriendo la lista de mis amigos 
            try
            {
                List<Publicacion> todasLaspublicaciones = daoPublicacion.getPublicacionesByidUsuario(idUsuario);
                List<Publicacion> publicacionesPublicas = new List<Publicacion>();
                foreach (Publicacion publicacion in todasLaspublicaciones)
                {
                    if (this.isPublic(publicacion))
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
                List<Publicacion> todasLaspublicaciones = daoPublicacion.getPublicacionesByidUsuario(idUsuario);
                List<Publicacion> publicacionesPrivadas = new List<Publicacion>();
                foreach (Publicacion publicacion in todasLaspublicaciones)
                {
                    if (!this.isPublic(publicacion))
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
                //le sumo mis publicaciones
                publicaciones.AddRange(daoPublicacion.getPublicacionesByidUsuario(idUsuario));
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
                listaPublicaciones = this.getPublicacionesPublicasDeMisAmigosYmias(usuarioId);
                listaPublicaciones.AddRange(getPublicacionesPublicasByIDUsuario(usuarioId));//falta ordenar la lista 
                //listaPublicaciones.Sort(
                return listaPublicaciones;

            }
            catch (Exception ex) { 
                throw  ex; 
            }
        }




    }
}

