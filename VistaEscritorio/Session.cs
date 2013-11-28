using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VistaEscritorio
{
    static public class Session
    {
        static int idUsuarioLogueado = 0;

        public static int IdUsuarioLogueado
        {
            get { return idUsuarioLogueado; }
            set { idUsuarioLogueado = value; }
        }
        


    }
}
