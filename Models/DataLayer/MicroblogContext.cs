using Microsoft.EntityFrameworkCore;

namespace Microblog.Models
{
    public class MicroblogContext : DbContext
    {
        public MicroblogContext(DbContextOptions<MicroblogContext> options) : base(options) { }

        public DbSet<BlogPost> BlogPosts { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlogPost>().HasData(
                new BlogPost
                {
                    BlogPostId = 1,
                    Title = "Chilaquiles verdes please",
                    Content = "lectus sit amet est placerat in egestas erat imperdiet sed euismod nisi porta lorem mollis aliquam ut porttitor leo a diam sollicitudin tempor id eu.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Category = "Personal"
                },
                new BlogPost
                {
                    BlogPostId = 2,
                    Title = "Aspiring polymath",
                    Content = "lectus sit amet est placerat in egestas erat imperdiet sed euismod nisi porta lorem mollis aliquam ut porttitor leo a diam sollicitudin tempor id eu.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Category = "Development"
                },
                new BlogPost
                {
                    BlogPostId = 3,
                    Title = "Mexico born, Texas raised",
                    Content = "lectus sit amet est placerat in egestas erat imperdiet sed euismod nisi porta lorem mollis aliquam ut porttitor leo a diam sollicitudin tempor id eu.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    Category = "Travel"
                }
            );
        }
    }
}
