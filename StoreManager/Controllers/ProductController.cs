using StoreManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using StoreManager.ViewModels;

namespace StoreManager.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext Db;
        public ProductController()
        {
            Db = new ApplicationDbContext();
        }
        // GET: Store
        [Authorize]
        public ActionResult Index()
        {
            var products = Db.Products.ToList();
            return View(products);
        }
        //GET
        public ActionResult Create()
        {
            return View();
        }
        //POST
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if(product.ProductId == 0)
            {
                Db.Products.Add(product);
            }
            else
            {
                var productInDb = Db.Products.Single(model => model.ProductId == product.ProductId);

                productInDb.ProductName = product.ProductName;
                productInDb.Quantity = product.Quantity;
                productInDb.ExpirationDate = product.ExpirationDate;
                productInDb.DateAdded = product.DateAdded;
                productInDb.Price = product.Price;
            }
            
            Db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var product = Db.Products.SingleOrDefault(model => model.ProductId == id);
            return View(product);
        }
        public ActionResult Details(int id)
        {
            var product = Db.Products.SingleOrDefault(model => model.ProductId == id);
            return View(product);
        }
        public ActionResult Delete(int id)
        {
            var product = Db.Products.SingleOrDefault(model => model.ProductId == id);
            Db.Products.Remove(product);
            Db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Buy(int id)
        {
            var product = Db.Products.SingleOrDefault(model => model.ProductId == id);
            var viewModel = new ProductSaleViewModel
            {
                Product = product
            };
            return View(viewModel);
        }
    }
}