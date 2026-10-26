using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemyYaren.DAL.Context;

namespace MyPortfolioUdemyYaren.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {

        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {

            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
