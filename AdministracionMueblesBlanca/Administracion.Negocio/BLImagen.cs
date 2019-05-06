using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Administracion.Datos;
using Administracion.Entidades;

namespace Administracion.Negocio
{
    class BLImagen
    {
        public List<Imagen> Listar()
        {
            DAOImagen daImagen = new DAOImagen();
            return daImagen.Listar();
        }

        public Imagen TraerPorId(int Id)
        {
            DAOImagen daImagen = new DAOImagen();
            return daImagen.TraerImagenPorId(Id);
        }

        public int Insertar(Imagen Imagen)
        {
            DAOImagen daImagen = new DAOImagen();
            return daImagen.Insertar(Imagen);
        }

        public int Actualizar(Imagen Imagen)
        {
            DAOImagen daImagen = new DAOImagen();
            return daImagen.Actualizar(Imagen);
        }

        public int Eliminar(int Id)
        {
            DAOImagen daImagen = new DAOImagen();
            return daImagen.Eliminar(Id);
        }
    }
}
