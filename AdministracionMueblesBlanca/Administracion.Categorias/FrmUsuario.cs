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
    public partial class FrmUsuario : Form
    {

        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarVacios() is false)
            {
              MessageBox.Show("Diligencie todos los campos", "Aviso",
              MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (txtContraseña.Text.Trim().Equals(txtContraseña2.Text.Trim()))
                {


                }
                else
                {
                    txtContraseña.Focus();
                    txtContraseña2.Clear();
                    MessageBox.Show("Las contraseñas no coinciden", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private Boolean ValidarVacios()
        {
            foreach (Control item in gbDatos.Controls)
            {
                if (item is TextBox)
                {
                    TextBox aux = (TextBox)item;
                    if (string.IsNullOrEmpty(aux.Text.Trim()))
                    {
                        return false;
                    }

                }
            }
            return true;

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }
    }
}
