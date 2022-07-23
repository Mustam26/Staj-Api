using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI3.Controllers
{
    public class ProductInfoTController:ApiController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();

        [HttpGet]
        public void TumProductInfoGetir()
        {
            _ent.ProductInfo.Select(p => new ProductInfoTip()
            {
                ProductInfoID = p.ProductInfoID,
                ProductID = p.ProductID,
                Info = p.Info
            }).ToList();
        }

    }

    public class ProductInfoTip
    {
        public int ProductInfoID { get; set; }
        public int ProductID { get; set; }
        public string Info { get; set; }

    }
}