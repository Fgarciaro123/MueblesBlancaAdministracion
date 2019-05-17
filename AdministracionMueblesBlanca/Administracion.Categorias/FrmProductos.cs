using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Importamos la referencia para esto agregamos la siguiente instrucción.

using Administracion.Entidades;
using Administracion.Negocio;

namespace Administracion.Categorias
{
    public partial class FrmProductos : Form
    {
        //Declaramos las variables generales
        List<Producto> lista = null;
        List<Categoria> listaCategoria = null;
        public int idProductoImagen;

        BLProducto blProducto = new BLProducto();
        BLCategoria blCategoria = new BLCategoria();
        BLModelo blModelo = new BLModelo();
        Producto p;
        bool _nuevo = false;

        public FrmProductos()
        {
            InitializeComponent();
            btnSalir.Enabled = true;
            ActivarControlDatos(gbDatos, false);
            CargarDatos();

        }

        //Creamos un método que permita activar los controles
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

        //Creamos un método que limpie los controles
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

        //Creamos un método que Active los Botones
        private void ActivarButton(bool Estado)
        {
            btnNuevo.Enabled = Estado;
            btnGrabar.Enabled = !Estado;
            btnEliminar.Enabled = Estado;
        }

        //Creamos el método CargarDatos
        private void CargarDatos()
        {
            Categoria categoria = new Categoria();
            if (lista == null)
            {
                lista = blProducto.Listar();
            }

            if (lista.Count > 0)
            {
                dgvDatos.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    categoria = blCategoria.TraerPorId(lista[i].CategoriaProducto);
                    dgvDatos.Rows.Add(
                    lista[i].IdProducto,
                    lista[i].NombreProducto,
                    lista[i].DescripcionProducto,
                    lista[i].AltoProducto,
                    lista[i].AnchoProducto,
                    lista[i].ColorProducto,
                    lista[i].MaterialProducto,
                    lista[i].GarantiaMesesProducto,
                    lista[i].ValorUnitarioProducto,
                    categoria.NombreCategoria);

                }
            }

        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int n = -1;

