using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Administracion.Datos;
using Administracion.Entidades;

namespace Administracion.Negocio
{
    public class BLUsuario
    {
        public List<Usuario> Listar()
        {
            DAOUsuario daUsuario = new DAOUsuario();
            return daUsuario.Listar();
        }

        public Usuario TraerPorId(int Id)
        {
            DAOUsuario daUsuario = new DAOUsuario();
            return daUsuario.TraerPorId(Id);
        }

        public int Insertar(Usuario cliente)
        {
            DAOUsuario daUsuario = new DAOUsuario();
            return daUsuario.Insertar(cliente);
        }

        public int Actualizar(Usuario cliente)
        {
            DAOUsuario daUsuario = new DAOUsuario();
            return daUsuario.Actualizar(cliente);
        }

        public int Eliminar(int Id)
        {
            DAOUsuario daUsuario = new DAOUsuario();
            return daUsuario.Eliminar(Id);
        }

        public Usuario TraerPorUsuarioClave(string var_usu, string var_clave)
        {
            DAOUsuario daUsuario = new DAOUsuario();
            return daUsuario.TraerPorUsuarioClave(var_usu, var_clave);
        }
    }
}
