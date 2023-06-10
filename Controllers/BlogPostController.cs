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
        public ViewResult Index(int id)
        {
            var bp = _context.BlogPosts.Find(id)!;
            //TODO what happens if id is not found? handle exception
            //Redirect to 404 if id is not found.
            bp.Category = _context.Categories.Find(bp.CategoryId)!;
            return View(bp);
        }

        //TODO move ADD to controller in Admin area
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Categories = _context.Categories.OrderBy(c => c.Name).ToList();
            return View("Edit", new BlogPost());
        }

        //TODO once add is moved, delete all of this
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Categories = _context.Categories.OrderBy(c => c.Name).ToList();
            var blogPost = _context.BlogPosts.Find(id);
            return View(blogPost);
        }

        [HttpPost]
        public IActionResult Edit(BlogPost blogPost)
        {
            if (ModelState.IsValid)
            {
                if (blogPost.Id == 0)
                {
                    _context.BlogPosts.Add(blogPost);
                    TempData["message"] = $"{blogPost.Title} published!";
                }
                else
                {
                    _context.BlogPosts.Update(blogPost);
                    TempData["message"] = $"{blogPost.Title} updated!";
                }
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                //TODO when does this happen???
                ViewBag.Action = (blogPost.Id == 0) ? "Add" : "Edit";
                ViewBag.Categories = _context.Categories.OrderBy(c => c.Name).ToList();
                return View(blogPost);
            }            
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var blogPost = _context.BlogPosts.Find(id);
            return View(blogPost);
        }

        [HttpPost]
        public IActionResult Delete(BlogPost blogPost)
        {
            _context.BlogPosts.Remove(blogPost);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
