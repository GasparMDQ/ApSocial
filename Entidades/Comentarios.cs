using System;
using System.Collections.Generic;

namespace ApSocial.Entidades
{
    public class Comentarios
    {
        private int idPublicacion;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdPublicacion
        {
            get { return idPublicacion; }
            set { idPublicacion = value; }
        }

        private DateTime fecha_creacion;
        private string mensaje;
        private bool publico;
        public Usuario usuario_origen;


        public Comentarios()
        {

        }

        ~Comentarios()
        {

        }

        public virtual void Dispose()
        {

        }

        public DateTime Fecha_creacion
        {
            get
            {
                return fecha_creacion;
            }
            set
            {
                fecha_creacion = value;
            }
        }

        public string Mensaje
        {
            get
            {
                return mensaje;
            }
            set
            {
                mensaje = value;
            }
        }

        public bool Publico
        {
            get
            {
                return publico;
            }
            set
            {
                publico = value;
            }
        }

    }
}