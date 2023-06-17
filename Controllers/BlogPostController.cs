using Microblog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Microblog.Controllers
{
    public class BlogPostController : Controller
    {
        private MicroblogContext _context {  get; set; }
        public BlogPostController(MicroblogContext context) => _context = context;

        [HttpGet]
        [Route("/post/{id}")]
        public IActionResult Index(int id)
        {
            //redirect to home when blog post is 0 or does not exists
            var bp = _context.BlogPosts.Find(id)!;
            if(bp is null)
            {
                TempData["message"] = "That post does not exist, has been deleted, or is private.";
                return RedirectToAction("Index", "Home");
            }
            bp.Category = _context.Categories.Find(bp.CategoryId)!;
            return View(bp);
        }
    }
}
