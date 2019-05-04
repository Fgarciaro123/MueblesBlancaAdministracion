using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion.Entidades
{
    public class Categoria
    {
        int _idCategoria;
        string _nombreCategoria;
        DateTime _fechaCreacionCategoria;
        string _usuarioCreacionCategoria;
        DateTime _fechaModificacionCategoria;
        string _usuarioModificacionCategoria;
        int _estadoCategoria;

        public int IdCategoria
        {
            get => _idCategoria;
            set => _idCategoria = value;
        }

        public string NombreCategoria
        {
            get => _nombreCategoria;
            set => _nombreCategoria = value;
        }
        public DateTime FechaCreacionCategoria
        {

            get => _fechaCreacionCategoria;
            set => _fechaCreacionCategoria = value;
        }

        public string UsuarioCreacionCategoria
        {

            get => _usuarioCreacionCategoria;
            set => _usuarioCreacionCategoria = value;
        }

        public string UsuarioModificacionCategoria
        {

            get => _usuarioModificacionCategoria;
            set => _usuarioModificacionCategoria = value;
        }

        public int EstadoCategoria
        {

            get => _estadoCategoria;
            set => _estadoCategoria = value;
        }
        public DateTime FechaModificacionCategoria
        {
            get => _fechaModificacionCategoria;
            set => _fechaModificacionCategoria = value;
        }

        public Categoria(
            int pIdCategoria,
            string pNombreCategoria,
            DateTime pFechaCreacionCategoria,
            string pUsuarioCreacionCategoria,
            DateTime pFechaModificacionCategoria,
            string pUsuarioModificacionCaetogria,
            int pEstadoCategoria)
        {
            this.IdCategoria = pIdCategoria;
            this.NombreCategoria = pNombreCategoria;
            this.FechaCreacionCategoria = pFechaCreacionCategoria;
            this.UsuarioCreacionCategoria = pUsuarioCreacionCategoria;
            this.FechaModificacionCategoria = pFechaModificacionCategoria;
            this.UsuarioModificacionCategoria = pUsuarioModificacionCaetogria;
            this.EstadoCategoria = pEstadoCategoria;

        }

        public Categoria()
        {
        }
    }
}
