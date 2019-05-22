using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Administracion.Entidades;
using Administracion.Datos;

namespace Administracion.Negocio
{
    public class BlOrdenCompra
    {
        public List<OrdenCompra> Listar()
        {
            DAOOrdenCompra dAOOrdenCompra = new DAOOrdenCompra();
            return dAOOrdenCompra.Listar();
        }

        public OrdenCompra TraerOrdenPorId(int Id)
        {
            DAOOrdenCompra dAOOrdenCompra = new DAOOrdenCompra();
            return dAOOrdenCompra.TraerOrdenCompraPorId(Id);
        }

        public int ConfirmarPago(int IdOrden)
        {
            DAOOrdenCompra dAOOrdenCompra = new DAOOrdenCompra();
            return dAOOrdenCompra.ConfirmarPago(IdOrden);
        }

    }
}
