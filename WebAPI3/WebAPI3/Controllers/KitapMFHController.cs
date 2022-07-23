using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI3.Controllers
{
    public class KitapMFHController:ApiController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();
        [HttpGet]
        public void TumKitapMFHGetir()
        {
            _ent.KitapMFHTable.Select(p => new KitapMFHTip() {
            KitapPID=p.KitapPID,
            ProductID=p.ProductID,
            KiProductName=p.KiProductName,
            SubCategoriesID=p.SubCategoriesID
            }).ToList();
        }
    }

    public class KitapMFHTip
    {
        public int KitapPID { get; set; }
        public int ProductID { get; set; }
        public string KiProductName { get; set; }
        public int SubCategoriesID { get; set; }
    }
}