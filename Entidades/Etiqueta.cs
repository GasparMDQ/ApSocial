using System;
using System.Collections.Generic;

namespace ApSocial.Entidades
{
    public class Etiqueta
    {

        private int usuario;
        public int UsuarioId
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private int foto;
        public int FotoId
        {
            get { return foto; }
            set { foto = value; }
        }

        // Crear DAO Etiquetas que maneje entidades Usuario_Foto (crearla) y una controladora acorde que se encarge de
        // generar etiquetas (pares usuario_foto) y de obtener la lista de usuarios para X foto

        public Etiqueta(int userId, int fotoId)
        {
            this.UsuarioId = userId;
            this.FotoId = fotoId;
        }

        public Etiqueta(Usuario usuario, Fotos foto)
        {
            this.UsuarioId = usuario.Id;
            this.FotoId = foto.Id;
        }

        ~Etiqueta() { }

        public virtual void Dispose() { }

    }
}