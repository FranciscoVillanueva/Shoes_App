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
        public string[] NombresProductos() 
        { 
            return new DataProductsEntities1().FAVV_NombresDeProductos().ToArray();  
        }

        public byte[][] ImagenesPorIdDeProducto(int id)
        {
            return new DataProductsEntities1().FAVV_ImagenesDeProducto(id).ToArray();
        }

        public string[] NombresProvedores() // idprovider
        {            
            return new DataProductsEntities1().FAVV_NombresProvedores().ToArray();   
        }

        public int? EncuentraIdProviderPorNombre(string s) //
        {
            return new DataProductsEntities1().FAVV_EncuentraIdProviderPorNombre(s).ToArray()[0];
        }

        public string[] NombresColores() // idcolor
        {
            return new DataProductsEntities1().FAVV_NombresColores().ToArray();
        }

        public int? EncuentraIdColorPorNombre(string s) //
        {
            return new DataProductsEntities1().FAVV_EncuentraIdColorPorName(s).ToArray()[0];
        }

        public string[] NombresMarcas() // idBrand
        {
            return new DataProductsEntities1().FAVV_NombresMarcas().ToArray();
        }

        public int? EncuentraIdBrandPorMarca(string s) //
        {
            return new DataProductsEntities1().FAVV_EncuentraIdBrandPorMarca(s).ToArray()[0];
        }

        public string[] Categorias() // idType
        {
            return new DataProductsEntities1().FAVV_DescripcionesDeCategotias().ToArray();
        }

        public int? EncuentraIdCatalogPorDescripcion(string s) //
        {
            return new DataProductsEntities1().FAVV_EncuentraIdCatalogPorDescripcion(s).ToArray()[0];
        }

        public string[] CatCatalogo() // id catalog
        {
            return new DataProductsEntities1().FAVV_CatCatalogsSeason().ToArray();
        }

        public int? EncuentraIdCatalogPorSeason(string s) //
        {
            return new DataProductsEntities1().FAVV_EncuentraIdCatalogPorSeason(s).ToArray()[0];
        }
        
        public void ActualizaProd(int id, int idcol, int idcat, string nom, string des)
        {
            new DataProductsEntities1().JRCV1_UpdateProduct(id, idcol, idcat, nom, des);
        }
        
        public void AgregaProducto(int?[] id, string [] n, Decimal?[] d)
        {
            new DataProductsEntities1().JEVJ1_InsertaNuevoProducto(id[0], id[1], id[2], id[3], id[4], n[0]
                , n[1], n[2], n[3],
                d[0], d[1], d[2], true, n[4], DateTime.Now);
        }

        public void AgregaImagenes(int idproducto, string desc ,Byte[] im)
        {
            new DataProductsEntities1().FAVV_AgregaImagen(idproducto, desc, im, DateTime.Now, true);
        }

        public Products BuscaId(int ent)
        {
            DataProductsEntities1 p = new DataProductsEntities1();
            p.Configuration.ProxyCreationEnabled = false;
            return p.BuscaProductoPorID(ent).FirstOrDefault();
        }

        public Products BuscaNombre(string s)
        {
            DataProductsEntities1 p = new DataProductsEntities1();
            p.Configuration.ProxyCreationEnabled = false;
            return p.BuscaProductoPorNombre(s).FirstOrDefault();
        }

        public void Eliminar(string id)
        {
            new DataProductsEntities1().JEVJ1_EliminaProductoPorID(int.Parse(id));
        }
    }
}
