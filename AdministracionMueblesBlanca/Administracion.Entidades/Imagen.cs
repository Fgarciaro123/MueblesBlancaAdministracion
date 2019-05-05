using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion.Entidades
{
    class Imagen
    {
        int _idImagen;
        int _idProductoImagen;
        int _TituloImagen;
        Byte _CodigoImagen;
        DateTime _FechaCreacionImagen;
        string _UsuarioCreacionImagen;
        DateTime _FechaModificacionImagen;
        string _UsuarioModificacionImagen;
        int _EstadoImagen;

        public int IdImagen { get => _idImagen; set => _idImagen = value; }
        public int IdProductoImagen { get => _idProductoImagen; set => _idProductoImagen = value; }
        public int TituloImagen { get => _TituloImagen; set => _TituloImagen = value; }
        public byte CodigoImagen { get => _CodigoImagen; set => _CodigoImagen = value; }
        public DateTime FechaCreacionImagen { get => _FechaCreacionImagen; set => _FechaCreacionImagen = value; }
        public string UsuarioCreacionImagen { get => _UsuarioCreacionImagen; set => _UsuarioCreacionImagen = value; }
        public DateTime FechaModificacionImagen { get => _FechaModificacionImagen; set => _FechaModificacionImagen = value; }
        public string UsuarioModificacionImagen { get => _UsuarioModificacionImagen; set => _UsuarioModificacionImagen = value; }
        public int EstadoImagen { get => _EstadoImagen; set => _EstadoImagen = value; }

        public Imagen()
        {
        }

        public Imagen(
            int idImagen, 
            int idProductoImagen, 
            int TituloImagen, 
            byte CodigoImagen, 
            DateTime FechaCreacionImagen, 
            string UsuarioCreacionImagen, 
            DateTime FechaModificacionImagen, 
            string UsuarioModificacionImagen, 
            int EstadoImagen)
        {
            this.IdImagen = idImagen;
            this.IdProductoImagen = idProductoImagen;
            this.TituloImagen = TituloImagen;
            this.CodigoImagen = CodigoImagen;
            this.FechaCreacionImagen = FechaCreacionImagen;
            this.UsuarioCreacionImagen = UsuarioCreacionImagen;
            this.FechaModificacionImagen = FechaModificacionImagen;
            this.UsuarioModificacionImagen = UsuarioModificacionImagen;
            this.EstadoImagen = EstadoImagen;
        }
    }
}
