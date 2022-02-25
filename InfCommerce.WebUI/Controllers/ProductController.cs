using InfCommerce.DAL.DbContexts;
using InfCommerce.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace InfCommerce.WebUI.Controllers
{
    public class ProductController : Controller
    {
        SqlContext db;
        public ProductController(SqlContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {

            return View();
        }

        [Route("/urun/{name}-{id}")] //product/ali/Detail
        public IActionResult Detail(string name, int id)
        {
            Product product = db.Product.FirstOrDefault(x => x.ID == id) ?? null;
            if (product != null) return View(product);
            else return Redirect("/");
        }
    }
}