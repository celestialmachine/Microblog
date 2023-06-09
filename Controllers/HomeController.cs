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
        public IActionResult Index(GridData values)
        {
            ViewBag.Message = TempData["message"];
            IQueryable<BlogPost> query = _context.BlogPosts.Include(bp => bp.Category).OrderByDescending(bp => bp.CreatedDate);
            //create new viewModel
            var vm = new BlogViewModel
            {
                CurrentRoute = values,
            };
            //order by crated date according to route
            if (vm.CurrentRoute.SortDirection == "desc")
            {
                query = query.OrderByDescending(bp => bp.CreatedDate);
            }
            else
            {
                query = query.OrderBy(bp => bp.CreatedDate);
            }
            //filter by category
            if (vm.CurrentRoute.FilterCategory != "all")
            {
                query = query.Where(bp => bp.Category.Name == vm.CurrentRoute.FilterCategory);
            }
            //filter by paging
            query = query.Skip((vm.CurrentRoute.PageNumber - 1) * vm.CurrentRoute.PageSize).Take(vm.CurrentRoute.PageSize);
            vm.Posts = query.ToList();
            return View(vm);
        }
    }
}
