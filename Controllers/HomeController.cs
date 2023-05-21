using Microsoft.AspNetCore.Mvc;
using Microblog.Models;
using Microsoft.EntityFrameworkCore;

namespace Microblog.Controllers
{
    public class HomeController : Controller
    {
        private MicroblogContext _context { get; set; }
        public HomeController(MicroblogContext context) => _context = context;

        public IActionResult Index()
        {
            var posts = _context.BlogPosts.Include(bp => bp.Category).OrderByDescending(bp => bp.CreatedDate).ToList();
            return View(posts);
        }

        //TODO work on filtering by category and list of tags
        //public IActionResult List(string category = "all", string tag = "all")
        //{
        //    var posts = _context.BlogPosts.Include(bp = bp.Category).
        //}
    }
}
