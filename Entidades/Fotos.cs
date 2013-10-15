using System;
using System.Collections.Generic;

namespace ApSocial.Entidades
{
    public class Fotos
    {

        private string nombre;
        private string url;
        public List<Usuario> usuarios_etiquetados;
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Fotos(string nombre, string url, List<Usuario> usuarios_etiquetados)
        {
            this.nombre = nombre;
            this.url = url;
            this.usuarios_etiquetados = usuarios_etiquetados;
        }

        ~Fotos()
        {

        }

        public virtual void Dispose()
        {

        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
            }
        }

    }
}