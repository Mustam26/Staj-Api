using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI3.Controllers
{
    public class SubCategoriesController:ApiController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();

        [HttpGet]
        public List<SubCategoriesTip> TumSubCategoriesGetir()
        {
            return _ent.SubCategoriesTable.Select(p => new SubCategoriesTip()
            {
                SubCategoriesID = p.SubCategoriesID,
                SubCategoriesName = p.SubCategoriesName,
                CategoryID = p.CategoryID
            }).ToList();
        }

        [HttpGet]
        public List<SubCategoriesTip> SubCategriesBul(int id)
        {
            return _ent.SubCategoriesTable.Where(p=>p.CategoryID==id).Select(p => new SubCategoriesTip()
            {
                SubCategoriesID=p.SubCategoriesID,
                SubCategoriesName=p.SubCategoriesName,
                CategoryID=p.CategoryID
            }).ToList();
        }

    }

    public class SubCategoriesTip
    {
        public int SubCategoriesID { get; set; }
        public string SubCategoriesName { get; set; }
        public short CategoryID { get; set; }
    }
}