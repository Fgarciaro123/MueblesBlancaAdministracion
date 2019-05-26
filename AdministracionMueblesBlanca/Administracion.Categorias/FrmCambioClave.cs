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
    public partial class FrmCambioClave : Form
    {
        Login login = new Login();
        BLPersona bLPersona = new BLPersona();
        public FrmCambioClave()
        {
            InitializeComponent();
            btnGuardar.Text = "Validar";
            txtConfirmacion.Enabled = false;
            txtNuevaContraseña.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (btnGuardar.Text.ToString() == "Validar")
            {
                if (bLPersona.TraerPorPersonaClave(sesion.UsuarioSesion, txtContraseñaActual.Text))
                {
                    btnGuardar.Text = "Guardar";
                    txtConfirmacion.Enabled = true;
                    txtNuevaContraseña.Enabled = true;
                    txtContraseñaActual.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                if (txtNuevaContraseña.Text.Trim() != "")
                {

                    if (txtNuevaContraseña.Text.Trim().Equals(txtConfirmacion.Text.Trim()))
                    {
                        if (bLPersona.ActualizarContraseña(sesion.UsuarioSesion, txtNuevaContraseña.Text.Trim()))
                        {
                            enviarMensaje();
                            MessageBox.Show("Se actualizo su contraseña, Valide el correo", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            login.Show();

                        }
                        else
                        {
                            MessageBox.Show("No se pudo cambiar la contraseña", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        txtNuevaContraseña.Focus();
                        txtConfirmacion.Clear();
                        MessageBox.Show("Las contraseñas no coinciden", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    txtNuevaContraseña.Focus();
                    MessageBox.Show("Debe ingresar una contraseña nueva", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
        }

        public void enviarMensaje()
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add(sesion.UsuarioSesion.Trim());
            msg.Subject = "Cambio de Contraseña Exitosa Muebles Blanca";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = "Su contraseña del sistema muebles blanca se ha cambiado exitosamente " +
                "sus credenciales son las siguientes: " +
                " " +
                "Usuario: " + sesion.UsuarioSesion.Trim() +
                " Contraseña: " + txtNuevaContraseña.Text.Trim() +
                " " +
                "Gracias ";

            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = false;
            msg.From = new System.Net.Mail.MailAddress("muebles.blanca.sistema@gmail.com");


            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();
            cliente.Credentials = new System.Net.NetworkCredential("muebles.blanca.sistema@gmail.com", "Blanca123");

            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.Host = "smtp.gmail.com";
            try
            {
                cliente.Send(msg);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al enviar");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmBienvenida frmBienvenida = new FrmBienvenida();
            frmBienvenida.Show();
            this.Close();
        }
    }
}
