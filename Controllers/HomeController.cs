using Microsoft.AspNetCore.Mvc;
using Microblog.Models;
using Microsoft.EntityFrameworkCore;

namespace Microblog.Controllers
{
    public class HomeController : Controller
    {
        private MicroblogContext _context { get; set; }
        public HomeController(MicroblogContext context) => _context = context;

        [HttpGet]
        [Route("/{FilterCategory?}")]
        public ViewResult Index(BlogViewModel model)
        {
            ViewBag.Message = TempData["message"];

            IQueryable<BlogPost> query = _context.BlogPosts.Include(bp => bp.Category).OrderBy(bp => bp.CreatedDate);
            if (model.FilterCategory != "all")
            {
                query = query.Where(bp => bp.Category.Name == model.FilterCategory);
            }

            model.Posts = query.ToList();
            return View(model);
        }
    }
}
