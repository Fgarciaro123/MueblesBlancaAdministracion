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
        public List<Modelo> Listar()
        {
            DAOModelo daModelo = new DAOModelo();
            return daModelo.Listar();
        }

        public Modelo TraerPorId(int Id)
        {
            DAOModelo daModelo = new DAOModelo();
            return daModelo.TraerModeloPorId(Id);
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

        public int Eliminar(int Id)
        {
            DAOModelo daModelo = new DAOModelo();
            return daModelo.Eliminar(Id);
        }
    }
}
