using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI3.Controllers
{
    public class ModaPController:ApiController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();
        [HttpGet]
        public void TumModaPGetir()
        {
            _ent.ModaPTable.Select(p => new ModaPTip()
            {
                ModaPID = p.ModaPID,
                ProductID = p.ProductID,
                MProductName = p.MProductName,
                SubCategoriesID = p.SubCategoriesID
            }).ToList();
        }

    }
    public class ModaPTip
    {
        public int ModaPID { get; set; }
        public int ProductID { get; set; }
        public string MProductName { get; set; }
        public int SubCategoriesID { get; set; }
    }
}