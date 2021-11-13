using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_953505_Krasovskiy.Data;
using WEB_953505_Krasovskiy.Extensions;
using WEB_953505_Krasovskiy.Models;

namespace WEB_953505_Krasovskiy.Controllers
{
    public class CartController : Controller
    {
        private ApplicationDbContext _context;
        private string cartKey = "cart";
        private Cart _cart;

        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            _cart = HttpContext.Session.Get<Cart>(cartKey);
            return View(_cart.Items.Values);
        }

        [Authorize]
        public IActionResult Add(int id, string returnUrl)
        {
            _cart = HttpContext.Session.Get<Cart>(cartKey);
            var item = _context.Dishes.Find(id);
            if (item != null)
            {
                _cart.AddToCart(item);
                HttpContext.Session.Set<Cart>(cartKey, _cart);
            }
            return Redirect(returnUrl);
        }
    }
}
