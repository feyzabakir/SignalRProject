using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutFooterPartilalComponent:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}

	}
}
