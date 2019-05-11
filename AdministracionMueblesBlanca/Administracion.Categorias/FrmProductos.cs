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

                if (item.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)item).DataSource=null;
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
            if (lista == null)
            {
                lista = blProducto.Listar();
            }

            if (lista.Count > 0)
            {
                dgvDatos.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    dgvDatos.Rows.Add(lista[i].IdProducto, lista[i].DescripcionProducto, lista[i].AnchoProducto,
                    lista[i].AltoProducto, lista[i].ColorProducto, lista[i].MaterialProducto, lista[i].GarantiaMesesProducto, lista[i].ValorUnitarioProducto
                    );
                }
            }


           

            //cargaCombos();
        }

        //public void cargaCombos()
        //{
        //    listaCategoria = blCategoria.ComboCategoria();
        //    if (listaCategoria.Count > 0)
        //    {
        //        cbCategoria.DataSource = listaCategoria;
        //        cbCategoria.ValueMember = "pIdCategoria";
        //        cbCategoria.DisplayMember = "pNombreCategoria";
        //    }
        //}

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int n = -1;

            decimal x = 0;
            if (txtAncho.Text.Length >= 0)
                x = Convert.ToDecimal(txtAncho.Text);
            else
                x = 0;

            if (_nuevo)
            {
               p = new Producto(0,txtNombre.Text, txtDescripcion.Text,txtAlto.Text, txtAncho.Text, txtColor.Text, txtMaterial.Text, int.Parse(txtGarantia.Text), long.Parse(txtValor.Text),
                   0,int.Parse(cbModelo.SelectedValue.ToString()), int.Parse(cbCategoria.SelectedValue.ToString()), DateTime.Now, "Administrador",DateTime.Now,null,1);
                    n = blProducto.Insertar(p);
                
            }
            else
            {
                p.NombreProducto = txtNombre.Text;
                p.DescripcionProducto = txtDescripcion.Text;
                p.AltoProducto = txtAlto.Text;
                p.AnchoProducto = txtAncho.Text;
                p.ColorProducto = txtColor.Text;
                p.MaterialProducto = txtMaterial.Text;
                p.GarantiaMesesProducto = int.Parse(txtGarantia.Text);
                p.ValorUnitarioProducto = int.Parse(txtValor.Text);
                //p.IdImagenProducto = 0;
                //p.IdModeloProducto = int.Parse(cbModelo.SelectedValue.ToString());
                //p.IdCategoriaProducto = int.Parse(cbCategoria.SelectedValue.ToString());
                //p.FechaCreacionProducto = txtNombre.Text;
                //p.UsuarioCreacionProducto = txtNombre.Text;
                //p.FechaModificacionProducto = txtNombre.Text;
                //p.UsuarioModificacionProducto = txtNombre.Text;
                //p.EstadoProducto = txtNombre.Text;


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
            ActivarButton(false);
            LimpiarControl(gbDatos);
            txtNombre.Focus();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            lista = null;
            _nuevo = false;
            //cargaCombos();

            if (dgvDatos.RowCount > 0)
            {
                p = blProducto.TraerPorId((int)dgvDatos[0, dgvDatos.CurrentRow.Index].Value);
                txtNombre.Text = p.NombreProducto;
                txtMaterial.Text = p.MaterialProducto;
                cbEstado.SelectedValue = p.EstadoProducto;
                cbModelo.SelectedValue = p.ModeloProducto;
                txtAlto.Text = p.AltoProducto;
                txtAncho.Text = p.AnchoProducto;
                txtColor.Text = p.ColorProducto;
                txtDescripcion.Text = p.DescripcionProducto;
                cbCategoria.SelectedValue = p.CategoriaProducto;
                ActivarControlDatos(gbDatos, true);
                ActivarButton(false);
                dgvDatos.Enabled = true;
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

        private void btBuscar_Click(object sender, EventArgs e)
        {
            lista = null;
            _nuevo = false;
            if (dgvDatos.RowCount > 0)
            {
               if (lista == null)
                {   
                    if (txtNombre.Text.Length > 0)
                        lista = blProducto.BuscarProducto("Referencia", txtNombre.Text);
                    if (txtAlto.Text.Length > 0)
                        lista = blProducto.BuscarProducto("Color", txtAlto.Text);
                    if (txtMaterial.Text.Length > 0)
                        lista = blProducto.BuscarProducto("Nombre", txtNombre.Text);
                    if (cbCategoria.SelectedIndex > 0)
                        lista = blProducto.BuscarProducto("Categoria", cbCategoria.SelectedValue.ToString());
                    if (cbEstado.SelectedIndex > 0)
                        lista = blProducto.BuscarProducto("Marca", cbEstado.SelectedValue.ToString());
                    if (cbModelo.SelectedIndex > 0)
                        lista = blProducto.BuscarProducto("Modelo", cbModelo.SelectedValue.ToString());
                }

                if (lista.Count > 0)
                {
                    dgvDatos.Rows.Clear();
                    for (int i = 0; i < lista.Count; i++)
                    {
                        dgvDatos.Rows.Add(lista[i].IdProducto, lista[i].DescripcionProducto, lista[i].AnchoProducto,
                     lista[i].AltoProducto, lista[i].ColorProducto, lista[i].MaterialProducto, lista[i].GarantiaMesesProducto, lista[i].ValorUnitarioProducto
                     );
                    }
                }

                LimpiarControl(gbDatos);
                dgvDatos.Enabled = true;
                ActivarControlDatos(gbDatos, false);
                ActivarButton(true);
                //cargaCombos();

            }
        }

    }
}
