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
    public partial class FrmModelos : Form
    {
        List<Modelo> lista = null;
        public int idProductoModelo;
        BLModelo blModelo = new BLModelo();
        Validaciones validacion = new Validaciones();
        Modelo modelo;
        bool _nuevo = false;

        public FrmModelos(int idProducto)
        {
            idProductoModelo = idProducto;
            InitializeComponent();
            btnSalir.Enabled = true;
            //ActivarControlDatos(gbDatos, false);
            CargarDatos();

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

        //Creamos el método CargarDatos
        private void CargarDatos()
        {
            string _fechaModificacion;
            Modelo modelo = new Modelo();
            if (lista == null)
            {
                lista = blModelo.Listar(idProductoModelo);
            }

            if (lista.Count > 0)
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].FechaModificacionModelo.Year <= 2000)
                    {
                        _fechaModificacion = "";
                    }
                    else
                    {
                        _fechaModificacion = lista[i].FechaModificacionModelo.ToString();
                    }
                    dataGridView1.Rows.Add(
                    lista[i].IdModelo,
                    lista[i].TituloModelo,
                    lista[i].RutaModelo,
                    (EnumEstados.Estados)lista[i].EstadoModelo,
                    lista[i].FechaCreacionModelo,
                    lista[i].UsuarioCreacionModelo,
                    _fechaModificacion,
                    lista[i].UsuarioModificacionModelo);

                }
            }

        }

        private void FrmModelos_Load(object sender, EventArgs e)
        {
            //Carga Combobox Estado Categoria
            cmbEstadoModelo.Items.Clear();
            cmbEstadoModelo.DataSource = Enum.GetValues(typeof(EnumEstados.Estados));
            cmbEstadoModelo.SelectedIndex = 0;

            btnGrabar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _nuevo = true;
            ActivarControlDatos(gbDatos, true);
            btnEditar.Text = "Cancelar";
            ActivarButton(false);
            LimpiarControl(gbDatos);
            txtTituloModelo.Focus();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtTituloModelo.Text.Trim() != "")
            {
                if (txtRutaModelo.Text.Trim() != "")
                {
                    int n = -1;
                    if (_nuevo)
                    {
                        modelo = new Modelo(0,
                            idProductoModelo,
                            txtTituloModelo.Text.Trim(),
                            txtRutaModelo.Text.Trim(),
                            DateTime.Now,
                            "Administrador",
                            cmbEstadoModelo.SelectedIndex);
                        n = blModelo.Insertar(modelo);
                    }
                    else
                    {
                        modelo = new Modelo(
                            Convert.ToInt32(txtCodigo.Text),
                            idProductoModelo,
                            txtTituloModelo.Text.Trim(),
                            txtRutaModelo.Text.Trim(),
                            DateTime.Now,
                            "Administrador",
                            cmbEstadoModelo.SelectedIndex);

                        n = blModelo.Actualizar(modelo);
                    }
                    if (n > 0)
                    {
                        MessageBox.Show("Datos grabados correctamente", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActivarControlDatos(gbDatos, false);
                        ActivarButton(true);
                        dataGridView1.Enabled = true;
                        LimpiarControl(gbDatos);
                        btnEditar.Text = "Editar";
                        lista = blModelo.Listar(idProductoModelo);
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Error al grabar", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
                dataGridView1.Enabled = true;
                btnEditar.Text = "Editar";
            }
            else
            {
                if (dataGridView1.RowCount > 0)
                {
                    modelo = blModelo.TraerPorId((int)dataGridView1[0, dataGridView1.
                        CurrentRow.Index].Value,idProductoModelo);
                    txtCodigo.Text = modelo.IdModelo.ToString();
                    txtTituloModelo.Text = modelo.TituloModelo;
                    txtRutaModelo.Text = modelo.RutaModelo;
                    cmbEstadoModelo.SelectedIndex = modelo.EstadoModelo;

                    ActivarControlDatos(gbDatos, true);
                    ActivarButton(false);
                    dataGridView1.Enabled = false;
                    btnEditar.Text = "Cancelar";
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                modelo = blModelo.TraerPorId((int)dataGridView1[0, dataGridView1.
                    CurrentRow.Index].Value, idProductoModelo);
                DialogResult rpta =
                    MessageBox.Show("Desea eliminar el registro", "Eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == System.Windows.Forms.DialogResult.Yes)
                {
                    int n = blModelo.Eliminar(modelo.IdModelo, idProductoModelo);
                    if (n > 0)
                    {
                        MessageBox.Show("Registro eliminado", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lista = blModelo.Listar(idProductoModelo);
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
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.Show();
            this.Hide();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Modelos|*.html";
            BuscarImagen.FileName = "";
            BuscarImagen.InitialDirectory = "C:\\";
            BuscarImagen.FileName = txtRutaModelo.Text;

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                txtRutaModelo.Text = BuscarImagen.FileName;
            }
        }
    }
}