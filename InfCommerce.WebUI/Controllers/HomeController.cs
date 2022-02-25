using InfCommerce.DAL.DbContexts;
using InfCommerce.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace InfCommerce.WebUI.Controllers
{
    public class HomeController : Controller
    {
        SqlContext db;
        public HomeController(SqlContext _db)
        {
            db= _db;    
        }
        public IActionResult Index()
        {
            IndexVM indexVM = new IndexVM
            {
                Slider = db.Slider,
                LatestProducts = db.Product.Include(i => i.ProductPictures).OrderByDescending(o => o.ID).Take(5),
                BestSellerProducts = db.Product.Include(i => i.ProductPictures).OrderBy(o => Guid.NewGuid()).Take(8)

            };
            return View(indexVM);
        }
        public IActionResult Card()
        {
            return View();
        }
        public IActionResult Category()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Product()
        {

            return View();
        }
    }
}