            if (_nuevo)
            {
                p = new Producto(
                    0,
                    txtNombre.Text,
                    txtDescripcion.Text,
                    txtAlto.Text,
                    txtAncho.Text,
                    txtColor.Text,
                    txtMaterial.Text,
                    int.Parse(txtGarantia.Text),
                    long.Parse(txtValor.Text),
                    cbCategoria.SelectedIndex,
                    DateTime.Now,
                    "Administrador",
                    DateTime.Now,
                    null,
                    cbEstado.SelectedIndex);
                n = blProducto.Insertar(p);

            }
            else
            {
                p.IdProducto = int.Parse(txtIdProducto.Text.Trim());
                p.NombreProducto = txtNombre.Text.Trim();
                p.DescripcionProducto = txtDescripcion.Text.Trim();
                p.AltoProducto = txtAlto.Text.Trim();
                p.AnchoProducto = txtAncho.Text.Trim();
                p.ColorProducto = txtColor.Text.Trim();
                p.MaterialProducto = txtMaterial.Text.Trim();
                p.GarantiaMesesProducto = int.Parse(txtGarantia.Text.Trim());
                p.ValorUnitarioProducto = Decimal.Parse(txtValor.Text.Trim());
                p.CategoriaProducto = int.Parse(cbCategoria.SelectedValue.ToString());
                p.FechaModificacionProducto = DateTime.Now;
                p.UsuarioModificacionProducto = "Administrador";
                p.EstadoProducto = int.Parse(cbEstado.SelectedIndex.ToString());

                n = blProducto.Actualizar(p);
            }
            if (n > 0)
            {
                MessageBox.Show("Datos grabados correctamente", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActivarControlDatos(gbDatos, false);
                ActivarButton(true);
                dgvDatos.Enabled = true;
                LimpiarControl(gbDatos);
                lista = blProducto.Listar();
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Error al grabar", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            _nuevo = true;
            ActivarControlDatos(gbDatos, true);
            btnEditar.Text = "Cancelar";
            ActivarButton(false);
            LimpiarControl(gbDatos);
            txtNombre.Focus();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            _nuevo = false;
            if (btnEditar.Text == "Cancelar")
            {
                LimpiarControl(gbDatos);
                ActivarControlDatos(gbDatos, false);
                ActivarButton(true);
                dgvDatos.Enabled = true;
                btnEditar.Text = "Editar";
            }
            else
            {
                if (dgvDatos.RowCount > 0)
                {
                    p = blProducto.TraerPorId((int)dgvDatos[0, dgvDatos.
                        CurrentRow.Index].Value);
                    txtIdProducto.Text = p.IdProducto.ToString();
                    txtNombre.Text = p.NombreProducto;
                    txtDescripcion.Text = p.DescripcionProducto;
                    txtAlto.Text = p.AltoProducto;
                    txtAncho.Text = p.AnchoProducto;
                    txtColor.Text = p.ColorProducto;
                    txtMaterial.Text = p.MaterialProducto;
                    txtGarantia.Text = p.GarantiaMesesProducto.ToString();
                    txtValor.Text = p.ValorUnitarioProducto.ToString();
                    cbCategoria.SelectedIndex = p.CategoriaProducto;
                    cbEstado.SelectedIndex = p.EstadoProducto;

                    ActivarControlDatos(gbDatos, true);
                    ActivarButton(false);
                    dgvDatos.Enabled = false;
                    btnEditar.Text = "Cancelar";
                }
            }

        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvDatos.RowCount > 0)
            {
                p = blProducto.TraerPorId((int)dgvDatos[0, dgvDatos.
                    CurrentRow.Index].Value);
                DialogResult rpta =
                    MessageBox.Show("Desea eliminar el registro", "Eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == System.Windows.Forms.DialogResult.Yes)
                {
                    int n = blProducto.Eliminar(p.IdProducto);
                    if (n > 0)
                    {
                        MessageBox.Show("Registro eliminado", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lista = blProducto.Listar();
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

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            FrmBienvenida frmInicio = new FrmBienvenida();
            frmInicio.Show();
            this.Hide();
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {

            LimpiarControl(gbDatos);
            txtNombre.Focus();
            dgvDatos.Enabled = true;
            ActivarControlDatos(gbDatos, false);
            ActivarButton(true);
            CargarDatos();
        }

        //private void btBuscar_Click(object sender, EventArgs e)
        //{
        //    lista = null;
        //    _nuevo = false;
        //    if (dgvDatos.RowCount > 0)
        //    {
        //       if (lista == null)
        //        {   
        //            if (txtNombre.Text.Length > 0)
        //                lista = blProducto.BuscarProducto("Referencia", txtNombre.Text);
        //            if (txtAlto.Text.Length > 0)
        //                lista = blProducto.BuscarProducto("Color", txtAlto.Text);
        //            if (txtMaterial.Text.Length > 0)
        //                lista = blProducto.BuscarProducto("Nombre", txtNombre.Text);
        //            if (cbCategoria.SelectedIndex > 0)
        //                lista = blProducto.BuscarProducto("Categoria", cbCategoria.SelectedValue.ToString());
        //            if (cbEstado.SelectedIndex > 0)
        //                lista = blProducto.BuscarProducto("Marca", cbEstado.SelectedValue.ToString());
        //            if (cbModelo.SelectedIndex > 0)
        //                lista = blProducto.BuscarProducto("Modelo", cbModelo.SelectedValue.ToString());
        //        }

        //        if (lista.Count > 0)
        //        {
        //            dgvDatos.Rows.Clear();
        //            for (int i = 0; i < lista.Count; i++)
        //            {
        //                dgvDatos.Rows.Add(lista[i].IdProducto, lista[i].DescripcionProducto, lista[i].AnchoProducto,
        //             lista[i].AltoProducto, lista[i].ColorProducto, lista[i].MaterialProducto, lista[i].GarantiaMesesProducto, lista[i].ValorUnitarioProducto
        //             );
        //            }
        //        }

        //        LimpiarControl(gbDatos);
        //        dgvDatos.Enabled = true;
        //        ActivarControlDatos(gbDatos, false);
        //        ActivarButton(true);
        //        //cargaCombos();

        //    }
        //}

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            //Carga Combobox Estado 
            cbEstado.Items.Clear();
            cbEstado.DataSource = Enum.GetValues(typeof(EnumEstados.Estados));
            cbEstado.SelectedIndex = 0;

            //Carga Combo Categorias

            listaCategoria = blCategoria.ComboCategoria();
            cbCategoria.DataSource = listaCategoria;
            cbCategoria.DisplayMember = "NombreCategoria";
            cbCategoria.ValueMember = "IdCategoria";

        }

        private void btnGestionImagenes_Click(object sender, EventArgs e)
        {
            FrmImagen frmImagen = new FrmImagen((int)dgvDatos[0, dgvDatos.CurrentRow.Index].Value);
            frmImagen.Show();
            this.Hide();

        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            FrmModelos frmModelos = new FrmModelos((int)dgvDatos[0, dgvDatos.CurrentRow.Index].Value);
            frmModelos.Show();
            this.Hide();

        }

        private void txtGarantia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
