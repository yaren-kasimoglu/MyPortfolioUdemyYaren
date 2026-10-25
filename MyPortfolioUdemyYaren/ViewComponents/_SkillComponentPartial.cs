using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemyYaren.ViewComponents
{
    public class _SkillComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
