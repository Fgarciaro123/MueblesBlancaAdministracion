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
        BLPersona blUsuario = new BLPersona();
        Boolean existe;
      
        public Login()
        {
            InitializeComponent();
            lbError.Text = "";
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            existe = blUsuario.TraerPorPersonaClave((string)txtUsuario.Text, (string)txtClave.Text);
            if (existe)
            {
                sesion.UsuarioSesion = txtUsuario.Text.Trim();
                lbError.Text = "";
                FrmBienvenida frmBienvenida = new FrmBienvenida();
                frmBienvenida.Show();
                this.Hide();
            }
            else
            {
                lbError.Text = "Nombre de usuario o contraseña inválida.";
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            sesion.UsuarioSesion = null;
            this.Close();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            txtClave.MaxLength = 8;
            txtClave.PasswordChar = '*';
            txtClave.CharacterCasing = CharacterCasing.Lower;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRestablecerClave frmRestablecer = new frmRestablecerClave();
            frmRestablecer.Show();
            this.Hide();
        }
    }
}
