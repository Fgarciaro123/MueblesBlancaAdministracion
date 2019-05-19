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
            this.Close();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            txtClave.MaxLength = 8;
            txtClave.PasswordChar = '*';
            txtClave.CharacterCasing = CharacterCasing.Lower;
        }
    }
}
