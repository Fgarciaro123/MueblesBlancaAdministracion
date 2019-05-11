using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion.Entidades
{
    public class Rol
    {
        int _idRol;
        string _nombreRol;
        DateTime _fechaCreacionRol;
        string _usuarioCreacionRol;
        DateTime _fechaModificacionRol;
        string _usuarioModificacionRol;
        int _estadoRol;

        public Rol(
            int pIdRol, 
            string pNombreRol, 
            DateTime pFechaCreacionRol, 
            string pUsuarioCreacionRol, 
            DateTime pFechaModificacionRol, 
            string pUsuarioModificacionRol, 
            int pEstadoRol)
        {
            this.IdRol = pIdRol;
            this.NombreRol = pNombreRol;
            this.FechaCreacionRol = pFechaCreacionRol;
            this.UsuarioCreacionRol = pUsuarioCreacionRol;
            this.FechaModificacionRol = pFechaModificacionRol;
            this.UsuarioModificacionRol = pUsuarioModificacionRol;
            this.EstadoRol = pEstadoRol;
        }

        public Rol()
        {

        }

        public Rol(int pIdRol, string pNombreRol, DateTime pFechaModificacionRol, int pEstadoRol)
        {
            this.IdRol = pIdRol;
            this.NombreRol = pNombreRol;
            this.FechaModificacionRol = pFechaModificacionRol;
            this.EstadoRol = pEstadoRol;
        }


        public int IdRol { get => _idRol; set => _idRol = value; }
        public string NombreRol { get => _nombreRol; set => _nombreRol = value; }
        public DateTime FechaCreacionRol { get => _fechaCreacionRol; set => _fechaCreacionRol = value; }
        public string UsuarioCreacionRol { get => _usuarioCreacionRol; set => _usuarioCreacionRol = value; }
        public DateTime FechaModificacionRol { get => _fechaModificacionRol; set => _fechaModificacionRol = value; }
        public string UsuarioModificacionRol { get => _usuarioModificacionRol; set => _usuarioModificacionRol = value; }
        public int EstadoRol { get => _estadoRol; set => _estadoRol = value; }
    }
}
