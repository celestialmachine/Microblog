using Microsoft.AspNetCore.Mvc;
using Microblog.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

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

            IQueryable<BlogPost> query = _context.BlogPosts.Include(bp => bp.Category).OrderByDescending(bp => bp.CreatedDate);

            if (model.FilterCategory != "all")
            {
                query = query.Where(bp => bp.Category.Name == model.FilterCategory);
            }
            //TODO LOAD MORE?
            model.Posts = query.ToList();
            return View(model);
        }


        [HttpGet]
        public IActionResult Test()
        {
            IQueryable<BlogPost> query = _context.BlogPosts.Include(bp => bp.Category).OrderByDescending(bp => bp.CreatedDate);
            //create new viewModel
            var vm = new BlogViewModel { };
            //filter by paging
            //query = query.Skip((vm.CurrentRoute.PageNumber - 1) * vm.CurrentRoute.PageSize).Take(vm.CurrentRoute.PageSize);
            vm.Posts = query.ToList();
            return View(vm);
        }
    }
}
