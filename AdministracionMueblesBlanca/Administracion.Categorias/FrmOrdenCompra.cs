﻿using System;
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
    public partial class FrmOrdenCompra : Form
    {

        List<OrdenCompra> lista = null;
        BlOrdenCompra blOrdenCompra = new BlOrdenCompra();
        OrdenCompra c;
        public FrmOrdenCompra()
        {
            InitializeComponent();
            CargarDatos();
        }


        private void CargarDatos()
        {
            string _FechaPago;
            if (lista == null)
            {
                lista = blOrdenCompra.Listar();
            }
            if (lista.Count > 0)
            {
                btnVerDetalle.Enabled = true;
                dgvOrdenCompra.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].FechaPago.Year <= 2000)
                    {
                        _FechaPago = "";
                    }
                    else
                    {
                        _FechaPago = lista[i].FechaPago.ToString();
                    }

                    dgvOrdenCompra.Rows.Add(

                        lista[i].IdCompra,
                        lista[i].NroIdentificacion,
                        lista[i].NombrePersona,
                        lista[i].TotalCompra,                  
                        lista[i].FechaCompra,
                        _FechaPago);
                }
            }
            else
            {
                btnConfirmarPago.Enabled = false;
                btnVerDetalle.Enabled = false;
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmBienvenida bienvenida = new FrmBienvenida();
            bienvenida.Show();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            FrmDetalleOrden frmDetalleOrden = new FrmDetalleOrden((int)dgvOrdenCompra[0, dgvOrdenCompra.CurrentRow.Index].Value);
            frmDetalleOrden.Show();
            this.Hide();
        }

        private void btnConfirmarPago_Click(object sender, EventArgs e)
        {
            int n = blOrdenCompra.ConfirmarPago((int)dgvOrdenCompra[0, dgvOrdenCompra.CurrentRow.Index].Value);
            if (n >= 0)
            {
                MessageBox.Show("Pago realizado exitosamente", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                lista = null;
                CargarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo realizar el pago", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void dgvOrdenCompra_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvOrdenCompra.Rows)
            {
                if (row.Cells[5].Value.ToString() == "")
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }

            }
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBienvenida frmBienvenida = new FrmBienvenida();
            frmBienvenida.Show();
            this.Close();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.Show();
            this.Close();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias frmCategorias = new FrmCategorias();
            frmCategorias.Show();
            this.Close();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRoles frmRoles = new FrmRoles();
            frmRoles.Show();
            this.Close();
        }

        private void tiposDeDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoDocumento frmTipoDocumento = new FrmTipoDocumento();
            frmTipoDocumento.Show();
            this.Close();
        }

        private void administracionOrdenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrdenCompra frmOrdenCompra = new FrmOrdenCompra();
            frmOrdenCompra.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void cambioDeClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambioClave frmCambioClave = new FrmCambioClave();
            frmCambioClave.Show();
            this.Close();
        }
    }
}