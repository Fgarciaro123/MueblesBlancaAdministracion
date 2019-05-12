using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion.Categorias
{
    public partial class FrmCargarImagen : Form
    {
        public FrmCargarImagen()
        {
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
    }
}
