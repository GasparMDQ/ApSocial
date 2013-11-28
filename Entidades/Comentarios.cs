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

        public DateTime Fecha_creacion
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }
        }

        private string mensaje;

        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        private int usuarioId;

        public int UsuarioId
        {
            get { return usuarioId; }
            set { usuarioId = value; }
        }

        //No mapeado, utilizado para mostrar el usuario que creo que comentario
        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public Comentarios(string msg, int userId, int pubId) {
            this.Mensaje = msg;
            this.UsuarioId = userId;
            this.IdPublicacion = pubId;
            this.Fecha_creacion = DateTime.Now;
        }

        ~Comentarios() { }

        public virtual void Dispose() { }
     }
}