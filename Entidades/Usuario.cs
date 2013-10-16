using System;
using System.Collections.Generic;


namespace ApSocial.Entidades
{
    public class Usuario
    {
        private int id;
        private string apellido;
        private string email;
        private DateTime fechaDeNacimiento;
        private string nombre;
        private string password;
        private string residencia;
        //public List<Publicacion> publicaciones;
        //public List<Grupos> grupos;
        //public List<Fotos> fotos_etiquetado;
        private string foto_usuario;
        private bool enabled;

        private byte[] foto_stream;

        public Usuario(string apellido, string nombre, string email, string password, string residencia, DateTime fdn, string foto)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Email = email;
            this.Password = password;
            this.Residencia = residencia;
            this.FechaDeNacimiento = fdn;
            this.Foto_usuario = foto;
            this.Foto_stream = null;
            
            this.enabled = true;
        }

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido;
        }

        ~Usuario()
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

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public DateTime FechaDeNacimiento
        {
            get { return fechaDeNacimiento; }
            set { fechaDeNacimiento = value; }
        }

        public string Residencia
        {
            get { return residencia; }
            set { residencia = value; }
        }

        public string Foto_usuario
        {
            get { return foto_usuario; }
            set { foto_usuario = value; }
        }

        public bool isEnabled()
        {
            return this.enabled;
        }

        public void Disable()
        {
            this.enabled = false;
        }

        public byte[] Foto_stream
        {
            get { return foto_stream; }
            set { foto_stream = value; }
        }


    }
}