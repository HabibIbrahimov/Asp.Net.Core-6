
using BookShop.DataAccess;
using BookShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookShop.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly ApplicationDbContext _db;

        public FooterViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio bio = _db.Bios.FirstOrDefault();
            return View(await Task.FromResult(bio));

        }
    }
}
