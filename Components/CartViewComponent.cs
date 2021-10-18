using Microsoft.AspNetCore.Mvc;

namespace WEB_953505_Krasovskiy.Views.Shared.Components
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
