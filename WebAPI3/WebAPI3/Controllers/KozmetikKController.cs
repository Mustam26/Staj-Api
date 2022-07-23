using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI3.Controllers
{
    public class KozmetikKController:ApiController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();
        [HttpGet]
        public void TumKozmetikKGetir()
        {
            _ent.KozmetikKTable.Select(p => new KozmetikKTip()
            {
                KozmetikPID = p.KozmetikPID,
                ProductID = p.ProductID,
                KoProductName = p.KoProductName,
                SubCategoriesID = p.SubCategoriesID
            }).ToList();
        }

    }

    public class KozmetikKTip
    {
        public int KozmetikPID { get; set; }
        public int ProductID { get; set; }
        public string KoProductName { get; set; }
        public int SubCategoriesID { get; set; }
    }
}