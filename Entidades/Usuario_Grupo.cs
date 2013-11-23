using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApSocial.Entidades
{
    public class Usuario_Grupo
    {
        int idUsuario;
        int idGrupo;

        public int IdGrupo
        {
            get { return idGrupo; }
            set { idGrupo = value; }
        }

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        public Usuario_Grupo(int idUsuario, int idGrupo) {
            this.IdUsuario = IdUsuario;
            this.idGrupo = idGrupo;
        }

    }
}
