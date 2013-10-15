using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ApSocial.Entidades;

namespace ApSocial.DAO.Lista
{
    public class DAOEstados
    {
        List<Estados> listaDeEstados = new List<Estados>();
        int contadorEstados = 0;

        private static DAOEstados _instance;

        public DAOEstados()
        {
        }
        public static DAOEstados Instance()
        {
            if (_instance == null)
            {
                _instance = new DAOEstados();
            }
            return _instance;
        }
        private int getId()
        {
            contadorEstados++;
            return contadorEstados;
        }

        public void add(Estados estado)
        {
            estado.Id= getId();
            listaDeEstados.Add(estado);
        }


        public void remove(Estados estado)
        {
            try
            {
                this.searchById(estado.Id);
            }
            catch (Exception ex) { throw ex; }
            listaDeEstados.Remove(estado);
        }


        public Estados searchById(int id)
        {
            foreach (Estados estado in listaDeEstados){
                    if (estado.Id == id) { return  estado; }
            }
            throw new Exception("Estado no encontrada con ese id");
        }

        public void modify(Estados estadoModificado) 
        {
            try
            {
                Estados eGuardado = searchById(estadoModificado.Id);
                listaDeEstados.Remove(eGuardado);
                listaDeEstados.Add(estadoModificado);
            }
            catch (Exception ex) {
                throw new Exception ("El estado no pudo ser modificada ",ex); 
            
            }
        }
        public List<Estados> getAll() { return listaDeEstados; }
    }

}
