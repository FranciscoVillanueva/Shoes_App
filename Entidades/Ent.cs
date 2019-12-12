using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Datos;
namespace Entidades
{
    public class Ent
    {
        public void serial()
        {
            Products b = new Products();
            var json = new JavaScriptSerializer().Serialize(b);
        }

        public ProdEnt Casteador(Products ob)
        {
            serial();
            ProdEnt pr = new ProdEnt();
            pr.Id = ob.Id;
            pr.IdType = ob.IdType;
            pr.IdColor = ob.IdColor;
            pr.IdBrand = ob.IdBrand;
            pr.IdProvider = ob.IdProvider;
            pr.IdCatalog = ob.IdCatalog;
            pr.Title = ob.Title;
            pr.Nombre = ob.Nombre;
            pr.Description = ob.Description;
            pr.Observations = ob.Observations;
            pr.PriceDistributor = ob.PriceDistributor;
            pr.PriceClient = ob.PriceClient;
            pr.PriceMember = ob.PriceMember;
            pr.IsEnabled = ob.IsEnabled;
            pr.Keywords = ob.Keywords;
            pr.DataUpdate = ob.DateUpdate;
            return pr;
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
