using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;
using ApSocial.DAO.BaseDeDatos;

namespace ApSocial.Controladora.Etiquetas
{
    public class EtiquetaController
    {
        DAOEtiqueta daoEtiqueta = DAOEtiqueta.Instance();

        public Etiqueta newEtiqueta(Fotos foto, Usuario user)
        {
            try {
                return this.newEtiqueta(foto.Id, user.Id);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public Etiqueta newEtiqueta(int fotoId, int userId)
        {
            Etiqueta etiqueta;
            try {
                etiqueta = new Etiqueta(fotoId, userId);
                daoEtiqueta.add(etiqueta);
            } catch (Exception ex) {
                throw ex;
            }
            return etiqueta;
        }

        public List<Etiqueta> getAllByUsuario(Usuario user)
        {
            try {
                return this.getAllByUsuario(user.Id);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public List<Etiqueta> getAllByUsuario(int userId)
        {
            try {
                return daoEtiqueta.searchByUsuario(userId);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public List<Etiqueta> getAllByFoto(Fotos foto)
        {
            try {
                return this.getAllByFoto(foto.Id);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public List<Etiqueta> getAllByFoto(int fotoId)
        {
            try {
                return daoEtiqueta.searchByFoto(fotoId);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void removeEtiqueta(Fotos foto, Usuario user)
        {
            try {
                Etiqueta etiqueta = daoEtiqueta.searchByFotoAndUser(foto.Id, user.Id);
                daoEtiqueta.remove(etiqueta);
            } catch (Exception ex) {
                throw ex;
            }
        }

        private bool existEtiqueta(int fotoId, int userId)
        {
            try {
                Etiqueta etiqueta = daoEtiqueta.searchByFotoAndUser(fotoId, userId);
                return true;
            } catch (Exception ex) {
                return ex == null;
            }
        }
    }
}
