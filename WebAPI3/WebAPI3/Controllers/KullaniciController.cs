using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebAPI3.Controllers
{
    public class KullaniciController:ApiController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();
        [HttpGet]
        public List<KullaniciTip> TumKullanicilariGetir()
        {
            return _ent.CustomerTable.Select(p => new KullaniciTip()
            {
                CustomerID=p.CustomerID,
                CustomerName=p.CustomerName,
                CustomerSurname=p.CustomerSurname,
                City=p.City,
                Age=p.Age,
                Email=p.Email,
                Password=p.Password,
                Phone=p.Phone,
                Gender=p.Gender,
                Adress=p.Adress

            }).ToList();
        }

        [HttpPost]
        public bool KullaniciEkle(KullaniciTip veri)
        {
            try
            {
                CustomerTable u = new CustomerTable()
                {   CustomerName = veri.CustomerName,
                    CustomerSurname = veri.CustomerSurname,
                    Password=veri.Password,
                    Email = veri.Email,
                    Phone = veri.Phone,
                    City = veri.City,
                    Age = veri.Age,
                    Gender = veri.Gender,
                    Adress = veri.Adress
                };
                _ent.CustomerTable.Add(u);
                _ent.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }

    public class KullaniciTip
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Adress { get; set; }

    }
}

/*
  public class CustomerController
    {
        EcommerDBEntities _ent = new EcommerDBEntities();

        [HttpGet]
        public List<CustomerTip> TumCustomerlariGetir()
        {
            return _ent.CustomerTable.Select(p => new CustomerTip()
            {
                CustomerID=p.CustomerID,
                CustomerName=p.CustomerName,
                CustomerSurname=p.CustomerSurname,
                City=p.City,
                Age=p.Age,
                Email=p.Email,
                Password=p.Password,
                Phone=p.Phone,
                Gender=p.Gender,
                Adress=p.Adress
            }).ToList();

        }

    }

    public class CustomerTip
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Adress { get; set; }
    }
 */