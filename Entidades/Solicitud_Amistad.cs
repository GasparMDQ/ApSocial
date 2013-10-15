using System;
using System.Collections.Generic;

namespace ApSocial.Entidades
{

    public class Solicitud_Amistad
    {

        int id;
        bool aceptada;
        int solicitante;
        int solicitado;

        public Solicitud_Amistad(int solicitante, int solicitado)
        {
            this.Solicitante = solicitante;
            this.Solicitado = solicitado;
            this.Aceptada = false;
        }

        ~Solicitud_Amistad() { }

        public virtual void Dispose() { }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public bool Aceptada
        {
            get { return aceptada; }
            set { aceptada = value; }
        }

        public int Solicitado
        {
            get { return solicitado; }
            set { solicitado = value; }
        }

        public int Solicitante
        {
            get { return solicitante; }
            set { solicitante = value; }
        }

    }
}