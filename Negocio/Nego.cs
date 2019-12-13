using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Datos;
namespace Negocio
{
    public class Nego
    {
        Dat d = new Dat();
        Ent En = new Ent();

        public void AgregaProucto(TextBox[] losid, TextBox[] nombres, TextBox[] precios) //, Byte[][] arBy)
        {
            int?[] id = new int?[5];
            string[] nom = new string[5];
            Decimal?[] dec = new Decimal?[3];
            for(int i = 0; i < 5; i++)
            {
                id[i] = int.Parse(losid[i].Text);
                nom[i] = nombres[i].Text;
            }
            for (int i = 0; i < 3; i++)
            {
                dec[i] = Decimal.Parse(precios[i].Text);
            }
            d.Ag(id,nom,dec);
            //Products produc = d.Busca(nombres[1].Text);
            //int num = 4;
            //foreach (var item in arBy)
            //{
            //    d.AgregaImagenes(produc,item,num);
            //    num = num + 1;
            //}
        }

        public void ActualizaProducto(int id, int idcol, int idcat, string nom, string des, byte[][] arBy)
        {         
            d.ActualizaProd(id, idcol, idcat, nom, des);
            Products produc = d.BuscaId(id);
            foreach (var item in arBy)
            {
                d.AgregaImagenes(produc, item); //
            }
        }

        public void EncuentraProdPorNombre(TextBox te, DataGridView ts)
        {   
            ProdEnt p = En.Casteador(d.Busca(te.Text));
            Muestra(ts, p);
        }

        public void EncuentraProdPorId(TextBox te, DataGridView ts)
        {
            ProdEnt p = En.Casteador(d.BuscaId(int.Parse(te.Text)));
            Muestra(ts,p);
        }

        public void EliminaProd(string id)
        {
            d.Eliminar(id);
        }

        public void Muestra(DataGridView eltex, ProdEnt p)
        {
            string[] ar = new string[16];
            ar[0] = p.Id + "";
            ar[1] = p.IdType + "";
            ar[2] = p.IdColor + "";
            ar[3] = p.IdBrand + "";
            ar[4] = p.IdProvider + "";
            ar[5] = "" + p.IdCatalog;
            ar[6] = "" + p.Title;
            ar[7] = "" + p.Nombre;
            ar[8] = "" + p.Description;
            ar[9] = "" + p.Observations;
            ar[10] = "" + p.PriceDistributor;
            ar[11] = "" + p.PriceClient;
            ar[12] = "" + p.PriceMember;
            ar[13] = "" + p.IsEnabled;
            ar[14] = "" + p.Keywords;
            ar[15] = "" + p.DataUpdate;
            var c = eltex.Rows[0].Cells;
            for(int i = 0; i < ar.Length; i++)
            {
                c[i].Value = ar[i];
            }
        }
    }
}
