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
    public partial class FrmCargarImagen : Form
    {
        //Declaramos las variables generales

        BLImagen bLImagen = new BLImagen();
        Imagen imagen;
        int idProductoImagen;

        public FrmCargarImagen(int pIdproductoImagen)
        {
            idProductoImagen = pIdproductoImagen;
            InitializeComponent();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            BuscarImagen.FileName = "";
            BuscarImagen.InitialDirectory = "C:\\";
            BuscarImagen.FileName = txtRuta.Text;

            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = BuscarImagen.FileName;
                pbImagen.ImageLocation = BuscarImagen.FileName;
                pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnGuardarImagen_Click(object sender, EventArgs e)
        {
            if (!txtRuta.Text.Trim().Equals(""))
            {
                if (!txtTituloImagen.Text.Trim().Equals(""))
                {


                    int n = -1;

                    imagen = new Imagen(idProductoImagen,
                        txtTituloImagen.Text.Trim(),
                        Imagen_A_Bytes(txtRuta.Text),
                        DateTime.Now,
                        sesion.UsuarioSesion,
                        cmbEstadoImagen.SelectedIndex
                        );

                    n = bLImagen.Insertar(imagen);

                    if (n > 0)
                    {
                        MessageBox.Show("Datos grabados correctamente", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al grabar", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Se debe registrar un titulo ", "Aviso",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Se debe escoger la ruta del archivo", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Byte[] Imagen_A_Bytes(String ruta)
        {

            FileStream foto = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            Byte[] arreglo = new Byte[foto.Length];

            BinaryReader reader = new BinaryReader(foto);

            arreglo = reader.ReadBytes(Convert.ToInt32(foto.Length));

            return arreglo;

        }

        private void FrmCargarImagen_Load(object sender, EventArgs e)
        {
            //Carga Combobox Estado 
            cmbEstadoImagen.Items.Clear();
            cmbEstadoImagen.DataSource = Enum.GetValues(typeof(EnumEstados.Estados));
            cmbEstadoImagen.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FrmImagen frmImagen = new FrmImagen(idProductoImagen);
            frmImagen.Show();
            this.Hide();

        }
    }
}
