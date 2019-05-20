using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Administracion.Entidades;
using Administracion.Datos;

namespace Administracion.Negocio
{
    public class BLDetalleOrden
    {
        public List<DetalleOrden> Listar(int pIdOrden)
        {
            DAODetalleOrden dAODetalleOrden = new DAODetalleOrden();
            return dAODetalleOrden.Listar(pIdOrden);
        }

    }
}
