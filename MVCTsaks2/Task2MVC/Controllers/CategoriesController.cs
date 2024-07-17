using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task2MVC.context;
namespace Task2MVC.Controllers
{
    public class CategoriesController: Controller
    {
        private readonly conrctioncs _context;

        public CategoriesController(conrctioncs context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }
    }
}
