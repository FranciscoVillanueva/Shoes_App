using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Datos;
namespace Entidades
{
    public class Ent
    {
        public string Serial<T>(T b) 
        {
            var json = new JavaScriptSerializer().Serialize(b);
            return json;
        }

        public T Deserial<T>(string s) 
        {
            var root = JsonConvert.DeserializeObject<T>(s);
            return root;
        }

        public ProdEnt Casteador<Entrada>(Entrada ob)
        {
            string s = Serial<Entrada>(ob);
            ProdEnt ret = Deserial<ProdEnt>(s);
            return ret;
        }
    }

    public class ProdEnt
    {
        public int Id { get; set; }
        public int? IdType {get; set;}
        public int? IdColor { get; set; }
        public int? IdBrand { get; set; }
        public int? IdProvider { get; set; }
        public int? IdCatalog { get; set; }
        public string Title { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public string Observations { get; set; }
        public Decimal? PriceDistributor { get; set; }
        public Decimal? PriceClient { get; set; }
        public Decimal? PriceMember { get; set; }
        public Boolean IsEnabled { get; set; }
        public string Keywords { get; set; }
        public DateTime? DataUpdate { get; set; }
    }
}
