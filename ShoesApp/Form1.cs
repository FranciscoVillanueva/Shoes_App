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
    public partial class Form1 : Form
    {
        Nego Ne = new Nego();
        public Form1()
        {
            InitializeComponent();

            //var t = MuestradataGrid.Rows[0].Cells;
            //t[0].Value = "9";
            //string[] row6 = { "6/30/1992", "3", "Dress" };

            //dataGridView1.Rows.Add(row6);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
     
        }

        private void buscaPorNombre_Click(object sender, EventArgs e)
        {
            Ne.EncuentraProdPorNombre(NombreBuscar, MuestradataGrid);
        }

        private void BuscaPorIdBoton_Click(object sender, EventArgs e)
        {
            Ne.EncuentraProdPorId(IdBuscar, MuestradataGrid);
        }

        private void EliminaProd_Click(object sender, EventArgs e)
        {
            Ne.EliminaProd(MuestradataGrid.Rows[0].Cells[0].Value.ToString());
        }

        private void NuevoProducto_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            PictureBox[] arPics = flowLayoutPanel1.Controls.OfType<PictureBox>().ToArray();
            int totaldePic = flowLayoutPanel1.Controls.OfType<PictureBox>().Count();
            byte[][] jaggedArray = new byte[totaldePic][];
            for (int i = 0; i < totaldePic; i++)
            {
                MemoryStream laimag = new MemoryStream();
                arPics[i].Image.Save(laimag, System.Drawing.Imaging.ImageFormat.Jpeg);
                jaggedArray[i] = laimag.ToArray();
            }
            Ne.ActualizaProducto(
                int.Parse(MuestradataGrid.Rows[0].Cells[0].Value.ToString()),
                int.Parse(MuestradataGrid.Rows[0].Cells[2].Value.ToString()),
                int.Parse(MuestradataGrid.Rows[0].Cells[5].Value.ToString()),
                MuestradataGrid.Rows[0].Cells[7].Value.ToString(),
                MuestradataGrid.Rows[0].Cells[8].Value.ToString(),
                jaggedArray);
        }

        private void AgregaFotoApanel_Click(object sender, EventArgs e)
        {
            PictureBox p = new PictureBox()
            {
                BorderStyle = BorderStyle.FixedSingle,
                Height = 600,
                Width = 1600,
                //Top = Height * flowLayoutPanel1.Controls.Count,
                SizeMode = PictureBoxSizeMode.AutoSize
            };
            flowLayoutPanel1.Controls.Add(p);
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                p.Image = new Bitmap(open.OpenFile());
            }
        }
    }
}
