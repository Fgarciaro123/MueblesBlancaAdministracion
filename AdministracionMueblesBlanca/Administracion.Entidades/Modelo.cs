using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion.Entidades
{
    class Modelo
    {
        int _IdModelo;
        int _IdProductoModelo;
        string _TituloModelo;
        string _RutaModelo;
        DateTime _FechaCreacionModelo;
        string _UsuarioCreacionModelo;
        DateTime _FechaModificacionModelo;
        string _UsuarioModificacionModelo;
        int _EstadoModelo;

        public int IdModelo { get => _IdModelo; set => _IdModelo = value; }
        public int IdProductoModelo { get => _IdProductoModelo; set => _IdProductoModelo = value; }
        public string TituloModelo { get => _TituloModelo; set => _TituloModelo = value; }
        public string RutaModelo { get => _RutaModelo; set => _RutaModelo = value; }
        public DateTime FechaCreacionModelo { get => _FechaCreacionModelo; set => _FechaCreacionModelo = value; }
        public string UsuarioCreacionModelo { get => _UsuarioCreacionModelo; set => _UsuarioCreacionModelo = value; }
        public DateTime FechaModificacionModelo { get => _FechaModificacionModelo; set => _FechaModificacionModelo = value; }
        public string UsuarioModificacionModelo { get => _UsuarioModificacionModelo; set => _UsuarioModificacionModelo = value; }
        public int EstadoModelo { get => _EstadoModelo; set => _EstadoModelo = value; }

        public Modelo(
            int pIdModelo,
            int pIdProductoModelo, 
            string pTituloModelo, 
            string pRutaModelo, 
            DateTime pFechaCreacionModelo, 
            string pUsuarioCreacionModelo, 
            DateTime pFechaModificacionModelo, 
            string pUsuarioModificacionModelo, 
            int pEstadoModelo)
        {
            this._IdModelo = pIdModelo;
            this.IdProductoModelo = pIdProductoModelo;
            this.TituloModelo = pTituloModelo;
            this.RutaModelo = pRutaModelo;
            this.FechaCreacionModelo = pFechaCreacionModelo;
            this.UsuarioCreacionModelo = pUsuarioCreacionModelo;
            this.FechaModificacionModelo = pFechaModificacionModelo;
            this.UsuarioModificacionModelo = pUsuarioModificacionModelo;
            this.EstadoModelo = pEstadoModelo;
        }

        public Modelo()
        {

        }


    }
}
