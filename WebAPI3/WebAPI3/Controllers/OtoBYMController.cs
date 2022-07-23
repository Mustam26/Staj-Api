using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI3.Controllers
{
    public class OtoBYMController:ApiController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();
        [HttpGet]
        public void TumOtoBYMGetir()
        {
            _ent.OtoBYMTable.Select(p => new OtoBYMTip()
            {
                OtoPID = p.OtoPID,
                ProductID = p.ProductID,
                OProductName = p.OProductName,
                SubCategoriesID = p.SubCategoriesID
            }).ToList();
        }
    }

    public class OtoBYMTip
    {
        public int OtoPID { get; set; }
        public int ProductID { get; set; }
        public string OProductName { get; set; }
        public int SubCategoriesID { get; set; }
    }
}