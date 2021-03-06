﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion.Categorias
{
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmCategorias fcategorias = new FrmCategorias();
            fcategorias.Show();
            this.Hide();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmProductos fProductos = new FrmProductos();
            fProductos.Show();
            this.Hide();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            FrmRoles frmRoles = new FrmRoles();
            frmRoles.Show();
            this.Hide();

        }

        private void btnTipoDocumento_Click(object sender, EventArgs e)
        {
            FrmTipoDocumento frmTipoDocumento = new FrmTipoDocumento();
            frmTipoDocumento.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmOrdenCompra frmOrdenCompra = new FrmOrdenCompra();
            frmOrdenCompra.Show();
        }
    }
}
