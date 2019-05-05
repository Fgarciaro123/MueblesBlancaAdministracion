using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion.Entidades
{
    public class Producto
    {

        int _IdProducto;
        string _NombreProducto;
        string _DescripcionProducto;
        string _AnchoProducto;
        string _AltoProducto;
        string _ColorProducto;
        string _MaterialProducto;
        int _GarantiaMesesProducto;
        long _ValorUnitarioProducto;
        int _imagenProducto;
        int _modeloProducto;
        int _CategoriaProducto;
        DateTime _FechaCreacionProducto;
        string _UsuarioCreacionProducto;
        DateTime _FechaModificacionProducto;
        string _UsuarioModificacionProducto;
        int _EstadoProducto;

        public int IdProducto { get => _IdProducto; set => _IdProducto = value; }
        public string NombreProducto { get => _NombreProducto; set => _NombreProducto = value; }
        public string DescripcionProducto { get => _DescripcionProducto; set => _DescripcionProducto = value; }
        public string AnchoProducto { get => _AnchoProducto; set => _AnchoProducto = value; }
        public string AltoProducto { get => _AltoProducto; set => _AltoProducto = value; }
        public string ColorProducto { get => _ColorProducto; set => _ColorProducto = value; }
        public string MaterialProducto { get => _MaterialProducto; set => _MaterialProducto = value; }
        public int GarantiaMesesProducto { get => _GarantiaMesesProducto; set => _GarantiaMesesProducto = value; }
        public long ValorUnitarioProducto { get => _ValorUnitarioProducto; set => _ValorUnitarioProducto = value; }
        public int CategoriaProducto { get => _CategoriaProducto; set => _CategoriaProducto = value; }
        public DateTime FechaCreacionProducto { get => _FechaCreacionProducto; set => _FechaCreacionProducto = value; }
        public string UsuarioCreacionProducto { get => _UsuarioCreacionProducto; set => _UsuarioCreacionProducto = value; }
        public DateTime FechaModificacionProducto { get => _FechaModificacionProducto; set => _FechaModificacionProducto = value; }
        public string UsuarioModificacionProducto { get => _UsuarioModificacionProducto; set => _UsuarioModificacionProducto = value; }
        public int EstadoProducto { get => _EstadoProducto; set => _EstadoProducto = value; }
        public int ImagenProducto { get => _imagenProducto; set => _imagenProducto = value; }
        public int ModeloProducto { get => _modeloProducto; set => _modeloProducto = value; }

        public Producto()
        {

        }

        public Producto(
            int IdProducto, 
            string NombreProducto, 
            string DescripcionProducto, 
            string AnchoProducto, 
            string AltoProducto, 
            string ColorProducto, 
            string MaterialProducto, 
            int GarantiaMesesProducto, 
            long ValorUnitarioProducto,
            int imagenProducto,
            int modeloProducto,
            int CategoriaProducto, 
            DateTime FechaCreacionProducto, 
            string UsuarioCreacionProducto, 
            DateTime FechaModificacionProducto, 
            string UsuarioModificacionProducto, 
            int EstadoProducto)
        {
            this.IdProducto = IdProducto;
            this.NombreProducto = NombreProducto;
            this.DescripcionProducto = DescripcionProducto;
            this.AnchoProducto = AnchoProducto;
            this.AnchoProducto = AltoProducto;
            this.ColorProducto = ColorProducto;
            this.MaterialProducto = MaterialProducto;
            this.GarantiaMesesProducto = GarantiaMesesProducto;
            this.ValorUnitarioProducto = ValorUnitarioProducto;
            this.ImagenProducto = imagenProducto;
            this.ModeloProducto = modeloProducto;
            this.CategoriaProducto = CategoriaProducto;
            this.FechaCreacionProducto = FechaCreacionProducto;
            this.UsuarioCreacionProducto = UsuarioCreacionProducto;
            this.FechaModificacionProducto = FechaModificacionProducto;
            this.UsuarioModificacionProducto = UsuarioModificacionProducto;
            this.EstadoProducto = EstadoProducto;
        }
    }
}
