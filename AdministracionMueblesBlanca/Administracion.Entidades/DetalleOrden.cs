using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion.Entidades
{
    public class DetalleOrden
    {
        int _idDetalleOrden;
        int _idOrdenCompraDetalle;
        int _idProductoDetalle;
        int _CantidadDetalle;
        long _subtotalDetalle;

        public int IdDetalleOrden { get => _idDetalleOrden; set => _idDetalleOrden = value; }
        public int IdOrdenCompraDetalle { get => _idOrdenCompraDetalle; set => _idOrdenCompraDetalle = value; }
        public int IdProductoDetalle { get => _idProductoDetalle; set => _idProductoDetalle = value; }
        public int CantidadDetalle { get => _CantidadDetalle; set => _CantidadDetalle = value; }
        public long SubtotalDetalle { get => _subtotalDetalle; set => _subtotalDetalle = value; }


        public DetalleOrden()
        {

        }

        public DetalleOrden(int pIdDetalleOrden, int pIdOrdenCompra,int pIdProductoDetalle,int pCantidadDetalle, long pSubtotalDetalle)
        {
            this.IdDetalleOrden = pIdDetalleOrden;
            this.IdOrdenCompraDetalle = pIdOrdenCompra;
            this.IdProductoDetalle = pIdProductoDetalle;
            this.CantidadDetalle = pCantidadDetalle;
            this.SubtotalDetalle = pSubtotalDetalle;
        }


    }
}
