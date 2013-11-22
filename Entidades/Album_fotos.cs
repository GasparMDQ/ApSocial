using System;
using System.Collections.Generic;

namespace ApSocial.Entidades
{
    public class Album_fotos : Publicacion
    {

        //public List<Fotos> fotos;
        //El controlador de album de fotos, debera generar las entidades fotos y asignarles el album correspondiente (via constructor)

        public Album_fotos(string mensaje, int usuario_origen)
        {
            this.Fecha_creado = DateTime.Today;
            this.Mensaje = mensaje;
            this.Publico = true;
            this.Usuario_origen = usuario_origen;
        }

        ~Album_fotos() { }
        public override void Dispose() { }
        public override string ToString()
        {
            return this.Mensaje+ this.Usuario_origen;
        }
    }
}