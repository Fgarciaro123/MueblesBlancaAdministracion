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
    public partial class FrmCategorias : Form
    {

        List<Categoria> lista = null;
        BLCategoria blCategoria = new BLCategoria();
        Categoria c;
        bool _nuevo = false;

        public FrmCategorias()
        {
            InitializeComponent();
            ActivarControlDatos(gbDatos, false);
            CargarDatos();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            //Carga Combobox Estado Categoria
            cmbEstadoCategoria.Items.Clear();
            cmbEstadoCategoria.DataSource = Enum.GetValues(typeof(EnumEstados.Estados));
            cmbEstadoCategoria.SelectedIndex = 0;


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
            if (lista == null)
            {
                lista = blCategoria.Listar();
            }
            if (lista.Count > 0)
            {
                dgvCategoria.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    dgvCategoria.Rows.Add(lista[i].IdCategoria, lista[i].NombreCategoria,
                       (EnumEstados.Estados)lista[i].EstadoCategoria, lista[i].FechaCreacionCategoria, lista[i].UsuarioCreacionCategoria,
                        lista[i].FechaModificacionCategoria, lista[i].UsuarioModificacionCategoria);
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
            txtIdCategoria.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int n = -1;
            if (_nuevo)
            {
                //c = new Categoria(0, txtIdCategoria.Text,
                //    txtNombreCategoria.Text, );
                //n = blCategoria.Insertar(c);
            }
            else
            {
                //c.Codigo = txtCodigo.Text;
                //c.Nombre = txtNombre.Text;
                //c.Observacion = txtObservacion.Text;
                //n = blCategoria.Actualizar(c);
            }
            if (n > 0)
            {
                MessageBox.Show("Datos grabados correctamente", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActivarControlDatos(gbDatos, false);
                ActivarButton(true);
                dgvCategoria.Enabled = true;
                LimpiarControl(gbDatos);
                btnEditar.Text = "Editar";
                lista = blCategoria.Listar();
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Error al grabar", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dgvCategoria.Enabled = true;
                btnEditar.Text = "Editar";
            }
            else
            {
                if (dgvCategoria.RowCount > 0)
                {
                    c = blCategoria.TraerPorId((int)dgvCategoria[0, dgvCategoria.
                        CurrentRow.Index].Value);
                    txtIdCategoria.Text = c.IdCategoria.ToString();
                    txtNombreCategoria.Text = c.NombreCategoria;

                    ActivarControlDatos(gbDatos, true);
                    ActivarButton(false);
                    dgvCategoria.Enabled = false;
                    btnEditar.Text = "Cancelar";
                }
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.RowCount > 0)
            {
                c = blCategoria.TraerPorId((int)dgvCategoria[0, dgvCategoria.
                    CurrentRow.Index].Value);
                DialogResult rpta =
                    MessageBox.Show("Desea eliminar el registro", "Eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == System.Windows.Forms.DialogResult.Yes)
                {
                    int n = blCategoria.Eliminar(c.IdCategoria);
                    if (n > 0)
                    {
                        MessageBox.Show("Registro eliminado", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lista = blCategoria.Listar();
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


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
