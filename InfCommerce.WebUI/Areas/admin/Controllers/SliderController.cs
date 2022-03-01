using InfCommerce.DAL.DbContexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfCommerce.WebUI.Areas.admin.Controllers
{
    [Area("admin")]
    public class SliderController : Controller
    {
        private readonly SqlContext sqlContext;

        public SliderController(SqlContext sqlContext)
        {
            this.sqlContext = sqlContext;
        }
        public IActionResult Index()
        {
            var model = sqlContext.Slider.ToList();

            return View(model);
        }
    }
}
