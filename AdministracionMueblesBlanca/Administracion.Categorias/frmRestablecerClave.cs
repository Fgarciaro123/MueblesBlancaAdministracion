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
    public partial class frmRestablecerClave : Form
    {
        BLPersona bLPersona = new BLPersona();
        string NuevaClave;
        Login login = new Login();

        public frmRestablecerClave()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            if (!txtEmail.Text.Trim().Equals(""))
            {
                if (!IsValidEmail(txtEmail.Text.Trim()) || txtEmail.Text.Trim().IndexOf('.') == -1)
                {
                    MessageBox.Show("Email incorrecto", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (bLPersona.ValidarExistenciaEmail(txtEmail.Text.Trim()))
                    {
                        NuevaClave = GenerarClave.Generate();

                        if (bLPersona.ActualizarContraseña(txtEmail.Text.Trim(), NuevaClave))
                        {
                            enviarMensaje();
                            MessageBox.Show("Se actualizo su contraseña, Valide el correo", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            login.Show();
                             
                        }
                        else
                        {
                            MessageBox.Show("No se pudo restablecer contraseña", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    else
                    {
                        MessageBox.Show("Email no se encuentra registrado", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un correo electrónico", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }


        public void enviarMensaje()
        {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.To.Add(txtEmail.Text.Trim());
            msg.Subject = "Restauracion Contraseña Exitosa Muebles Blanca";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = "Su contraseña del sistema muebles blanca se ha restablecido exitosamente " +
                "sus credenciales son las siguientes: " +
                " " +
                "Usuario: " + txtEmail.Text.Trim() +
                " Contraseña: " + NuevaClave +
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

    }
}
