using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemyYaren.ViewComponents.LayoutViewComponents
{
	public class _LayoutScriptComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
