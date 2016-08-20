using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Eshopy.Models;

namespace Eshopy.Controllers
{

    public class StoreController : Controller
    {

        EshopyContext storeDB = new EshopyContext();

        //
        // GET: /Store/
        public ActionResult Index()
        {
            List<Products> products = storeDB.Products.ToList();

            return View(products);
        }
        //
        // GET: /Store/Browse?genre=Disco

        public ActionResult Browse(string product = "Iphone")
        {
            // Retrieve Genre and its Associated Albums from database
            Products productModel = storeDB.Products.Include("Products").Single(g => g.Title == product);

            return View(productModel);
        }
        //
        // GET: /Store/Details/5

        public ActionResult Details(int id = 1)
        {
            Products product = storeDB.Products.Find(id);

            return View(product);
        }

        //
        // GET: /Store/GenreMenu
        [ChildActionOnly]
        public ActionResult ProductMenu()
        {
            var product = storeDB.Products.ToList();
            return PartialView(product);
        }
    }
}