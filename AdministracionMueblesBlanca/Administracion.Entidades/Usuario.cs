using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion.Entidades
{
    public class Usuario
    {
        // Atributos  de la clase Categoria
        int _IdUsuario;
        string _Nombres;
        string _Apellidos;
        string _Login;
        string _Clave;
        string _Estado;
        string _Observacion;
        string _Perfil;

        public int IdUsuario
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        public string Nombres
        {
            get { return _Nombres; }
            set { _Nombres = value; }
        }
        public string Apellidos
        {
            get { return _Apellidos; }
            set { _Apellidos = value; }
        }
        public string Login
        {
            get { return _Login; }
            set { _Login = value; }
        }
        public string  Clave
        {
            get { return _Clave; }
            set { _Clave = value; }
        }
        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }
        public string Observacion
        {
            get { return _Observacion; }
            set { _Observacion = value; }
        }
        public string Perfil
        {
            get { return _Perfil; }
            set { _Perfil = value; }
        }

        public Usuario()
                   : this(0, "", "", "", "", "", "","")
        {
        }
        public Usuario(int IdUsuario, string Nombres, string Apellidos)
        {
            _IdUsuario = IdUsuario;
            _Nombres = Nombres;
            _Apellidos = Apellidos;
        }
            public Usuario(int IdUsuario, string Nombres, string Apellidos, string Login, string Clave, string Estado, string Observacion, string Perfil)
        {
            _IdUsuario = IdUsuario;
            _Nombres = Nombres;
            _Apellidos = Apellidos;
            _Login = Login;
            _Clave = Clave;
            _Estado = Estado;
            _Observacion = Observacion;
            _Perfil = Perfil; 
        }

      
    }
}
