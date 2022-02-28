using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InfCommerce.WebUI.Areas.admin.Controllers
{
    [Area("admin"),Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/admin/giris"),AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
    }
}
