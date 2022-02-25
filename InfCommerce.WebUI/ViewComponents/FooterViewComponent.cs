using InfCommerce.DAL.DbContexts;
using InfCommerce.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace InfCommerce.WebUI.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        SqlContext db;
        public FooterViewComponent(SqlContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            FooterVM footerVM = new FooterVM { 
                Brands= db.Brand,
                Newses=db.News.OrderByDescending(o=>o.RecDate).Take(2)
            }; 
            return View(footerVM);
        }
    }
}
