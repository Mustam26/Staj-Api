using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI3.Controllers
{
    public class OdemeController:ApiController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();

        [HttpGet]
        public List<OdemeTip> TumOdemeleriGetir()
        {
          return  _ent.PaymentTable.Select(p => new OdemeTip()
            {
                PaymentID=p.PaymentID,
                PaymentType=p.PaymentType,
                Allowed=p.Allowed
            }).ToList();
        }
    }

    public class OdemeTip
    {
        public int PaymentID { get; set; }
        public string PaymentType { get; set; }
        public bool Allowed { get; set; }
    }
}