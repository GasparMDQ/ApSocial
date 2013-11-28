using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
//using ApSocial.DAO.Lista;
using ApSocial.DAO.BaseDeDatos;
using ApSocial.Controladora.Usuarios;
using ApSocial.Controladora.Amistades;
using ApSocial.Controladora.Comentario;

namespace ApSocial.Controladora.Estado
{
    public class EstadoController
    {
        DAOEstados dataEstados = DAOEstados.Instance();
        UsuarioController usuariosController = new UsuarioController();
        AmistadesController amistadesController = new AmistadesController();
        ComentariosController controladoraComentarios = new ComentariosController();

        public void nuevoEstado(int idUsuario, string mensaje, string url)
        {
            Estados estado;
            try {
                if (mensaje == "") {
                    throw new Exception("Debe ingresar un mensaje");
                }
                estado = new Estados(mensaje, idUsuario, url);
                dataEstados.add(estado);
            } catch (Exception ex) {
                throw ex;
            }

        }

        public List<Estados> getEstadosForWallByUser(int userId)
        {
            List<Estados> estados = new List<Estados>();
            List<Solicitud_Amistad> amistades = new List<Solicitud_Amistad>();

            try {
                estados.AddRange(getEstadosByUser(userId));
            } catch (Exception ex) {
                throw new Exception("No se pudieron obtener los estados del usuario ID: " +userId, ex);
            }

            try {
                foreach (Usuario usuario in amistadesController.getAllFriendsFromUser(userId)) {
                    estados.AddRange(getEstadosByUser(usuario.Id, true, userId));
                }
            } catch (Exception ex) {
                throw new Exception("No se pudieron obtener los estados publicos de las amistades del usuario ID: " +userId, ex);
            }
            return estados.OrderByDescending(p => p.Fecha_creado).ToList();
        }

        /**
         * Devuelve los estados PUBLICOS o PRIVADOS del usuario 
         */
        public List<Estados> getEstadosByUser(int userId, bool isPublico, int sessionUserId)
        {
            List<Estados> estados = new List<Estados>();
            try {
                foreach (Estados estado in dataEstados.searchByUserId(userId).OrderByDescending(p => p.Fecha_creado).ToList()) {
                    if (estado.Publico == isPublico) {
                        estados.Add(estado);
                    }
                }
                return this.addComentariosToList(this.stringifyUserList(estados), sessionUserId);
            } catch (Exception ex) {
                throw new Exception("No se pudieron recuperar los estados del usuario ID " + userId, ex);
            }
        }

        /**
         * Devuelve TODOS los estados del usuario
         */
        public List<Estados> getEstadosByUser(int userId)
        {
            try {
                return this.addComentariosToList(this.stringifyUserList(dataEstados.searchByUserId(userId).OrderByDescending(p => p.Fecha_creado).ToList()), userId);
            } catch (Exception ex) {
                throw new Exception("No se pudieron recuperar los estados del usuario ID " + userId, ex);
            }
        }


        private List<Estados> stringifyUserList(List<Estados> lista)
        {
            List<Estados> estados = new List<Estados>();
            foreach (Estados pub in lista) {
                estados.Add(this.stringifyUser(pub));
            }
            return estados;
        }

        private Estados stringifyUser(Estados estado)
        {
            try {
                estado.Usuario = usuariosController.getUsuarioById(estado.Usuario_origen).ToString();
                return estado;
            } catch (Exception ex) {
                throw new Exception("No se pudo obtener el string del usuario para el estado ID: " + estado.Id, ex);
            }
        }

        public List<Estados> addComentariosToList(List<Estados> lista, int userId)
        {
            List<Estados> estados = new List<Estados>();
            foreach (Estados pub in lista) {
                estados.Add(this.addComentariosToEstado(pub, userId));
            }
            return estados;

        }

        private Estados addComentariosToEstado(Estados estado, int userId)
        {
            try {
                estado.Comentarios = controladoraComentarios.getComentariosByPublicacion(estado.Id, userId);
                return estado;
            } catch (Exception ex) {
                throw new Exception("Hubo un problema el intentar obtener los comentarios para el estado ID " + estado.Id, ex);
            }
        }

    }

}
