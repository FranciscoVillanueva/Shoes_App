using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            //label1.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
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
    }
}
