using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI3.Controllers
{
    public class YorumlarController:ApiController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();
        [HttpGet]
        public List<YorumTip> TumYorumlariGetir()
        {
         return   _ent.CommentTable.Select(p => new YorumTip()
            {
                CommentID = p.CommentID,
                Comment = p.Comment,
                CustomerID = p.CustomerID,
                CommentDate = p.CommentDate,
                ProductID = p.ProductID,
                Point = p.Point
            }).ToList();
        }
    }

    public class YorumTip
    {
        public int CommentID { get; set; }
        public string Comment { get; set; }
        public int CustomerID { get; set; }
        public System.DateTime CommentDate { get; set; }
        public int ProductID { get; set; }
        public int Point { get; set; }
    }
}