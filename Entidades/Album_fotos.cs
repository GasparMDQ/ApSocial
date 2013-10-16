using System;
using System.Collections.Generic;

namespace ApSocial.Entidades
{
    public class Album_fotos : Publicacion
    {

        public List<Fotos> fotos;

        public Album_fotos(DateTime fecha_creado, string mensaje, bool publico, int usuario_origen, List<Fotos> lista)
        {
            this.Fecha_creado = fecha_creado;
            this.Mensaje = mensaje;
            this.Publico = publico;
            this.Usuario_origen = usuario_origen;
            this.fotos = lista;
        }

        ~Album_fotos()
        {

        }

        public override void Dispose()
        {

        }

    }
}