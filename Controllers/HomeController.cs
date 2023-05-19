using Microsoft.AspNetCore.Mvc;
using Microblog.Models;
using Microsoft.EntityFrameworkCore;

namespace Microblog.Controllers
{
    public class HomeController : Controller
    {
        private MicroblogContext _context { get; set; }
        public HomeController(MicroblogContext ctx) => _context = ctx;
        public IActionResult Index()
        {
            var posts = _context.BlogPosts.ToList();
            return View(posts);
        }
    }
}
