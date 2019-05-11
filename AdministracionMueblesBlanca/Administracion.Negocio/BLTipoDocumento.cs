using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Administracion.Entidades;
using Administracion.Datos;

namespace Administracion.Negocio
{
    public class BLTipoDocumento
    {

        public List<TipoDocumento> Listar()
        {
            DAOTipoDocumento daTipoDocumento = new DAOTipoDocumento();
            return daTipoDocumento.Listar();
        }

        public TipoDocumento TraerPorId(int Id)
        {
            DAOTipoDocumento daTipoDocumento = new DAOTipoDocumento();
            return daTipoDocumento.TraerPorId(Id);
        }

        public int Insertar(TipoDocumento TipoDocumento)
        {
            DAOTipoDocumento daTipoDocumento = new DAOTipoDocumento();
            return daTipoDocumento.Insertar(TipoDocumento);
        }

        public int Actualizar(TipoDocumento TipoDocumento)
        {
            DAOTipoDocumento daTipoDocumento = new DAOTipoDocumento();
            return daTipoDocumento.Actualizar(TipoDocumento);
        }

        public int Eliminar(int Id)
        {
            DAOTipoDocumento daTipoDocumento = new DAOTipoDocumento();
            return daTipoDocumento.Eliminar(Id);
        }
    }
}
