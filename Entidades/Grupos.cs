using System;
using System.Collections.Generic;

namespace ApSocial.Entidades
{
    public class Grupos
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string descripcion;
        private bool sistema;
        //public List<Usuario> usuarios;

        public Grupos(string descripcion)
        {
            this.Descripcion = descripcion;
            this.Sistema = true;
        }

        ~Grupos() { }

        public virtual void Dispose() { }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public bool Sistema
        {
            get { return sistema; }
            set { sistema = value; }
        }

    }
}