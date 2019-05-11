using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Administracion.Entidades;
using Administracion.Datos;

namespace Administracion.Negocio
{
    public class BLProducto
    {
        public List<Producto> Listar()
        {
            DAOProducto daProducto = new DAOProducto();
            return daProducto.Listar();
        }

        public Producto TraerPorId(int Id)
        {
            DAOProducto daProducto = new DAOProducto();
            return daProducto.TraerProductoPorId(Id);
        }

        public int Insertar(Producto Producto)
        {
            DAOProducto daProducto = new DAOProducto();
            return daProducto.Insertar(Producto);
        }

        public int Actualizar(Producto Producto)
        {
            DAOProducto daProducto = new DAOProducto();
            return daProducto.Actualizar(Producto);
        }

        public int Eliminar(int Id)
        {
            DAOProducto daProducto = new DAOProducto();
            return daProducto.Eliminar(Id);
        }

        public List<Producto> BuscarProducto(string campo, string valor)
        {
            DAOProducto daProducto = new DAOProducto();
            return daProducto.BuscarProducto(campo, valor);
        }
    }
}
