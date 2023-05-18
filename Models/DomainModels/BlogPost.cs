using System.ComponentModel.DataAnnotations;

namespace Microblog.Models
{
    public class BlogPost
    {
        //TODO work on data validation ruels
        public int BlogPostId { get; set; }
        [Required(ErrorMessage = "Please enter a title for the blog post.")]
        [Range(0, 64)]
        public string? Title { get; set; }
        [Required]
        public string? Content { get; set; }
        public DateTime CreatedDate { get; set;}
        public DateTime UpdatedDate { get; set;}
        public string? Category { get; set; }
        public int WordCount(string post)
        {
            //TODO this does not account for double spaces and maybe
            //not markdown either, find better solution
            return post.Split(" ").Length;
        }
    }
}
