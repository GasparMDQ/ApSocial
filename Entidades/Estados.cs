using System;
using System.Collections.Generic;

namespace ApSocial.Entidades
{
    public class Estados : Publicacion
    {

        private string foto_estado;

        public string Foto_estado
        {
            get { return foto_estado; }
            set { foto_estado = value; }
        }
        private int grupo_id;

        public int Grupo_id
        {
            get { return grupo_id; }
            set { grupo_id = value; }
        }

        //Si se pasa grupo, se setea la privacidad en true, sino es false
        public Estados(DateTime fecha_creado, string mensaje, int usuario_origen, int grupo, string foto_estado)
        {
            this.Fecha_creado = fecha_creado;
            this.Foto_estado = foto_estado;
            this.Mensaje = mensaje;
            this.Publico = false;
            this.Grupo_id = grupo;
            this.Usuario_origen = usuario_origen;
        }

        public Estados(DateTime fecha_creado, string mensaje, int usuario_origen, string foto_estado)
        {
            this.Fecha_creado = fecha_creado;
            this.Foto_estado = foto_estado;
            this.Mensaje = mensaje;
            this.Publico = true;
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