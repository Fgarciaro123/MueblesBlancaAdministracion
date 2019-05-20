using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Administracion.Entidades;
using Administracion.Negocio;

namespace Administracion.Categorias
{
    public partial class FrmDetalleOrden : Form
    {
        List<DetalleOrden> lista = null;
        BLDetalleOrden bLDetalleOrden = new BLDetalleOrden();
        DetalleOrden c;
        int idOrdendeCompra;
        public FrmDetalleOrden(int pIdOrden)
        {
            idOrdendeCompra = pIdOrden;
            InitializeComponent();
            CargarDatos();
        }


        private void CargarDatos()
        {
            string _FechaPago;
            if (lista == null)
            {
                lista = bLDetalleOrden.Listar(idOrdendeCompra);
            }
            if (lista.Count > 0)
            {
                dgvDetalleOrden.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].FechaPagoOrden.Year <= 2000)
                    {
                        _FechaPago = "";
                    }
                    else
                    {
                        _FechaPago = lista[i].FechaPagoOrden.ToString();
                    }

                    txtNroOrden.Text = lista[i].IdOrdenCompra.ToString();
                    txtNroId.Text = lista[i].NroIdPersona.ToString();
                    txtNombrePersona.Text = lista[i].NombrePersona.ToString();
                    txtDireccion.Text = lista[i].DireccionPersona.ToString();
                    txtEmail.Text = lista[i].EmailPersona.ToString();
                    txtCelular.Text = lista[i].CelularPersona.ToString();
                    txtFechaPago.Text = lista[i].NroIdPersona.ToString();
                    txtFechaCompra.Text = lista[i].NroIdPersona.ToString();

                    dgvDetalleOrden.Rows.Add(

                        lista[i].IdDetalleCompra,
                        lista[i].NombreProducto,
                        lista[i].CantidadDetalle,
                        lista[i].ValorProducto,
                        lista[i].SubtotalDetalle );
                }
            }

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmOrdenCompra frmOrdenCompra = new FrmOrdenCompra();
            frmOrdenCompra.Show();
        }
    }
}
