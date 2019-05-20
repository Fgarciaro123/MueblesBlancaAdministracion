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
                        lista[i].NombreProducto,
                        lista[i].TotalCompra,                  
                        lista[i].FechaCompra,
                        _FechaPago);
                }
            }
            else
            {
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
    }
}