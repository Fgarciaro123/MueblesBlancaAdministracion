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
        long _nroIdentificacion;
        string _nombrePersona;

        public int IdCompra { get => _idCompra; set => _idCompra = value; }       
        public DateTime FechaCompra { get => _fechaCompra; set => _fechaCompra = value; }
        public long TotalCompra { get => _totalCompra; set => _totalCompra = value; }
        public DateTime FechaPago { get => _fechaPago; set => _fechaPago = value; }
        public long NroIdentificacion { get => _nroIdentificacion; set => _nroIdentificacion = value; }
        public string NombrePersona { get => _nombrePersona; set => _nombrePersona = value; }

        public OrdenCompra()
        {

        }

        public OrdenCompra(int pIdCompra, long pTotalCompra, DateTime pFechaCompra, DateTime pFechaPago, long pNroIdentificacion, string pNombrePersona)
        {
            this.IdCompra = pIdCompra;
            this.FechaCompra = pFechaCompra;
            this.FechaPago = pFechaPago;
            this.TotalCompra = pTotalCompra;
            this.NroIdentificacion = pNroIdentificacion;
            this.NombrePersona = pNombrePersona;
        }

    }
}
