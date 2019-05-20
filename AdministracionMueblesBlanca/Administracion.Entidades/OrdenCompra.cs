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
        int _idPersonaOrdenCompra;
        DateTime _fechaCompra;
        
        long _totalCompra;

        public int IdCompra { get => _idCompra; set => _idCompra = value; }
        public int IdPersonaOrdenCompra { get => _idPersonaOrdenCompra; set => _idPersonaOrdenCompra = value; }
        public DateTime FechaCompra { get => _fechaCompra; set => _fechaCompra = value; }
        public long TotalCompra { get => _totalCompra; set => _totalCompra = value; }

        public OrdenCompra()
        {

        }

        public OrdenCompra(int pIdCompra, int pIdPersonaOrden,DateTime pFechaCompra, long pTotalCompra)
        {
            this.IdCompra = pIdCompra;
            this.IdPersonaOrdenCompra = pIdPersonaOrden;
            this.FechaCompra = pFechaCompra;
            this.TotalCompra = pTotalCompra;

        }

    }
}
