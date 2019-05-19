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
        string _AltoProducto;
        string _AnchoProducto;
        string _ColorProducto;
        string _MaterialProducto;
        int _GarantiaMesesProducto;
        Decimal _ValorUnitarioProducto;
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
        public Decimal ValorUnitarioProducto { get => _ValorUnitarioProducto; set => _ValorUnitarioProducto = value; }
        public int CategoriaProducto { get => _CategoriaProducto; set => _CategoriaProducto = value; }
        public DateTime FechaCreacionProducto { get => _FechaCreacionProducto; set => _FechaCreacionProducto = value; }
        public string UsuarioCreacionProducto { get => _UsuarioCreacionProducto; set => _UsuarioCreacionProducto = value; }
        public DateTime FechaModificacionProducto { get => _FechaModificacionProducto; set => _FechaModificacionProducto = value; }
        public string UsuarioModificacionProducto { get => _UsuarioModificacionProducto; set => _UsuarioModificacionProducto = value; }
        public int EstadoProducto { get => _EstadoProducto; set => _EstadoProducto = value; }

        public Producto()
        {

        }

        //Constructor crear producto
        public Producto(
            string pNombreProducto, 
            string pDescripcionProducto, 
            string pAnchoProducto, 
            string pAltoProducto, 
            string pColorProducto, 
            string pMaterialProducto, 
            int pGarantiaMesesProducto,
            Decimal pValorUnitarioProducto,
            int pCategoriaProducto, 
            DateTime pFechaCreacionProducto, 
            string pUsuarioCreacionProducto, 
            int pEstadoProducto)
        {
            this.NombreProducto = pNombreProducto;
            this.DescripcionProducto = pDescripcionProducto;
            this.AnchoProducto = pAnchoProducto;
            this.AltoProducto = pAltoProducto;
            this.ColorProducto = pColorProducto;
            this.MaterialProducto = pMaterialProducto;
            this.GarantiaMesesProducto = pGarantiaMesesProducto;
            this.ValorUnitarioProducto = pValorUnitarioProducto;
            this.CategoriaProducto = pCategoriaProducto;
            this.FechaCreacionProducto = pFechaCreacionProducto;
            this.UsuarioCreacionProducto = pUsuarioCreacionProducto;
            this.EstadoProducto = pEstadoProducto;
        }


        //constructor modificar
        public Producto(
            int pIdProducto,
            string pNombreProducto,
            string pDescripcionProducto,
            string pAnchoProducto,
            string pAltoProducto,
            string pColorProducto,
            string pMaterialProducto,
            int pGarantiaMesesProducto,
            Decimal pValorUnitarioProducto,
            int pCategoriaProducto,
            DateTime pFechaModificacionProducto,
            string pUsuarioModificacionProducto,
            int pEstadoProducto)
        {
            this.IdProducto = pIdProducto;
            this.NombreProducto = pNombreProducto;
            this.DescripcionProducto = pDescripcionProducto;
            this.AnchoProducto = pAnchoProducto;
            this.AltoProducto = pAltoProducto;
            this.ColorProducto = pColorProducto;
            this.MaterialProducto = pMaterialProducto;
            this.GarantiaMesesProducto = pGarantiaMesesProducto;
            this.ValorUnitarioProducto = pValorUnitarioProducto;
            this.CategoriaProducto = pCategoriaProducto;
            this.FechaModificacionProducto = pFechaModificacionProducto;
            this.UsuarioModificacionProducto = pUsuarioModificacionProducto;
            this.EstadoProducto = pEstadoProducto;
        }

        //constructor listar
        public Producto(
            int pIdProducto,
            string pNombreProducto,
            string pDescripcionProducto,
            string pAnchoProducto,
            string pAltoProducto,
            string pColorProducto,
            string pMaterialProducto,
            int pGarantiaMesesProducto,
            Decimal pValorUnitarioProducto,
            int pCategoriaProducto,
            DateTime pFechaCreacionProducto,
            string pUsuarioCreacionProducto,
            DateTime pFechaModificacionProducto,
            string pUsuarioModificacionProducto,
            int pEstadoProducto)
        {
            this.IdProducto = pIdProducto;
            this.NombreProducto = pNombreProducto;
            this.DescripcionProducto = pDescripcionProducto;
            this.AnchoProducto = pAnchoProducto;
            this.AltoProducto = pAltoProducto;
            this.ColorProducto = pColorProducto;
            this.MaterialProducto = pMaterialProducto;
            this.GarantiaMesesProducto = pGarantiaMesesProducto;
            this.ValorUnitarioProducto = pValorUnitarioProducto;
            this.CategoriaProducto = pCategoriaProducto;
            this.FechaCreacionProducto = pFechaCreacionProducto;
            this.UsuarioCreacionProducto = pUsuarioCreacionProducto;
            this.FechaModificacionProducto = pFechaModificacionProducto;
            this.UsuarioModificacionProducto = pUsuarioModificacionProducto;
            this.EstadoProducto = pEstadoProducto;
        }
    }
}
