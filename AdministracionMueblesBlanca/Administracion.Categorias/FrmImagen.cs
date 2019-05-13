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
        Imagen image;

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
                    dataGridView1.Rows.Add(
                    lista[i].IdImagen,
                    lista[i].TituloImagen,
                    lista[i].CodigoImagen,
                    (EnumEstados.Estados)lista[i].EstadoImagen,
                    lista[i].FechaCreacionImagen,
                    lista[i].UsuarioCreacionImagen,
                    lista[i].FechaModificacionImagen,
                    lista[i].UsuarioModificacionImagen);

                }
            }

        }

        private void FrmImagen_Load(object sender, EventArgs e)
        {          

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmBienvenida frmInicio = new FrmBienvenida();
            frmInicio.Show();
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

    }
}
