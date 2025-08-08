using CodeFirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ProdContext _context;
        public IEnumerable<Category> categories;
        public CategoryController(ProdContext context)
        {
            _context=context;
            categories = _context.Categories.ToList();
        }


        public IActionResult Index()
        {
            IEnumerable<Category> categories = _context.Categories.ToList();
            return View(categories);

        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            Category c=null;
            foreach (var category in categories) {

                if(id==category.CategoryId)
                {
                    c = category;
                }


            }

            return View(c);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();

            return View(); // For page refresh or return to Index page by return RedirectToAction(nameof(Index))


        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Category category1 = null;
            foreach (var category in _context.Categories)
            {

                if (id == category.CategoryId)
                {
                    category1 = category;

                }
            }

            return View(category1);

        }
        [HttpPost]
        public IActionResult Edit(int id,  Category category)
        {


            var existing = _context.Categories.FirstOrDefault(c => c.CategoryId == id);
            if (existing == null)
                return NotFound();

            existing.CategoryName = category.CategoryName; 

            _context.SaveChanges();

            /*
             * 
             */


            return RedirectToAction("Index");
        }
    }
}
