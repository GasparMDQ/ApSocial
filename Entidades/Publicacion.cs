using System;
using System.Collections.Generic;

namespace ApSocial.Entidades
{

    public abstract class Publicacion
    {
        private int id;

        private DateTime fecha_creado;
        private string mensaje;
        private bool publico;
        private int usuario_origen;
        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public int Usuario_origen
        {
            get { return usuario_origen; }
            set { usuario_origen = value; }
        }
        private int grupo_destino;

        public int Grupo_destino
        {
            get { return grupo_destino; }
            set { grupo_destino = value; }
        }
        //public List<Comentarios> comentarios;

        public Publicacion()
        {

        }

        ~Publicacion()
        {

        }

        public virtual void Dispose()
        {

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime Fecha_creado
        {
            get { return fecha_creado; }
            set { fecha_creado = value; }
        }

        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        public bool Publico
        {
            get { return publico; }
            set { publico = value; }
        }
    }
}