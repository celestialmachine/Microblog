﻿namespace Microblog.Models
{
    public class BlogViewModel
    {
        public List<Category> Categories { get; set; } = new List<Category>();
        //TODO this will be a list of Tags once Tag class is created
        public List<string> Tags { get; set; } = new List<string>();
        //public string FilterCategory { get; set; } = "all";
        public List<BlogPost> Posts { get; set; } = new List<BlogPost>();
        public GridData CurrentRoute { get; set; } = new GridData();
        public int TotalPages { get; set; }
    }
}
