using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI3.Controllers
{
    public class SupermarketPKController:ApiController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();
        [HttpGet]
        public void TumSupermarketPKGetir()
        {
            _ent.SupermarketPKTable.Select(p => new SupermarketPKTip()
            {
                superPID = p.superPID,
                ProductID = p.ProductID,
                SProductName = p.SProductName,
                SubCategoriesID = p.SubCategoriesID
            }).ToList();
        }
    }

    public class SupermarketPKTip
    {
        public int superPID { get; set; }
        public int ProductID { get; set; }
        public string SProductName { get; set; }
        public int SubCategoriesID { get; set; }
    }
}