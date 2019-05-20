using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion.Entidades
{
    public class OrdenCompra
    {
        int _idCompra;
        DateTime _fechaCompra;
        DateTime _fechaPago;        
        long _totalCompra;
        int _nroIdentificacion;
        string _nombrePersona;
        string _nombreProducto;

        public int IdCompra { get => _idCompra; set => _idCompra = value; }       
        public DateTime FechaCompra { get => _fechaCompra; set => _fechaCompra = value; }
        public long TotalCompra { get => _totalCompra; set => _totalCompra = value; }
        public DateTime FechaPago { get => _fechaPago; set => _fechaPago = value; }
        public int NroIdentificacion { get => _nroIdentificacion; set => _nroIdentificacion = value; }
        public string NombrePersona { get => _nombrePersona; set => _nombrePersona = value; }
        public string NombreProducto { get => _nombreProducto; set => _nombreProducto = value; }

        public OrdenCompra()
        {

        }

        public OrdenCompra(int pIdCompra,DateTime pFechaCompra, DateTime pFechaPago, long pTotalCompra, int pNroIdentificacion, string pNombrePersona, string pNombreProducto)
        {
            this.IdCompra = pIdCompra;
            this.FechaCompra = pFechaCompra;
            this.FechaPago = pFechaPago;
            this.TotalCompra = pTotalCompra;
            this.NroIdentificacion = pNroIdentificacion;
            this.NombrePersona = pNombrePersona;
            this.NombreProducto = pNombreProducto;
        }

    }
}
