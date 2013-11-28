using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;

namespace ApSocial.DAO.Lista
{
    public class DAOFotos:IDAO<Fotos>
    {
       List<Fotos> listaFotos=new List<Fotos>();
       int contadorFotos=0;
       private static DAOFotos _instance;

       public DAOFotos()
        {
        }

       public static DAOFotos Instance()
        {
            if (_instance == null)
            {
                _instance = new DAOFotos();
            }
            return _instance;
        }

        public int add(Fotos foto) 
        {
            foto.Id = getId();
            listaFotos.Add(foto);
            return foto.Id;
        }
       
        private int getId() {
            contadorFotos++;
            return contadorFotos;
        }
        public List<Fotos> getAll() { return listaFotos; }

        public void remove(Fotos foto)
        {
            try
            {
                this.searchById(foto.Id);
            }
            catch (Exception ex) { throw ex; }
            listaFotos.Remove(foto);
        }

        public void modify(Fotos modificada)
        {
            try
            {
                Fotos fotoGuardada = searchById(modificada.Id);
                listaFotos.Remove(fotoGuardada);
                listaFotos.Add(modificada);
            }
            catch (Exception ex) { 
                throw  new Exception("No pudo ser modificada la Foto", ex); 
            
            }
        }

        public Fotos searchById(int id)
        {
            foreach (Fotos foto in listaFotos)
            {
                if (foto.Id == id) { return foto; }
            }
            throw new Exception("Foto no encontrada con ese id");
        }
    }
}
