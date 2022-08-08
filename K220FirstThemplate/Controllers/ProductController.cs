using K220FirstThemplate.Models;
using Microsoft.AspNetCore.Mvc;

namespace K220FirstThemplate.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            ButenDbContext db=new ButenDbContext();
            Product singleProduct=db.Products.FirstOrDefault(p => p.Id == id);
            if (singleProduct == null) return NotFound();

            return View(singleProduct);
        }
    }
}
