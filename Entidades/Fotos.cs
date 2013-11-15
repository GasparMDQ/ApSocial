using System;
using System.Collections.Generic;

namespace ApSocial.Entidades
{
    public class Fotos
    {

        int id;
        private string url;

        //public List<Usuario> usuarios_etiquetados;
        // Crear DAO Etiquetas que maneje entidades Usuario_Foto (crearla) y una controladora acorde que se encarge de
        // generar etiquetas (pares usuario_foto) y de obtener la lista de usuarios para X foto
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Fotos(string url)
        {
            this.url = url;
        }

        ~Fotos()
        {

        }

        public virtual void Dispose()
        {

        }

        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
            }
        }
        public override string ToString()
        {
            return this.Url;
        }


    }
}