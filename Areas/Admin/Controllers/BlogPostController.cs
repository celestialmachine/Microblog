using Microsoft.AspNetCore.Mvc;

namespace Microblog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogPostController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        //TODO placeholder, may not be working properly
        [Route("[area]/[controller]/{id}")]
        public IActionResult Edit(int id)
        {
            return View();
        }
    }
}
