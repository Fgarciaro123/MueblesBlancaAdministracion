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
    public partial class FrmUsuario : Form
    {
        Persona persona = new Persona();
        BLPersona bLPersona = new BLPersona();
        BLTipoDocumento bLTipoDocumento = new BLTipoDocumento();
        List<TipoDocumento> listaTipoDocumento = null;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

            listaTipoDocumento = bLTipoDocumento.Listar();
            cmbTipoId.DataSource = listaTipoDocumento;
            cmbTipoId.DisplayMember = "DescripcionTipoDocumento";
            cmbTipoId.ValueMember = "IdTipoDocumento";
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
                if (!IsValidEmail(txtEmail.Text.Trim()) || txtEmail.Text.Trim().IndexOf('.') == -1)
                {
                    MessageBox.Show("Email incorrecto", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (txtContraseña.Text.Trim().Equals(txtContraseña2.Text.Trim()))
                    {
                        int rol = bLPersona.ObtenerIdRolAdministrador();
                        if (rol > 0)
                        {

                            int n = -1;
                            persona = new Persona(
                                Convert.ToInt64(txtNroId.Text.Trim()),
                                Convert.ToInt16(cmbTipoId.SelectedValue.ToString()),
                                txtPrimerNombre.Text.Trim(),
                                txtSegundoNombre.Text.Trim(),
                                txtApellidos.Text.Trim(),
                                txtSegundoApellido.Text.Trim(),
                                txtEmail.Text.Trim(),
                                rol,
                                txtContraseña.Text.Trim(),
                                DateTime.Now
                                );
                            n = bLPersona.Insertar(persona);

                            if (n > 0)
                            {
                                enviarMensaje();
                                MessageBox.Show("Administrador creado correctamente", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Login login = new Login();
                                this.Hide();
                                login.Show();
                            }
                            else
                            {
                                MessageBox.Show("Error al grabar", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No existe Rol Administrador, hablar con soporte tecnico", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

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

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNroId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                 if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
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
            msg.Subject = "Registro Exitoso Muebles Blanca";
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = "Se ha registrado exitosamente en el sistema muebles blanca " +
                "sus credenciales son las siguientes: " +
                " " +
                "Usuario: " + txtEmail.Text.Trim() +
                " Contraseña: " + txtContraseña.Text.Trim() +
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
