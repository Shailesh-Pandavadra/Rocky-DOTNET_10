using Microsoft.AspNetCore.Mvc;
using Rocky_DOTNET_10.Data;
using Rocky_DOTNET_10.Models;

namespace Rocky_DOTNET_10.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Category> objList = _db.Category;
            return View(objList);
        }
    }
}
