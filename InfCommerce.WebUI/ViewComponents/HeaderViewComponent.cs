using InfCommerce.DAL.DbContexts;
using Microsoft.AspNetCore.Mvc;

namespace InfCommerce.WebUI.ViewComponents
{
    public class HeaderViewComponent: ViewComponent
    {
        SqlContext db;
        public HeaderViewComponent(SqlContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            return View(db.Category);  
        }
    }
}
