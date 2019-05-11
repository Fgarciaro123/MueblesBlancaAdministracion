using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion.Entidades
{
    public class TipoDocumento
    {
        int _idTipoDocumento;
        string _descripcionTipoDocumento;
        DateTime _fechaCreacionTipoDocumento;
        string _usuarioCreacionTipoDocumento;
        DateTime _fechaModificacionTipoDocumento;
        string _usuarioModificacionTipoDocumento;
        int _estadoTipoDocumento;

        public TipoDocumento()
        {

        }

        public TipoDocumento(
            int pIdTipoDocumento,
            string pDescripcionTipoDocumento,
            DateTime pFechaCreacionTipoDocumento,
            string pUsuarioCreacionTipoDocumento,
            DateTime pFechaModificacionTipoDocumento,
            string pUsuarioModificacionTipoDocumento,
            int pEstadoTipoDocumento)
        {
            this.IdTipoDocumento = pIdTipoDocumento;
            this.DescripcionTipoDocumento = pDescripcionTipoDocumento;
            this.FechaCreacionTipoDocumento = pFechaCreacionTipoDocumento;
            this.UsuarioCreacionTipoDocumento = pUsuarioCreacionTipoDocumento;
            this.FechaModificacionTipoDocumento = pFechaModificacionTipoDocumento;
            this.UsuarioModificacionTipoDocumento = pUsuarioModificacionTipoDocumento;
            this.EstadoTipoDocumento = pEstadoTipoDocumento;
        }

        public TipoDocumento(
            string pDescripcionTipoDocumento,
            DateTime pFechaCreacionTipoDocumento,
            string pUsuarioCreacionTipoDocumento,
            int pEstadoTipoDocumento)
        {
            this.DescripcionTipoDocumento = pDescripcionTipoDocumento;
            this.FechaCreacionTipoDocumento = pFechaCreacionTipoDocumento;
            this.UsuarioCreacionTipoDocumento = pUsuarioCreacionTipoDocumento;
            this.EstadoTipoDocumento = pEstadoTipoDocumento;
        }


        public TipoDocumento(
            int pIdTipoDocumento,
            string pDescripcionTipoDocumento,
            DateTime pFechaModificacionTipoDocumento,
            string pUsuarioModificacionTipoDocumento,
            int pEstadoTipoDocumento)
        {
            this.IdTipoDocumento = pIdTipoDocumento;
            this.DescripcionTipoDocumento = pDescripcionTipoDocumento;
            this.FechaModificacionTipoDocumento = pFechaModificacionTipoDocumento;
            this.UsuarioModificacionTipoDocumento = pUsuarioModificacionTipoDocumento;
            this.EstadoTipoDocumento = pEstadoTipoDocumento;
        }


        public int IdTipoDocumento { get => _idTipoDocumento; set => _idTipoDocumento = value; }
        public string DescripcionTipoDocumento { get => _descripcionTipoDocumento; set => _descripcionTipoDocumento = value; }
        public DateTime FechaCreacionTipoDocumento { get => _fechaCreacionTipoDocumento; set => _fechaCreacionTipoDocumento = value; }
        public string UsuarioCreacionTipoDocumento { get => _usuarioCreacionTipoDocumento; set => _usuarioCreacionTipoDocumento = value; }
        public DateTime FechaModificacionTipoDocumento { get => _fechaModificacionTipoDocumento; set => _fechaModificacionTipoDocumento = value; }
        public string UsuarioModificacionTipoDocumento { get => _usuarioModificacionTipoDocumento; set => _usuarioModificacionTipoDocumento = value; }
        public int EstadoTipoDocumento { get => _estadoTipoDocumento; set => _estadoTipoDocumento = value; }
    }
}
