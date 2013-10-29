using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;

namespace ApSocial.DAO.Lista
{
    public class DAOPublicacion:IDAO<Publicacion>
    {
        List<Publicacion> listaPublicaciones = new List<Publicacion>();

        public List<Publicacion> ListaPublicaciones
        {
            get { return listaPublicaciones; }
            set { listaPublicaciones = value; }
        }
        int contadorPublicacion=0;
        
        private static DAOPublicacion _instance;

        public DAOPublicacion()
        {
        }

        private int getId(){
            contadorPublicacion++;
            return contadorPublicacion;
        }

        public static DAOPublicacion Instance()
        {
            if (_instance == null)
            {
                _instance = new DAOPublicacion();
            }
            return _instance;
        }
        public List<Publicacion> getAll() {return listaPublicaciones; }


        public Publicacion searchById(int id)
        {
            foreach (Publicacion publicacion in this.ListaPublicaciones )
            {
                if (publicacion.Id == id) { return publicacion; }
            }

            throw new Exception("Publicacion no encontrada con ese ID");
        }

        public List<Publicacion> getPublicacionesByidUsuario(int idUsuario) 
        {
            try
            {
                List<Publicacion> listaById = new List<Publicacion>();
                foreach (Publicacion publicacion in listaPublicaciones)
                {
                    if (publicacion.Usuario_origen == idUsuario)
                    {
                        listaById.Add(publicacion);
                    }
                } return listaById;
            }
            catch (Exception ex)
            {
                throw ex;
            }
         }

        public void add(Publicacion publicacion)
        {
            publicacion.Id= getId();
            listaPublicaciones.Add(publicacion);

        }

        public void remove(Publicacion publicacion) 
        {
            try {
                this.searchById(publicacion.Id);
            }catch(Exception ex){ throw ex; }
            listaPublicaciones.Remove(publicacion);
        }

        public void modify(Publicacion publicacionModificada)
        {
            try
            {
                Publicacion publicacionGrabada = searchById(publicacionModificada.Id);
                publicacionModificada.Id = publicacionGrabada.Id;
                listaPublicaciones.Remove(publicacionGrabada);
                listaPublicaciones.Add(publicacionModificada);
            }
            catch (Exception ex){ 
                throw new Exception("No puede ser modificada la publicacion" ,ex); 
            }
        
        }
        public List<Publicacion> publicacionesByIdUsuario(int idUsuario) 
        {
            List<Publicacion> listaPublicacionesByuser=new List<Publicacion>();
            foreach (Publicacion publicacion in listaPublicaciones) {
                if (publicacion.Usuario_origen == idUsuario) {
                    listaPublicacionesByuser.Add(publicacion);
                }
            } return listaPublicacionesByuser;//devuelve vacia si el usuario no existe o no tiene publicaciones. 
        
        }

        public bool isPublic(Publicacion publicacion) 
        { 
            bool rta=true;
            if (publicacion.Grupo_destino == -1) {
                rta = false;
            } return rta;
        }

        public bool existePublicacion(string nombre)
        {
            bool rta = false;
            foreach (Publicacion publicacion in listaPublicaciones)
            {
                if (publicacion.Mensaje == nombre)
                {
                    rta = true;
                }
            } return rta;
        }


   
    }
}
