using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI3.Controllers
{
    public class SporOController:ApiController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();
        [HttpGet]

        public void TumSporOGetir()
        {
            _ent.SporOTable.Select(p => new SporOTip()
            {
                SporPID = p.SporPID,
                ProductID = p.ProductID,
                SProductName = p.SProductName,
                SubCategoriesID = p.SubCategoriesID
            }).ToList();

        }

    }

    public class SporOTip
    {
        public int SporPID { get; set; }
        public int ProductID { get; set; }
        public string SProductName { get; set; }
        public int SubCategoriesID { get; set; }

    }
}