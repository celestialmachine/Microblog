using Microblog.Models;
using Microsoft.AspNetCore.Mvc;

namespace Microblog.Controllers
{
    public class BlogPostController : Controller
    {
        private MicroblogContext _context {  get; set; }
        public BlogPostController(MicroblogContext context) => _context = context;

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new BlogPost());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var blogPost = _context.BlogPosts.Find(id);
            return View(blogPost);
        }

        [HttpPost]
        public IActionResult Edit(BlogPost blogPost)
        {
            if (ModelState.IsValid)
            {
                if (blogPost.BlogPostId == 0)
                {
                    _context.BlogPosts.Add(blogPost);
                }
                else
                {
                    _context.BlogPosts.Update(blogPost);
                }
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (blogPost.BlogPostId == 0) ? "Add" : "Edit";
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
