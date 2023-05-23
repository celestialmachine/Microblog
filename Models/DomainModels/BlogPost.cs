﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Microblog.Models
{
    public class BlogPost
    {
        //TODO work on data validation ruels
        //TODO create an enum for post status ie published, draft, public, private
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a title for the blog post.")]
        [StringLength(75)]
        public string? Title { get; set; }
        [Required]
        public string? Content { get; set; }
        public DateTime CreatedDate { get; set;}
        public DateTime UpdatedDate { get; set;}
        [Required(ErrorMessage =  "Please select a category or enter a new one.")]
        public string CategoryId { get; set; } = string.Empty;
        [ValidateNever]
        public Category Category { get; set; } = null!;
        public int WordCount(string post)
        {
            //TODO this does not account for double spaces and maybe
            //not markdown either, find better solution
            return post.Split(" ").Length;
        }
        //TODO kinda useless in this blog scenario but okay. Maybe get rid off.
        public string Slug => CategoryId + '-' + Title?.Replace(' ', '-').ToLower();
    }
}
