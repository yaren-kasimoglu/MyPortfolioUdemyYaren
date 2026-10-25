using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemyYaren.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
