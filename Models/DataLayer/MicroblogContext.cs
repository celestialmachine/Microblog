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
                    Title = "Microblog, day one",
                    Content = "Set up folder structure. Deleted starter files. Added own HomeController. Added BlogPost class. Added own /Home/Index.chtml. Added own _layout. Added Tagg Helper to _ViewImports",
                    CreatedDate = new DateTime(2023, 5, 17, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    Category = "Personal"
                },
                new BlogPost
                {
                    BlogPostId = 2,
                    Title = "Microblog, day two",
                    Content = "Added EF Core. Added DBContext class(MicroblogContext) with starter seed data. Added EF Core dependency injection. Added bootstrap and supporting jQuery, popper. Added bootstrap and supporting scripts to _Layout. Added connection string. Created database using migrations. Added MicroblogContext to home controller to test mvc pattern. Quick render of data on home/index. Misspelled TagHelpers on _ViewImports and cried for an hour.",
                    CreatedDate = new DateTime(2023, 5, 18, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    Category = "Development"
                },
                new BlogPost
                {
                    BlogPostId = 3,
                    Title = "Microblog, day three",
                    Content = "Tried to do an initial style of blog with bootstrap but not sure the results are the best. For something so simple I might just do my own styling. Or I need to learn more about bootstrap. Added new migration(TestContentMigration) to update blog content and titles. Added BlogPost controller with initial add, edit, delete requests. Added BlogPost Edit view.",
                    CreatedDate = new DateTime(2023, 5, 19, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    Category = "Travel"
                }
            );
        }
    }
}
