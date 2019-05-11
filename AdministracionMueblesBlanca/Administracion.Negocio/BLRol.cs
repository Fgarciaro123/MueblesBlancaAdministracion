using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Administracion.Entidades;
using Administracion.Datos;

namespace Administracion.Negocio
{
    public class BLRol
    {
        public List<Rol> Listar()
        {
            DAORol daRol = new DAORol();
            return daRol.Listar();
        }

        public Rol TraerPorId(int Id)
        {
            DAORol daRol = new DAORol();
            return daRol.TraerRolPorId(Id);
        }

        public int Insertar(Rol Rol)
        {
            DAORol daRol = new DAORol();
            return daRol.Insertar(Rol);
        }

        public int Actualizar(Rol Rol)
        {
            DAORol daRol = new DAORol();
            return daRol.Actualizar(Rol);
        }

        public int Eliminar(int Id)
        {
            DAORol daRol = new DAORol();
            return daRol.Eliminar(Id);
        }

    }
}
