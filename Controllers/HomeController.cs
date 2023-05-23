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
            model.Categories = _context.Categories.ToList();
            //DELETE List<string> arr = new List<string>();
            //foreach (var category in model.Categories)
            //{
            //    arr.Add(category.CategoryId);
            //}

            IQueryable<BlogPost> query = _context.BlogPosts.OrderBy(bp => bp.CreatedDate);
            if (model.Categories is not null)
            {
                //DELETE query = query.Where(bp => arr.Contains(bp.CategoryId) );
                query = query.Where(bp => model.Categories.Contains(bp.Category));
            }
            //TODO another IF for Tags

            model.Posts = query.ToList();
            return View(model);
        }

        //TODO work on filtering by category and list of tags
        //public IActionResult List(string category = "all", string tag = "all")
        //{
        //    var posts = _context.BlogPosts.Include(bp = bp.Category).
        //}
    }
}
