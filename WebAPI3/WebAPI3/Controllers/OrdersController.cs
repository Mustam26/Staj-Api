using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI3.Controllers
{
    public class OrdersController:ApiController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();
        [HttpGet]
        public  void TumOrdersGetir()
        {
            _ent.OrdersTable.Select(p => new OrdersTip()
            {
                OrdersID = p.OrdersID,
                CustomerID = p.CustomerID,
                ProductID = p.ProductID,
                CartID = p.CartID
            }).ToList();
        }
    }

    public class OrdersTip
    {
        public int OrdersID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int CartID { get; set; }
    }
}