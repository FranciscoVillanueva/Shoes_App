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
using Negocio;
namespace ShoesApp
{
    public partial class AgregaImagen : Form
    {
        Nego Ne = new Nego();
        int elid;
        public AgregaImagen(int id)
        {
            InitializeComponent();
            elid = id;
            Mensaje.Text = "";
        }

        private void AgImagen_Click(object sender, EventArgs e)
        {
            if (Descripcion.Text == "" || Picture.Image == null)
            {
                Mensaje.Text = "No se agrego, escriba una descipcion y se seleccione una imagen";
            }
            else
            {
                try
                {
                    MemoryStream laimag = new MemoryStream();
                    Picture.Image.Save(laimag, System.Drawing.Imaging.ImageFormat.Jpeg);
                    Ne.AgregaImagenProducto(elid, Descripcion.Text, laimag.ToArray());
                    Mensaje.Text = "Imagen agregada";
                    Descripcion.Clear();
                    Picture.Image = null;
                }
                catch
                {
                    Mensaje.Text = "No eres tu, soy yo";
                }
            }
            
        }

        private void SelecImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                Picture.Image = new Bitmap(open.OpenFile());
            }
            Mensaje.Text = "";
        }

        private void Descripcion_Click(object sender, EventArgs e)
        {
            Mensaje.Text = "";
        }
    }
}
