using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI3.Controllers
{
    public class AnneboController:ApiController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();
        [HttpGet]
        public List<AnneBOTip> TumAnneBOGetir()
        {
          return  _ent.AnneBOTable.Select(p => new AnneBOTip()
            {
                AnnePID = p.AnnePID,
                ProductID = p.ProductID,
                AProductName = p.AProductName,
                SubCategoriesID = p.SubCategoriesID
            }).ToList();
        }
    }

    public class AnneBOTip
    {
        public int AnnePID { get; set; }
        public int ProductID { get; set; }
        public string AProductName { get; set; }
        public int SubCategoriesID { get; set; }
    }

}
