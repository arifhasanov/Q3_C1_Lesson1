using Lesson1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Controllers;
public class CatalogueController : Controller
{
    private static Catalogue _catalogue = new();

    [HttpGet]
    public IActionResult Categories()
    {
        return View(_catalogue);
    }

    [HttpPost]
    public IActionResult Categories(Category cat)
    {
        _catalogue?.Categories?.Add(cat);
        return View(_catalogue);
    }

    [HttpGet]
    public IActionResult Products()
    {
        if (_catalogue.Products.Count == 0)
        {
            _catalogue.Products.Add(new Product() { Id = 1, Name = "Apple", Image = "https://www.eckes-granini.com/fileadmin/eckesgranini/eckes-granini.com/05-best-of-fruit/fruechte/titelbilder/fruechte-titelbilder-apfel.jpg" });
            _catalogue.Products.Add(new Product() { Id = 2, Name = "Orange", Image = "https://media.istockphoto.com/photos/orange-picture-id185284489?k=20&m=185284489&s=612x612&w=0&h=LLY2os0YTG2uAzpBKpQZOAC4DGiXBt1jJrltErTJTKI=" });
        }
        return View(_catalogue);
    }

    [HttpPost]
    public IActionResult Products(Product prod)
    {
        _catalogue?.Products?.Add(prod);
        return View(_catalogue);
    }
}
