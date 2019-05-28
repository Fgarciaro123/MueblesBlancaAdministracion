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
    public partial class FrmRoles : Form
    {

        Validaciones validacion = new Validaciones();
        List<Rol> lista = null;
        BLRol bLRol = new BLRol();
        Rol rol;
        bool _nuevo = false;

        public FrmRoles()
        {
            InitializeComponent();
            ActivarControlDatos(gbDatos, false);
            CargarDatos();
        }

        private void FrmRoles_Load(object sender, EventArgs e)
        {
            //Carga Combobox Estado Roles
            cmbEstadoRol.Items.Clear();
            cmbEstadoRol.DataSource = Enum.GetValues(typeof(EnumEstados.Estados));
            cmbEstadoRol.SelectedIndex = 0;
            cmbEstadoRol.Enabled = false;

            btnGrabar.Enabled = false;

        }

        private void ActivarControlDatos(Control Contenedor, bool Estado)
        {
            try
            {
                foreach (var item in Contenedor.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        ((TextBox)item).Enabled = Estado;
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        private void LimpiarControl(Control Contenedor)
        {
            foreach (var item in Contenedor.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    ((TextBox)item).Clear();
                }
            }
        }


        private void ActivarButton(bool Estado)
        {
            btnNuevo.Enabled = Estado;
            btnGrabar.Enabled = !Estado;
            btnEliminar.Enabled = Estado;
            btnSalir.Enabled = Estado;
        }

        private void CargarDatos()
        {
            string _fechaModificacion;
            if (lista == null)
            {
                lista = bLRol.Listar();
            }
            if (lista.Count > 0)
            {
                dgvRol.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].FechaModificacionRol.Year <= 2000)
                    {
                        _fechaModificacion = "";
                    }
                    else
                    {
                        _fechaModificacion = lista[i].FechaModificacionRol.ToString();
                    }

                    dgvRol.Rows.Add(

                        lista[i].IdRol,
                        lista[i].NombreRol,
                        (EnumEstados.Estados)lista[i].EstadoRol,
                        lista[i].FechaCreacionRol,
                        lista[i].UsuarioCreacionRol,
                        _fechaModificacion,
                        lista[i].UsuarioModificacionRol);
                }
            }


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _nuevo = true;
            ActivarControlDatos(gbDatos, true);
            btnEditar.Text = "Cancelar";
            ActivarButton(false);
            LimpiarControl(gbDatos);
            txtNombreRol.Focus();
            cmbEstadoRol.Enabled = true;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtNombreRol.Text.Trim() != "")
            {
                int n = -1;
                if (_nuevo)
                {
                    rol = new Rol(
                        txtNombreRol.Text.Trim(),
                        sesion.UsuarioSesion,
                        DateTime.Now,
                        cmbEstadoRol.SelectedIndex);
                    n = bLRol.Insertar(rol);
                }
                else
                {
                    rol = new Rol(
                        Convert.ToInt32(txtIdRol.Text),
                        txtNombreRol.Text.Trim(),
                        sesion.UsuarioSesion,
                        DateTime.Now,
                        cmbEstadoRol.SelectedIndex);

                    n = bLRol.Actualizar(rol);
                }
                if (n > 0)
                {
                    MessageBox.Show("Datos grabados correctamente", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActivarControlDatos(gbDatos, false);
                    ActivarButton(true);
                    dgvRol.Enabled = true;
                    LimpiarControl(gbDatos);
                    btnEditar.Text = "Editar";
                    lista = bLRol.Listar();
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("Error al grabar", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Ingrese el nombre de Rol", "Aviso",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            _nuevo = false;
            if (btnEditar.Text == "Cancelar")
            {
                LimpiarControl(gbDatos);
                ActivarControlDatos(gbDatos, false);
                ActivarButton(true);
                dgvRol.Enabled = true;
                btnEditar.Text = "Editar";
            }
            else
            {
                if (dgvRol.RowCount > 0)
                {
                    if ((int)dgvRol[0, dgvRol.CurrentRow.Index].Value != 1)
                    {
                        rol = bLRol.TraerPorId((int)dgvRol[0, dgvRol.
                        CurrentRow.Index].Value);
                        txtIdRol.Text = rol.IdRol.ToString();
                        txtNombreRol.Text = rol.NombreRol;
                        cmbEstadoRol.SelectedIndex = rol.EstadoRol;

                        ActivarControlDatos(gbDatos, true);
                        ActivarButton(false);
                        dgvRol.Enabled = false;
                        btnEditar.Text = "Cancelar";
                    }
                    else
                    {
                        MessageBox.Show("El Rol administrador no se puede editar", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRol.RowCount > 0)
            {

                if ((int)dgvRol[0, dgvRol.CurrentRow.Index].Value != 1)
                {

                    if (bLRol.CantidadRolPorPersona((int)dgvRol[0, dgvRol.CurrentRow.Index].Value) < 1)
                    {

                        rol = bLRol.TraerPorId((int)dgvRol[0, dgvRol.
                        CurrentRow.Index].Value);
                        DialogResult rpta =
                            MessageBox.Show("Desea eliminar el registro", "Eliminar",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rpta == System.Windows.Forms.DialogResult.Yes)
                        {
                            int n = bLRol.Eliminar(rol.IdRol);
                            if (n > 0)
                            {
                                MessageBox.Show("Registro eliminado", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvRol.Rows.Clear();
                                lista = bLRol.Listar();
                                CargarDatos();
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar", "Aviso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                            MessageBox.Show("Es rol esta atado a clientes, no se puede eliminar, " +
                                "Debe eliminar primero los clientes atados al rol", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("El Rol administrador no se puede eliminar", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmBienvenida frmInicio = new FrmBienvenida();
            frmInicio.Show();
            this.Hide();
        }

        private void cambiarClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBienvenida frmBienvenida = new FrmBienvenida();
            frmBienvenida.Show();
            this.Close();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.Show();
            this.Close();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias frmCategorias = new FrmCategorias();
            frmCategorias.Show();
            this.Close();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRoles frmRoles = new FrmRoles();
            frmRoles.Show();
            this.Close();
        }

        private void tiposDeDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoDocumento frmTipoDocumento = new FrmTipoDocumento();
            frmTipoDocumento.Show();
            this.Close();
        }

        private void administracionOrdenesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrdenCompra frmOrdenCompra = new FrmOrdenCompra();
            frmOrdenCompra.Show();
            this.Close();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void cambioDeClaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCambioClave frmCambioClave = new FrmCambioClave();
            frmCambioClave.Show();
            this.Close();
        }
    }
}
