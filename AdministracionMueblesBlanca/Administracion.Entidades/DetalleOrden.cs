using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion.Entidades
{
    public class DetalleOrden
    {
        int _idOrdenCompra;
        long _totalOrdenCompra;
        DateTime _fechaCompraOrden;
        DateTime _fechaPagoOrden;
        long _nroIdPersona;
        string _nombrePersona;
        string _direccionPersona;
        long _celularPersona;
        string _emailPersona;
        int _idDetalleCompra;
        decimal _valorProducto;
        long _subtotalDetalle;
        int _cantidadDetalle;
        string _nombreProducto;



        public DetalleOrden()
        {

        }


        public DetalleOrden(
            int idOrdenCompra,
            long totalOrdenCompra,
            DateTime fechaCompraOrden,
            DateTime fechaPagoOrden, 
            long nroIdPersona, 
            string nombrePersona,
            string direccionPersona, 
            long celularPersona,
            string emailPersona,
            int idDetalleCompra, 
            decimal valorProducto,
            long subtotalDetalle, 
            int cantidadDetalle,
            string pNombreProducto)
        {
            this.IdOrdenCompra = idOrdenCompra;
            this.TotalOrdenCompra = totalOrdenCompra;
            this.FechaCompraOrden = fechaCompraOrden;
            this.FechaPagoOrden = fechaPagoOrden;
            this.NroIdPersona = nroIdPersona;
            this.NombrePersona = nombrePersona;
            this.DireccionPersona = direccionPersona;
            this.CelularPersona = celularPersona;
            this.EmailPersona = emailPersona;
            this.IdDetalleCompra = idDetalleCompra;
            this.ValorProducto = valorProducto;
            this.SubtotalDetalle = subtotalDetalle;
            this.CantidadDetalle = cantidadDetalle;
            this.NombreProducto = pNombreProducto;
        }

        public int IdOrdenCompra { get => _idOrdenCompra; set => _idOrdenCompra = value; }
        public long TotalOrdenCompra { get => _totalOrdenCompra; set => _totalOrdenCompra = value; }
        public DateTime FechaCompraOrden { get => _fechaCompraOrden; set => _fechaCompraOrden = value; }
        public long NroIdPersona { get => _nroIdPersona; set => _nroIdPersona = value; }
        public string NombrePersona { get => _nombrePersona; set => _nombrePersona = value; }
        public string DireccionPersona { get => _direccionPersona; set => _direccionPersona = value; }
        public long CelularPersona { get => _celularPersona; set => _celularPersona = value; }
        public string EmailPersona { get => _emailPersona; set => _emailPersona = value; }
        public int IdDetalleCompra { get => _idDetalleCompra; set => _idDetalleCompra = value; }
        public decimal ValorProducto { get => _valorProducto; set => _valorProducto = value; }
        public long SubtotalDetalle { get => _subtotalDetalle; set => _subtotalDetalle = value; }
        public int CantidadDetalle { get => _cantidadDetalle; set => _cantidadDetalle = value; }
        public DateTime FechaPagoOrden { get => _fechaPagoOrden; set => _fechaPagoOrden = value; }
        public string NombreProducto { get => _nombreProducto; set => _nombreProducto = value; }
    }
}
