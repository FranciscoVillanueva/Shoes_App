using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Dat
    {
        DataProductsEntities1 ob = new DataProductsEntities1();
        //public string met()
        //{
        //    Product[] s = ob.FAVV_BuscaNombrePorId1(2).ToArray<Product>();
        //    return s[0].Nombre;
        //}
        //public static void elme()
        //{
        //    ob.Configuration.ProxyCreationEnabled = false;
        //}
    
        public void ActualizaProd(int id, int idcol, int idcat, string nom, string des)
        {
            ob.JRCV1_UpdateProduct(id, idcol, idcat, nom, des);
        }
        
        public void Ag(int?[] id, string [] n, Decimal?[] d)
        {
            ob.JEVJ1_InsertaNuevoProducto(id[0], id[1], id[2], id[3], id[4], n[0]
                , n[1], n[2], n[3],
                d[0], d[1], d[2], true, n[4], DateTime.Now);
        }

        public void AgregaImagenes(Products elpro, Byte[] im)
        {
            ob.FAVV_AgregaImagen(elpro.Id, elpro.Nombre, im, DateTime.Now, true);
        }

        public Products BuscaId(int ent)
        {
            ob.Configuration.ProxyCreationEnabled = false;
            return ob.BuscaProductoPorID(ent).FirstOrDefault<Products>();
        }

        public Products Busca(string s)
        {
            ob.Configuration.ProxyCreationEnabled = false;
            return ob.BuscaProductoPorNombre(s).FirstOrDefault<Products>();
        }

        public void Eliminar(string id)
        {
            ob.JEVJ1_EliminaProductoPorID(int.Parse(id));
            ob.SaveChanges();
        }
    }
}
