﻿using System;
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
using Datos;
namespace ShoesApp
{
    public partial class Principal : Form
    {
        Nego Ne = new Nego();
        Dat d = new Dat();
        public byte[][] imagenes;
        
        public Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ne.CargaSugerenciaEnTextBox(NombreBuscar, d.NombresProductos());
            MensajeEdic.Text = "";
            MensajeEl.Text = "";
            Mensajes.Text = "";
            ImNum.Text = "";
            TotIm.Text = "";
        }

        private void buscaPorNombre_Click(object sender, EventArgs e)
        {
            IdBuscar.Clear();
            try
            {
                Ne.EncuentraProdPorNombre(NombreBuscar, MuestradataGrid);
                imagenes = d.ImagenesPorIdDeProducto(
                    int.Parse(MuestradataGrid.Rows[0].Cells[0].Value.ToString()));
                ManejadorDeMensaje(Mensajes, "Producto encontrado", true);
            }
            catch
            {
                ManejadorDeMensaje(Mensajes, "No existe ningún producto con ese nombre",false);
            }
        }

        private void BuscaPorIdBoton_Click(object sender, EventArgs e)
        {
            NombreBuscar.Clear();
            try
            {
                Ne.EncuentraProdPorId(IdBuscar, MuestradataGrid);
                imagenes = d.ImagenesPorIdDeProducto(
                    int.Parse(MuestradataGrid.Rows[0].Cells[0].Value.ToString()));
                ManejadorDeMensaje(Mensajes, "Producto encontrado", true);
            }
            catch
            {
                ManejadorDeMensaje(Mensajes, "No existe ningún producto con ese id", false);
            }
        }

        private void EliminaProd_Click(object sender, EventArgs e)
        {
            Ne.CargaSugerenciaEnTextBox(NombreBuscar, d.NombresProductos());
            try
            {
                Ne.EliminaProd(MuestradataGrid.Rows[0].Cells[0].Value.ToString());
                MensajeEl.Text = "se elimino";
                NuevaImagen.Enabled = false;
                Editar.Enabled = false;
                Mensajes.Text = "";
                Borrale();
            }
            catch
            {
                MensajeEl.Text = "No se elimino";
            }
        }

        private void NuevoProducto_Click(object sender, EventArgs e)
        {
            NuevoProducto f = new NuevoProducto();
            f.Show();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            Ne.CargaSugerenciaEnTextBox(NombreBuscar, d.NombresProductos());
            try
            {
                Ne.ActualizaProducto(
                    int.Parse(MuestradataGrid.Rows[0].Cells[0].Value.ToString()),
                    int.Parse(MuestradataGrid.Rows[0].Cells[2].Value.ToString()),
                    int.Parse(MuestradataGrid.Rows[0].Cells[5].Value.ToString()),
                    MuestradataGrid.Rows[0].Cells[7].Value.ToString(),
                    MuestradataGrid.Rows[0].Cells[8].Value.ToString());
                MensajeEdic.Text = "Se edito el producto";
            }
            catch
            {
                MensajeEdic.Text = "No se edito";
            }

        }

        public void ManejadorDeMensaje(Label eltex, string mensaje, Boolean habilita)
        {
            MensajeEl.Text = "";
            MensajeEdic.Text = "";
            eltex.Text = mensaje;
            Editar.Enabled = habilita;
            EliminaProd.Enabled = habilita;
            NuevaImagen.Enabled = habilita;
            ControlParaHabilitarBotonesImagen(habilita);
        }

        public void ControlParaHabilitarBotonesImagen(Boolean habilita)
        {
            if (habilita && imagenes.Length > 1)
            {
                Anterior.Enabled = true;
                Siguiente.Enabled = true;
                ImNum.Text = "1";
                TotIm.Text = imagenes.Length + "";
                MueveImagen(0);
            }
            else if (habilita && imagenes.Length == 1)
            {
                MueveImagen(0);
                ImNum.Text = "1";
                TotIm.Text = "1";
                Anterior.Enabled = false;
                Siguiente.Enabled = false;
            }
            else
            {
                Anterior.Enabled = false;
                Siguiente.Enabled = false;
                Foto.Image = null;
                ImNum.Text = "0";
                TotIm.Text = "0";
            }
        }

        public void MueveImagen(int pos)
        {
            if (imagenes != null)
            {
                MemoryStream im = new MemoryStream(imagenes[pos]);
                Foto.Image = new Bitmap(im);
            }
        }

        private void NuevaImagen_Click(object sender, EventArgs e)
        {
            AgregaImagen agi = new AgregaImagen(int.Parse(MuestradataGrid.Rows[0].Cells[0].Value.ToString()));
            agi.Show();
        }

        private void Anterior_Click(object sender, EventArgs e)
        {
            int num = int.Parse(ImNum.Text) - 2;
            if (num >= 0)
            {
                MueveImagen(num);
                num = num + 2 - 1;
                ImNum.Text = num + "";
            }
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            int num = int.Parse(ImNum.Text) + 1;
            if (num <= int.Parse(TotIm.Text))
            {
                MueveImagen(num - 1);
                ImNum.Text = num + "";
            }
        }

        private void Principal_Activated(object sender, EventArgs e)
        {
            try
            {
                imagenes = d.ImagenesPorIdDeProducto(
                   int.Parse(MuestradataGrid.Rows[0].Cells[0].Value.ToString()));
                ControlParaHabilitarBotonesImagen(true);
            }
            catch
            {

            }
        }

        public void Borrale()
        {
            var c = MuestradataGrid.Rows[0].Cells;
            for (int i = 0; i < c.Count; i++)
            {
                c[i].Value = "";
            }
        }
    }
}
