﻿using Microsoft.AspNetCore.Mvc;
using Microblog.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace Microblog.Controllers
{
    public class HomeController : Controller
    {
        private MicroblogContext _context { get; set; }
        public HomeController(MicroblogContext context) => _context = context;
        private int _initialPageSize = 15;
        private int _pageSize = 5;
        private int _previewCharCount = 300;

        [HttpGet]
        [Route("/{FilterCategory?}")]
        public ViewResult Index(BlogViewModel model)
        {
            ViewBag.PageSize = _pageSize;

            IQueryable<BlogPost> query = _context.BlogPosts.Include(bp => bp.Category).OrderByDescending(bp => bp.CreatedDate);

            if (model.FilterCategory != "all")
            {
                query = query.Where(bp => bp.Category.Name == model.FilterCategory);
            }
            ViewBag.ArticleCount = query.Count();
            //load initial pagesize, TODO should initial page size be bigger?
            model.Posts = query.Take(_initialPageSize).ToList();
            foreach (var post in model.Posts)
            {
                post.CreatePreview(_previewCharCount);
            }
            return View(model);
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
            foreach(var post in vm.Posts)
            {
                post.CreatePreview(_previewCharCount);
                post.Content = Markdig.Markdown.ToHtml(post.Content ?? "Error reading post content: Controller");
            }
            return Json(vm.Posts);
        }
    }
}
