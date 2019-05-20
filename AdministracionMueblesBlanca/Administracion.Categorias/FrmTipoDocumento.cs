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
    public partial class FrmTipoDocumento : Form
    {

        Validaciones validacion = new Validaciones();
        List<TipoDocumento> lista = null;
        BLTipoDocumento bLTipoDocumento = new BLTipoDocumento();
        TipoDocumento td;
        bool _nuevo = false;

        public FrmTipoDocumento()
        {
            InitializeComponent();
            ActivarControlDatos(gbDatos, false);
            CargarDatos();
        }

        private void FrmTipoDocumento_Load(object sender, EventArgs e)
        {

            //Carga Combobox Estado Tipo Documento
            cmbEstadoTipoDocumento.Items.Clear();
            cmbEstadoTipoDocumento.DataSource = Enum.GetValues(typeof(EnumEstados.Estados));
            cmbEstadoTipoDocumento.SelectedIndex = 0;

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
                lista = bLTipoDocumento.Listar();
            }
            if (lista.Count > 0)
            {
                dgvTipoDocumento.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].FechaModificacionTipoDocumento.Year <= 2000)
                    {
                        _fechaModificacion = "";
                    }
                    else
                    {
                        _fechaModificacion = lista[i].FechaModificacionTipoDocumento.ToString();
                    }

                    dgvTipoDocumento.Rows.Add(

                        lista[i].IdTipoDocumento,
                        lista[i].DescripcionTipoDocumento,
                        (EnumEstados.Estados)lista[i].EstadoTipoDocumento,
                        lista[i].FechaCreacionTipoDocumento,
                        lista[i].UsuarioCreacionTipoDocumento,
                        _fechaModificacion,
                        lista[i].UsuarioModificacionTipoDocumento);
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
            txtDescripcionTipoDocumento.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtDescripcionTipoDocumento.Text.Trim() != "")
            {
                int n = -1;
                if (_nuevo)
                {
                    td = new TipoDocumento(
                        txtDescripcionTipoDocumento.Text.Trim(),
                        DateTime.Now,
                        sesion.UsuarioSesion,
                        cmbEstadoTipoDocumento.SelectedIndex);
                    n = bLTipoDocumento.Insertar(td);
                }
                else
                {
                    td = new TipoDocumento(Convert.ToInt32(txtIdTipoDocumento.Text),
                                            txtDescripcionTipoDocumento.Text.Trim(),
                                            DateTime.Now,
                                            sesion.UsuarioSesion,
                                            cmbEstadoTipoDocumento.SelectedIndex);
                    n = bLTipoDocumento.Actualizar(td);
                }
                if (n > 0)
                {
                    MessageBox.Show("Datos grabados correctamente", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActivarControlDatos(gbDatos, false);
                    ActivarButton(true);
                    dgvTipoDocumento.Enabled = true;
                    LimpiarControl(gbDatos);
                    btnEditar.Text = "Editar";
                    lista = bLTipoDocumento.Listar();
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
                MessageBox.Show("Ingrese la descripción de tipo de documento", "Aviso",
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
                dgvTipoDocumento.Enabled = true;
                btnEditar.Text = "Editar";
            }
            else
            {
                if (dgvTipoDocumento.RowCount > 0)
                {
                    td = bLTipoDocumento.TraerPorId((int)dgvTipoDocumento[0, dgvTipoDocumento.
                        CurrentRow.Index].Value);
                    txtIdTipoDocumento.Text = td.IdTipoDocumento.ToString();
                    txtDescripcionTipoDocumento.Text = td.DescripcionTipoDocumento;
                    cmbEstadoTipoDocumento.SelectedIndex = td.EstadoTipoDocumento;

                    ActivarControlDatos(gbDatos, true);
                    ActivarButton(false);
                    dgvTipoDocumento.Enabled = false;
                    btnEditar.Text = "Cancelar";
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (bLTipoDocumento.CantidadPersonasPorTipoDocumento((int)dgvTipoDocumento[0, dgvTipoDocumento.CurrentRow.Index].Value) >= 0)
            {
                if (dgvTipoDocumento.RowCount > 0)
                {
                    td = bLTipoDocumento.TraerPorId((int)dgvTipoDocumento[0, dgvTipoDocumento.
                        CurrentRow.Index].Value);
                    DialogResult rpta =
                        MessageBox.Show("Desea eliminar el registro", "Eliminar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rpta == System.Windows.Forms.DialogResult.Yes)
                    {
                        int n = bLTipoDocumento.Eliminar(td.IdTipoDocumento);
                        if (n > 0)
                        {
                            MessageBox.Show("Registro eliminado", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lista = bLTipoDocumento.Listar();
                            CargarDatos();
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Es tipo de documento esta atado a clientes, no se puede eliminar, " +
                "Debe eliminar primero los clientes atados al tipo de documento", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmBienvenida frmInicio = new FrmBienvenida();
            frmInicio.Show();
            this.Hide();
        }

    }


}
