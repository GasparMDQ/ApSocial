using System;
using System.Collections.Generic;

namespace ApSocial.Entidades
{
    public class Estados : Publicacion
    {

        public Fotos foto_estado;

        public Estados()
        {

        }
        public Estados(Fotos foto_estado, DateTime fecha_creado, string mensaje, bool publico, int usuario_origen)
        {
            this.Fecha_creado = fecha_creado;
            this.foto_estado = foto_estado;
            this.Mensaje = mensaje;
            this.Publico = publico;
            this.Usuario_origen = usuario_origen;
        }

        ~Estados()
        {

        }

        public override void Dispose()
        {

        }

    }
}