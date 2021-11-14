using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WEB_953505_Krasovskiy.Entities;
using WEB_953505_Krasovskiy.Extensions;
using WEB_953505_Krasovskiy.Models;
using WEB_953505_Krasovskiy.Data;

namespace WEB_953505_Krasovskiy.Controllers
{
    public class ProductController : Controller
    {
        int _pageSize;
        ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _pageSize = 3;
            _context = context;
        }

        [Route("Catalog")]
        [Route("Catalog/Page_{pageNo}")]
        public IActionResult Index(int? group, int pageNo=1)
        {
            var dishesFiltered = _context.Dishes
                .Where(d => !group.HasValue || d.DishGroupId == group.Value);
            ViewData["Groups"] = _context.DishGroups;
            ViewData["CurrentGroup"] = group ?? 0;
            var model = ListViewModel<Dish>.GetModel(dishesFiltered, pageNo, _pageSize);
            if (Request.IsAjaxRequest())
                return PartialView("_listpartial", model);
            else
                return View(model);
        }
    }
}
