using Microsoft.AspNetCore.Mvc;
using WEB_953505_Krasovskiy.Extensions;
using WEB_953505_Krasovskiy.Models;

namespace WEB_953505_Krasovskiy.Views.Shared.Components
{
    public class CartViewComponent : ViewComponent
    {
        private Cart _cart;
        public CartViewComponent(Cart cart)
        {
            _cart = cart;
        }
        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}
