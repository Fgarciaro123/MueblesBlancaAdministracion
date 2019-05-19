using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Administracion.Datos;
using Administracion.Entidades;

namespace Administracion.Negocio
{
    public class BLPersona
    {
        public List<Persona> Listar()
        {
            DAOPersona daUsuario = new DAOPersona();
            return daUsuario.Listar();
        }

        public Persona TraerPorId(int Id)
        {
            DAOPersona daUsuario = new DAOPersona();
            return daUsuario.TraerPorId(Id);
        }

        public int Insertar(Persona cliente)
        {
            DAOPersona daUsuario = new DAOPersona();
            return daUsuario.Insertar(cliente);
        }

        //public int Actualizar(Persona cliente)
        //{
        //    DAOPersona daUsuario = new DAOPersona();
        //    //return daUsuario.Actualizar(cliente);
        //}

        public int Eliminar(int Id)
        {
            DAOPersona daUsuario = new DAOPersona();
            return daUsuario.Eliminar(Id);
        }

        public Boolean TraerPorPersonaClave(string var_usu, string var_clave)
        {
            DAOPersona daUsuario = new DAOPersona();
            return daUsuario.TraerPorPersonaClave(var_usu, var_clave);
        }

        public int ObtenerIdRolAdministrador()
        {
            DAOPersona dAOPersona = new DAOPersona();
            return dAOPersona.obtenerIdRolAdministrador();
        }

        public Boolean existeAdmin()
        {
            DAOPersona dAOPersona = new DAOPersona();
            return dAOPersona.existeAdmin();
        }
    }
}
