using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI3.Controllers
{
    public class KategoriController:ApiController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();

        [HttpGet]
        public List<KategoriTip> TumKategorileriGetir()
        {
            return _ent.Category_Table.Select(p => new KategoriTip()
            {
                CategoryID = p.CategoryID,
                CategoryName = p.CategoryName
            }).ToList();
        }
    }

    public class KategoriTip
    {
        public short CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}


    


  