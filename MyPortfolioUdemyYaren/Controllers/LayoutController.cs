using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemyYaren.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
