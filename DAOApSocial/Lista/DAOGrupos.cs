using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;

namespace ApSocial.DAO.Lista
{
    class DAOGrupos
    {
       List<Grupos> listaDeGrupos = new List<Grupos>();
        int contadorGrupos = 0;

        private static DAOGrupos _instance;

        public DAOGrupos()
        {
        }
        public static DAOGrupos Instance()
        {
            if (_instance == null)
            {
                _instance = new DAOGrupos();
            }
            return _instance;
        }
        private int getId()
        {
            contadorGrupos++;
            return contadorGrupos;
        }

        public void add(Grupos grupo)
        {
            grupo.Id= getId();
            listaDeGrupos.Add(grupo);
        }


        public void remove(Grupos grupo)
        {
            try
            {
                this.searchById(grupo.Id);
            }
            catch (Exception ex) { throw ex; }
            listaDeGrupos.Remove(grupo);
        }


        public Grupos searchById(int id)
        {
            foreach (Grupos grupos in listaDeGrupos){
                    if (grupos.Id == id) { return  grupos; }
            }
            throw new Exception("Grupo no encontrado con ese id");
        }


        public void modify(Grupos grupoModificado) 
        {
            try
            {
                Grupos gGuardado = searchById(grupoModificado.Id);
                listaDeGrupos.Remove(gGuardado);
                listaDeGrupos.Add(grupoModificado);
            }
            catch (Exception ex) {
                throw new Exception ("El Grupo no pudo ser modificado ",ex); 
            
            }
        }
        public List<Grupos> getAll() { return listaDeGrupos; }



  /*      public Grupos getGrupoByPublicacion(Publicacion publicacion)
        {
            Grupos grupoPublicacion = null;
            try
            {
                grupoPublicacion= searchById(publicacion.grupo_destino.Id);
            }
            catch (Exception ex) {
                throw new Exception("la publicacion no arrojo un grupo destino valido con id ", ex);
            }
            return grupoPublicacion;
        }
        public bool validGroup(Publicacion publicacion)
        {

            try
            {
                return getGrupoByPublicacion(publicacion) != null;
            }
            catch (Exception ex){
                throw new Exception("La publicacion no pertenece a un Grupo", ex);
            }
        }*/



    }
}
