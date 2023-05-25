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
            //DONEXT need to clean this up
            //apply the filter redirect action to add a category to a new filtered categories property in blogviewmodel and have this action filter by the category if property is pouplated.
            ViewBag.Message = TempData["message"];
            //model.Categories = _context.Categories.ToList();

            IQueryable<BlogPost> query = _context.BlogPosts.Include(bp => bp.Category).OrderBy(bp => bp.CreatedDate);
            //if (model.Categories is not null)
            //{
            //    query = query.Where(bp => model.Categories.Contains(bp.Category));
            //}
            //TODO another IF for Tags
            //if (!String.IsNullOrEmpty(categoryFilter))
            //{
            //    query = query.Where(bp => bp.Category.Name == categoryFilter);
            //}

            model.Posts = query.ToList();
            return View(model);
        }

        public RedirectToActionResult Filter(BlogViewModel model)
        {
                return RedirectToAction("Index");
        }
    }
}
