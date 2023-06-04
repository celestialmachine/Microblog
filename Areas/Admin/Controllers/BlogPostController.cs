using Microblog.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Microblog.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class BlogPostController : Controller
    {
        private MicroblogContext _context { get; set; }
        public BlogPostController(MicroblogContext context) => _context = context;

        [HttpGet]
        public IActionResult Index(int id)
        {
            ViewBag.Categories = _context.Categories.OrderBy(c => c.Name).ToList();
            if (id != 0)
            {
                var blogPost = _context.BlogPosts.Find(id);
                return View(blogPost);
            }
            else
            {
                return View(new BlogPost());
            }
        }

        [HttpPost]
        public IActionResult Edit(BlogPost blogPost)
        {
            if(ModelState.IsValid)
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
                ViewBag.Action = (blogPost.Id == 0) ? "Add" : "Edit";
                ViewBag.Categories = _context.Categories.OrderBy(c =>c.Name).ToList();
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
