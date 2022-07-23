using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI3.Controllers
{
    public class ElectronicController:ApiController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();

        [HttpGet]
        public void TumElectronicPGetir()
        {
            _ent.ElectronicPTable.Select(p => new ElectronicTip()
            {
                ElectronicPID = p.ElectronicPID,
                ProductID = p.ProductID,
                EProductName = p.EProductName,
                SubCategoriesID = p.SubCategoriesID

            }).ToList();
        }
    }

    public class ElectronicTip
    {
        public int ElectronicPID { get; set; }
        public int ProductID { get; set; }
        public string EProductName { get; set; }
        public int SubCategoriesID { get; set; }
    }
}