using Microsoft.AspNetCore.Mvc;
using Microblog.Models;
using Microsoft.EntityFrameworkCore;

namespace Microblog.Controllers
{
    public class HomeController : Controller
    {
        private MicroblogContext _context { get; set; }
        public HomeController(MicroblogContext context) => _context = context;

        public ViewResult Index(BlogViewModel model)
        {
            ViewBag.Message = TempData["messagte"];
            model.Categories = _context.Categories.ToList();

            IQueryable<BlogPost> query = _context.BlogPosts.OrderBy(bp => bp.CreatedDate);
            if (model.Categories is not null)
            {
                query = query.Where(bp => model.Categories.Contains(bp.Category));
            }
            //TODO another IF for Tags

            model.Posts = query.ToList();
            return View(model);
        }
    }
}
