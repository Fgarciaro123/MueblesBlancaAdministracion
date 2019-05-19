using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion.Entidades
{
    public static class sesion
    {
        private static string _usuarioSesion = "";

        public static string UsuarioSesion
        {
            get { return _usuarioSesion; }
            set { _usuarioSesion = value; }
        }
    }
}
