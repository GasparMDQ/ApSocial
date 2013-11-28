using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using ApSocial.Controladora.Usuarios;

using ApSocial.DAO.BaseDeDatos;
//using ApSocial.DAO.Lista;

namespace ApSocial.Controladora.Amistades
{

    public class AmistadesController
    {
        DAOSolicitud_Amistad dataAmistades = DAOSolicitud_Amistad.Instance();
        private UsuarioController controladoraUsuario = new UsuarioController();

        /**
         * CU Solicitar nueva amistad
         * 
         * Fijarse que el usuario logueado sea valido
         * Validar mail no sea blanco *
         * Buscar usuario por mail
         * Verificar que no exista ya otra solicitud pendiente con la combinacion de los dos usuarios
         * Crear nueva solicitud
         * 
         * @todo LO QUE FALTA
         * 
         */
        public void solicitarAmistad(int userId, string email)
        {
            Usuario solicitante;
            Usuario solicitado;

            if (email == "") {
                throw new Exception("Debe ingresar una dirección de correo");
            }

            try {
                solicitante = controladoraUsuario.getUsuarioById(userId);
                solicitado = controladoraUsuario.getUsuarioByEmail(email);
            } catch (Exception ex) {
                throw ex;
            }

            if (solicitante.Email == solicitado.Email) {
                throw new Exception("No se puede enviar una solicitud a si mismo");
            }

            try {
                if (this.verificaAmistadExistente(solicitante, solicitado)) {
                    throw new Exception("Ya existe una solicitud pendiente con ese amigo");
                } else {
                    this.creaNuevaSolicitud(solicitante, solicitado);
                }
            } catch (Exception ex) {
                throw ex;
            }
        }

        public List<Usuario> getAllFriendsFromUser(int usuarioId)
        {
            try {
                return this.getListaAmigos(controladoraUsuario.getUsuarioById(usuarioId));
            } catch (Exception ex) {
                throw ex;
            }
        }

        public bool verificaAmistadExistente(Usuario solicitante, Usuario solicitado)
        {
            try {
                return dataAmistades.getOneByUsers(solicitante.Id, solicitado.Id) != null;
            } catch (Exception ex) {
                return ex == null;
            }
        }

        public bool verificaAmistadExistente(int solicitante, int solicitado)
        {
            try {
                return dataAmistades.getOneByUsers(solicitante, solicitado) != null;
            } catch (Exception ex) {
                return ex == null;
            }
        }

        private void creaNuevaSolicitud(Usuario solicitante, Usuario solicitado)
        {
            Solicitud_Amistad solicitud = new Solicitud_Amistad(solicitante.Id, solicitado.Id);
            dataAmistades.add(solicitud);
        }

        private List<Usuario> getListaAmigos(Usuario solicitante)
        {
            List<Usuario> lista = new List<Usuario>();

            foreach(Solicitud_Amistad solicitud in dataAmistades.getAllFriendsFromUser(solicitante)){
                if (solicitud.Solicitante == solicitante.Id) {
                    lista.Add(controladoraUsuario.getUsuarioById(solicitud.Solicitado));
                } else {
                    lista.Add(controladoraUsuario.getUsuarioById(solicitud.Solicitante));
                }
            }
            return lista;
        }

        private void aceptarSolicitud(Solicitud_Amistad solicitud)
        {
            solicitud.Aceptada = true;
            try {
                dataAmistades.modify(solicitud);
            } catch (Exception ex) {
                throw new Exception("No se pudo aceptar la solicitud", ex);
            }
        }

        public List<Usuario> getAllUsuariosSolicitudesFromUser(int usuarioId)
        {
            try {
                return this.getListaSolicitantes(controladoraUsuario.getUsuarioById(usuarioId));
            } catch (Exception ex) {
                throw ex;
            }
        }

        private List<Usuario> getListaSolicitantes(Usuario solicitante)
        {
            List<Usuario> lista = new List<Usuario>();

            foreach (Solicitud_Amistad solicitud in dataAmistades.getAllNotFriendsFromUser(solicitante)) {
                if (solicitud.Solicitante == solicitante.Id) {
                    lista.Add(controladoraUsuario.getUsuarioById(solicitud.Solicitado));
                } else {
                    lista.Add(controladoraUsuario.getUsuarioById(solicitud.Solicitante));
                }
            }
            return lista;
        }

        public void rechazarAmistad(int usuarioLogueado, Usuario solicitante)
        {
            try {
                Solicitud_Amistad solicitud = dataAmistades.getOneByUsers(usuarioLogueado, solicitante.Id);
                dataAmistades.remove(solicitud);
            } catch (Exception ex) {
                throw new Exception("No se pudo rechazar la solicitud", ex);
            }
        }

        public void rechazarAmistad(int usuarioLogueado, int solicitante)
        {
            try {
                Solicitud_Amistad solicitud = dataAmistades.getOneByUsers(usuarioLogueado, solicitante);
                dataAmistades.remove(solicitud);
            } catch (Exception ex) {
                throw new Exception("No se pudo rechazar la solicitud", ex);
            }
        }

        public void aceptarAmistad(int usuarioLogueado, Usuario solicitante)
        {
            try {
                Solicitud_Amistad solicitud = dataAmistades.getOneByUsers(usuarioLogueado, solicitante.Id);
                this.aceptarSolicitud(solicitud);
            } catch (Exception ex) {
                throw new Exception("No se pudo aceptar la solicitud", ex);
            }
        }

        public void aceptarAmistad(int usuarioLogueado, int solicitante)
        {
            try {
                Solicitud_Amistad solicitud = dataAmistades.getOneByUsers(usuarioLogueado, solicitante);
                this.aceptarSolicitud(solicitud);
            } catch (Exception ex) {
                throw new Exception("No se pudo aceptar la solicitud", ex);
            }
        }


    }
}
