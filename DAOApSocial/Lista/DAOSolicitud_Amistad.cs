using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;

namespace ApSocial.DAO.Lista
{
    public class DAOSolicitud_Amistad:IDAO<Solicitud_Amistad>
    {
        List<Solicitud_Amistad> listaSolicitudes = new List<Solicitud_Amistad>();
        int contadorSolicitudes = 0;

        private static DAOSolicitud_Amistad _instance;

        public DAOSolicitud_Amistad()
        {
        }
        public static DAOSolicitud_Amistad Instance()
        {
            if (_instance == null)
            {
                _instance = new DAOSolicitud_Amistad();
            }
            return _instance;
        }
        private int getId()
        {
            contadorSolicitudes++;
            return contadorSolicitudes;
        }

        public void add(Solicitud_Amistad solicitud)
        {
            solicitud.Id= getId();
            listaSolicitudes.Add(solicitud);
        }

        public void remove(Solicitud_Amistad solicitud)
        {
            try
            {
                this.searchById(solicitud.Id);
            }
            catch (Exception ex) { throw ex; }
            listaSolicitudes.Remove(solicitud);
        }


        public Solicitud_Amistad searchById(int id)
        {
            foreach (Solicitud_Amistad solicitud in listaSolicitudes){
                    if (solicitud.Id == id) { return  solicitud; }
            }
            throw new Exception("Solicitud no encontrada con ese id");
        }

        public void modify(Solicitud_Amistad solicitudModificada) 
        {
            try
            {
                Solicitud_Amistad sGuardada = searchById(solicitudModificada.Id);
                solicitudModificada.Id = sGuardada.Id;
                listaSolicitudes.Remove(sGuardada);
                listaSolicitudes.Add(solicitudModificada);
            }
            catch (Exception ex) {
                throw new Exception ("La solicitud de amistad no pudo ser modificada ",ex); 
            
            }
        }
        public List<Solicitud_Amistad> getAll() { return listaSolicitudes; }

        public Solicitud_Amistad getOneByUsers(Usuario usuarioSolicitante, Usuario usuarioSolicitado)
        {
            foreach (Solicitud_Amistad solicitud in listaSolicitudes) {
                if (solicitud.Solicitado == usuarioSolicitado.Id && solicitud.Solicitante == usuarioSolicitante.Id) { return solicitud; }
            }
            foreach (Solicitud_Amistad solicitud in listaSolicitudes) {
                if (solicitud.Solicitado == usuarioSolicitante.Id && solicitud.Solicitante == usuarioSolicitado.Id) { return solicitud; }
            }
            throw new Exception("No se encontró solicitud entre los usuarios");
        }

        public List<Solicitud_Amistad> getAllFriendsFromUser(Usuario usuario)
        {
            List<Solicitud_Amistad> listado = new List<Solicitud_Amistad>();
            foreach (Solicitud_Amistad solicitud in listaSolicitudes) {
                if (solicitud.Solicitado == usuario.Id && solicitud.Aceptada) {
                    listado.Add(solicitud);
                } else if (solicitud.Solicitante == usuario.Id && solicitud.Aceptada) {
                    listado.Add(solicitud);
                }
            }
            return listado;
        }

        public List<Solicitud_Amistad> getAllNotFriendsFromUser(Usuario usuario)
        {
            List<Solicitud_Amistad> listado = new List<Solicitud_Amistad>();
            foreach (Solicitud_Amistad solicitud in listaSolicitudes) {
                if (solicitud.Solicitado == usuario.Id && !solicitud.Aceptada) {
                    listado.Add(solicitud);
                } else if (solicitud.Solicitante == usuario.Id && !solicitud.Aceptada) {
                    listado.Add(solicitud);
                }
            }
            return listado;
        }


    }
}
