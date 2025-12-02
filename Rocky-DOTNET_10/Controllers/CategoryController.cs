using Microsoft.AspNetCore.Mvc;

namespace Rocky_DOTNET_10.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
