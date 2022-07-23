using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI3.Controllers
{
    public class ProductController:ApiController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();
        [HttpGet]
        public void TumProductGetir()
        {
            _ent.Product_Table.Select(p => new ProductTip()
            {
                ProductID = p.ProductID,
                ProductName = p.ProductName,
                Stock = p.Stock,
                ProductInfoID = p.ProductInfoID,
                Price = p.Price,
                Mark = p.Mark,
                CategoryID = p.CategoryID,
                CommentID = p.CommentID,
                PhotoUrl = p.PhotoUrl
            }).ToList();
        }

    }

    public class ProductTip
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> Stock { get; set; }
        public int ProductInfoID { get; set; }
        public decimal Price { get; set; }
        public string Mark { get; set; }
        public short CategoryID { get; set; }
        public int CommentID { get; set; }
        public string PhotoUrl { get; set; }
    }
}