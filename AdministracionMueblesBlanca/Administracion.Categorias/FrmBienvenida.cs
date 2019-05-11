using System;
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
    }
}
