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
        private int _initialPageSize = 10;
        private int _pageSize = 3;

        [HttpGet]
        [Route("/{FilterCategory?}")]
        public ViewResult Index(BlogViewModel model)
        {
            //TODO gotta show this message on the single post view
            ViewBag.Message = TempData["message"];
            ViewBag.PageSize = _pageSize;

            IQueryable<BlogPost> query = _context.BlogPosts.Include(bp => bp.Category).OrderByDescending(bp => bp.CreatedDate);

            if (model.FilterCategory != "all")
            {
                query = query.Where(bp => bp.Category.Name == model.FilterCategory);
            }
            ViewBag.ArticleCount = query.Count();
            //load initial pagesize, TODO should initial page size be bigger?
            model.Posts = query.Take(_initialPageSize).ToList();
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

        [HttpGet]
        public JsonResult LoadMore(string filter = "all", int startLoad = 0)
        {
            IQueryable<BlogPost> query = _context.BlogPosts.Include(bp => bp.Category).OrderByDescending(bp => bp.CreatedDate);

            //filter by category
            if(filter != "all")
            {
                query = query.Where(bp => bp.Category.Name == filter);
            }
            //get next 'page'
            query = query.Skip(startLoad).Take(_pageSize);
            var vm = new BlogViewModel { };
            vm.Posts = query.ToList();
            return Json(vm.Posts);
        }
    }
}
