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
    public partial class Form2 : Form
    {
        Nego Ne = new Nego();
        public Form2()
        {
            InitializeComponent();
        }

        //public void AgregaPictureBoxAPanel()
        //{
            //PictureBox p = new PictureBox() {
            //    BorderStyle = BorderStyle.FixedSingle,
            //    Height = 600,
            //    Width = 1600,
            //    //Top = Height * flowLayoutPanel1.Controls.Count,
            //    SizeMode = PictureBoxSizeMode.AutoSize
            //};
            //flowLayoutPanel1.Controls.Add(p);
            //OpenFileDialog open = new OpenFileDialog();
            //if (open.ShowDialog() == DialogResult.OK)
            //{
            //    p.Image = new Bitmap(open.OpenFile());
            //}
        //}


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void AgregarProducto_Click(object sender, EventArgs e)
        {
            TextBox[] losid = { textBox1, textBox2, textBox3, textBox4, textBox5 };
            TextBox[] nombres = { textBox6, textBox7, textBox8, textBox9, textBox14 };
            TextBox[] precios = { textBox10, textBox11, textBox12 };
            Ne.AgregaProucto(losid, nombres, precios);
        }

        //private void AgregarProducto_Click(object sender, EventArgs e)
        //{
        //TextBox[] losid = {textBox1,textBox2,textBox3,textBox4,textBox5};
        //TextBox[] nombres = { textBox6, textBox7, textBox8, textBox9, textBox14 };
        //TextBox[] precios = {textBox10,textBox11,textBox12};
        //PictureBox[] arPics = flowLayoutPanel1.Controls.OfType<PictureBox>().ToArray();
        //int totaldePic = flowLayoutPanel1.Controls.OfType<PictureBox>().Count();
        //Byte[][] jaggedArray = new Byte[totaldePic][];
        //for (int i = 0; i < totaldePic; i++)
        //{
        //    MemoryStream laimag = new MemoryStream();
        //    arPics[i].Image.Save(laimag, System.Drawing.Imaging.ImageFormat.Jpeg);
        //    jaggedArray[i] = laimag.ToArray();
        //}
        //Ne.AgregaProucto(losid, nombres, precios);/*,jaggedArray);*/
        //}
        //}
    }
}
