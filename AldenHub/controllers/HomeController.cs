using Microsoft.AspNetCore.Mvc;

namespace AldenHub.Controllers
{
    public class HomeController : Controller
    {
        // Default home page
        public IActionResult Index()
        {
            return Content("Welcome to Alden Business Hub! 🎉 Your site is running successfully.");
        }
    }
}