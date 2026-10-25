using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemyYaren.ViewComponents
{
    public class _ExperienceComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
