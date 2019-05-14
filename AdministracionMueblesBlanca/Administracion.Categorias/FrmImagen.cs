using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Administracion.Entidades;
using Administracion.Negocio;


namespace Administracion.Categorias
{
    public partial class FrmImagen : Form
    {
        List<Imagen> lista = null;
        public int idProductoImagen;

        BLImagen blImagen = new BLImagen();

        public FrmImagen(int idProducto)
        {
            idProductoImagen = idProducto;
            InitializeComponent();
            btnSalir.Enabled = true;
            //ActivarControlDatos(gbDatos, false);
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

        //Creamos el método CargarDatos
        private void CargarDatos()
        {
            string _fechaModificacion;
            Imagen imagen = new Imagen();
            if (lista == null)
            {
                lista = blImagen.Listar(idProductoImagen);
            }

            if (lista.Count > 0)
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < lista.Count; i++)
                {

                    if (lista[i].FechaModificacionImagen.Year <= 2000)
                    {
                        _fechaModificacion = "";
                    }
                    else
                    {
                        _fechaModificacion = lista[i].FechaModificacionImagen.ToString();
                    }
                    dataGridView1.Rows.Add(
                    lista[i].IdImagen,
                    lista[i].TituloImagen,
                    lista[i].CodigoImagen,
                    (EnumEstados.Estados)lista[i].EstadoImagen,
                    lista[i].FechaCreacionImagen,
                    lista[i].UsuarioCreacionImagen,
                    _fechaModificacion,
                    lista[i].UsuarioModificacionImagen);

                }
            }

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.Show();
            this.Hide();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            byte[] cod = (byte[])dataGridView1[2, dataGridView1.CurrentRow.Index].Value;
            pbImagen.Image =  Bytes_A_Imagen(cod);
            pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        //FUNCION PARA CONVERTIR DE BYTES A IMAGEN

        public Image Bytes_A_Imagen(Byte[] ImgBytes)

        {

            Bitmap imagen = null;

            Byte[] bytes = (Byte[])(ImgBytes);

            MemoryStream ms = new MemoryStream(bytes);

            imagen = new Bitmap(ms);

            return imagen;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                DialogResult rpta =
                    MessageBox.Show("Desea eliminar el registro", "Eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rpta == System.Windows.Forms.DialogResult.Yes)
                {
                    int n = blImagen.Eliminar((int)dataGridView1[0, dataGridView1.CurrentRow.Index].Value,idProductoImagen);
                    if (n > 0)
                    {
                        MessageBox.Show("Registro eliminado", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lista = blImagen.Listar(idProductoImagen);
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

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            FrmCargarImagen frmCargarImagen = new FrmCargarImagen(idProductoImagen);
            frmCargarImagen.Show();
            this.Hide();
        }

    }
}
