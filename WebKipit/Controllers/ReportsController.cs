using Microsoft.AspNetCore.Mvc;

namespace WebKipit.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Activeusers()
        {
            return View();
        }
        public IActionResult Newsignup()
        {
            return View();
        }
        public IActionResult SalesLiners()
        {
            return View();
        }
        public IActionResult SalesStickers()
        {
            return View();
        }
        public IActionResult InuseItems()
        {
            return View();
        }

        public IActionResult InuseLiners()
        {
            return View();
        }
        public IActionResult InuseStickers()
        {
            return View();
        }
        public IActionResult Messages()
        {
            return View();
        }
    }
}