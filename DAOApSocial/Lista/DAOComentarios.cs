using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;

namespace ApSocial.DAO.Lista
{
    public  class DAOComentarios:IDAO<Comentarios>
    {
        static List<Comentarios> listaComentarios = new List<Comentarios>();
        int contadorComentarios = 0;
        private static DAOComentarios _instance;

        public DAOComentarios()
        {
        }
        public static DAOComentarios Instance()
        {
            if (_instance == null)
            {
                _instance = new DAOComentarios();
            }
            return _instance;
        }
        private int getId() {
            contadorComentarios++;
            return contadorComentarios;
        }

        public List<Comentarios> getAll() { return listaComentarios; }
        public static List<Comentarios> ListaComentarios
        {
            get { return listaComentarios; }
            set { listaComentarios = value; }
        }
        public int add(Comentarios comentario)
        {
            comentario.Id = getId();
            listaComentarios.Add(comentario);
            return comentario.Id;
        }

        public void remove(Comentarios comentario)
        {
            try
            {
                this.searchById(comentario.Id);
            }
            catch (Exception ex) { throw ex; }
            listaComentarios.Remove(comentario);
        }
        public Comentarios searchById(int id) 
        {
            foreach ( Comentarios solicitud in listaComentarios)
            {
                if (solicitud.Id == id) { return solicitud; }
            }
            throw new Exception("Comentario no encontrado con ese id");
        
        }
        public void modify(Comentarios comentarioMod)
        {
            try
            {
                Comentarios comentarioGuardado = searchById(comentarioMod.Id);
                listaComentarios.Remove(comentarioGuardado);
                listaComentarios.Add(comentarioMod);
            }
            catch (Exception ex) { 
                throw  new Exception ("No se pudo modificar el comentario ",ex);
            }
        }


    }
}
