using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemyYaren.ViewComponents
{
    public class _TestimonialComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
