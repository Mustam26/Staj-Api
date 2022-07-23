using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI3.Controllers
{
    public class SepetController:ApiController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();

        public List<SepetTip> TumSepetiGetir()
        {
          return  _ent.CartTable.Select(p => new SepetTip()
            {
                CartID = p.CartID,
                FirebaseID = p.FirebaseID,
                CustomerID = p.CustomerID,
                PaymentID = p.PaymentID,
                ProductsIDS = p.ProductsIDS
            }).ToList();
        }

    }

    public class SepetTip
    {
        public int CartID { get; set; }
        public long FirebaseID { get; set; }
        public int CustomerID { get; set; }
        public int PaymentID { get; set; }
        public string ProductsIDS { get; set; }
    }
}