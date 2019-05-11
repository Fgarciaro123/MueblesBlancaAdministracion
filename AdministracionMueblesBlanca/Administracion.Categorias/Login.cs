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
    public partial class Login : Form
    {
        BLUsuario blUsuario = new BLUsuario();
        Usuario u;
      
        public Login()
        {
            InitializeComponent();
            lbError.Text = "";
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            u = blUsuario.TraerPorUsuarioClave((string)txtUsuario.Text, (string)txtClave.Text);
            if (u.IdUsuario.ToString() != null & u.IdUsuario > 0)
            {
                lbError.Text = "";
                FrmBienvenida frmBienvenida = new FrmBienvenida();
                frmBienvenida.Show();
                this.Hide();
            }
            else
            {
                lbError.Text = "Datos de acceso incorrectos";
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            
        }

    }
}
