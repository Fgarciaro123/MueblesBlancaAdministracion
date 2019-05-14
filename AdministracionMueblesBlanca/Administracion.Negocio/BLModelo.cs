using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Administracion.Entidades;
using Administracion.Datos;

namespace Administracion.Negocio
{
    public class BLModelo
    {
        public List<Modelo> Listar(int idProducto)
        {
            DAOModelo daModelo = new DAOModelo();
            return daModelo.Listar(idProducto);
        }

        public Modelo TraerPorId(int IdModelo, int IdProducto)
        {
            DAOModelo daModelo = new DAOModelo();
            return daModelo.TraerModeloPorId(IdModelo,IdProducto);
        }

        public int Insertar(Modelo Modelo)
        {
            DAOModelo daModelo = new DAOModelo();
            return daModelo.Insertar(Modelo);
        }

        public int Actualizar(Modelo Modelo)
        {
            DAOModelo daModelo = new DAOModelo();
            return daModelo.Actualizar(Modelo);
        }

        public int Eliminar(int IdModelo , int IdProducto)
        {
            DAOModelo daModelo = new DAOModelo();
            return daModelo.Eliminar(IdModelo,IdProducto);
        }
    }
}
