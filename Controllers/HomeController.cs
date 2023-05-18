using Microsoft.AspNetCore.Mvc;
using Microblog.Models;

namespace Microblog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.AuthorName = "Victor Diaz";
            ViewBag.FeaturedBlog = "Featured Blog Title";
            return View();
        }
    }
}
