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
            return ob.FAVV_NombresDeProductos().ToArray();
        }

        public Byte[][] ImagenesPorIdDeProducto(int id)
        {
            return ob.FAVV_ImagenesDeProducto(id).ToArray();
        }

        public string[] NombresProvedores() // idprovider
        {            
            return ob.FAVV_NombresProvedores().ToArray();   
        }

        public int? EncuentraIdProviderPorNombre(string s) //
        {
            return ob.FAVV_EncuentraIdProviderPorNombre(s).ToArray()[0];
        }

        public string[] NombresColores() // idcolor
        {
            return ob.FAVV_NombresColores().ToArray();
        }

        public int? EncuentraIdColorPorNombre(string s) //
        {
            return ob.FAVV_EncuentraIdColorPorName(s).ToArray()[0];
        }

        public string[] NombresMarcas() // idBrand
        {
            return ob.FAVV_NombresMarcas().ToArray();
        }

        public int? EncuentraIdBrandPorMarca(string s) //
        {
            return ob.FAVV_EncuentraIdBrandPorMarca(s).ToArray()[0];
        }

        public string[] Categorias() // idType
        {
            return ob.FAVV_DescripcionesDeCategotias().ToArray();
        }

        public int? EncuentraIdCatalogPorDescripcion(string s) //
        {
            return ob.FAVV_EncuentraIdCatalogPorDescripcion(s).ToArray()[0];
        }

        public string[] CatCatalogo() // id catalog
        {
            return ob.FAVV_CatCatalogsSeason().ToArray();
        }

        public int? EncuentraIdCatalogPorSeason(string s) //
        {
            return ob.FAVV_EncuentraIdCatalogPorSeason(s).ToArray()[0];
        }
        
        public void ActualizaProd(int id, int idcol, int idcat, string nom, string des)
        {
            ob.JRCV1_UpdateProduct(id, idcol, idcat, nom, des);
        }
        
        public void AgregaProducto(int?[] id, string [] n, Decimal?[] d)
        {
            ob.JEVJ1_InsertaNuevoProducto(id[0], id[1], id[2], id[3], id[4], n[0]
                , n[1], n[2], n[3],
                d[0], d[1], d[2], true, n[4], DateTime.Now);
        }

        public void AgregaImagenes(int idproducto, string desc ,Byte[] im)
        {
            ob.FAVV_AgregaImagen(idproducto, desc, im, DateTime.Now, true);
        }

        public Products BuscaId(int ent)
        {
            ob.Configuration.ProxyCreationEnabled = false;
            return ob.BuscaProductoPorID(ent).FirstOrDefault();
        }

        public Products BuscaNombre(string s)
        {
            ob.Configuration.ProxyCreationEnabled = false;
            return ob.BuscaProductoPorNombre(s).FirstOrDefault();
        }

        public void Eliminar(string id)
        {
            ob.JEVJ1_EliminaProductoPorID(int.Parse(id));
            ob.SaveChanges();
        }
    }
}
