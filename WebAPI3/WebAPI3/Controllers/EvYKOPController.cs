using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI3.Controllers
{
    public class EvYKOPController:ApiController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();
        [HttpGet]
        public void TumEvYKOPGetir()
        {
            _ent.EvYKOPTable.Select(p => new EvYKOPTip()
            {
                EvPID = p.EvPID,
                ProductID = p.ProductID,
                EProductName = p.EProductName,
                SubCategoriesID = p.SubCategoriesID
            }).ToList();
        }
    }

    public class EvYKOPTip
    {
        public int EvPID { get; set; }
        public int ProductID { get; set; }
        public string EProductName { get; set; }
        public int SubCategoriesID { get; set; }
    }
}