using Microsoft.AspNetCore.Mvc;
using NewsPortal.Areas.Admin.Models;
using NewsPortal.Data;
using NewsPortal.Models;
using NewsPortal.ViewModel;
using System.Diagnostics;

namespace NewsPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }

          public IActionResult Index()
          {
            IndexViewModel model = new IndexViewModel
            {
                News=_db.News.ToList(),
                Categories=_db.Categories.ToList(), 
            };
            return View(model);
          }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}