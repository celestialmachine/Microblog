using Microsoft.EntityFrameworkCore;

namespace Microblog.Models
{
    public class MicroblogContext : DbContext
    {
        public MicroblogContext(DbContextOptions<MicroblogContext> options) : base(options) { }

        public DbSet<BlogPost> BlogPosts { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "PRS", Name = "Personal" },
                new Category { CategoryId = "DEV", Name = "Development" },
                new Category { CategoryId = "TRV", Name = "Travel" },
                new Category { CategoryId = "TST", Name = "Test" }
            );
            modelBuilder.Entity<BlogPost>().HasData(
                new BlogPost
                {
                    Id = 1,
                    Title = "Microblog, day one",
                    Content = "Set up folder structure. Deleted starter files. Added own HomeController. Added BlogPost class. Added own /Home/Index.cshtml. Added own _layout. Added Tagg Helper to _ViewImports",
                    CreatedDate = new DateTime(2023, 5, 17, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    CategoryId = "PRS"
                },
                new BlogPost
                {
                    Id = 2,
                    Title = "Microblog, day two",
                    Content = "Added EF Core. Added DBContext class(MicroblogContext) with starter seed data. Added EF Core dependency injection. Added bootstrap and supporting jQuery, popper. Added bootstrap and supporting scripts to _Layout. Added connection string. Created database using migrations. Added MicroblogContext to home controller to test mvc pattern. Quick render of data on home/index. Misspelled TagHelpers on _ViewImports and cried for an hour.",
                    CreatedDate = new DateTime(2023, 5, 18, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    CategoryId = "TRV"
                },
                new BlogPost
                {
                    Id = 3,
                    Title = "Microblog, day three",
                    Content = "Tried to do an initial style of blog with bootstrap but not sure the results are the best. For something so simple I might just do my own styling. Or I need to learn more about bootstrap. Added new migration(TestContentMigration) to update blog content and titles. Added BlogPost controller with initial add, edit, delete requests. Added BlogPost Edit view.",
                    CreatedDate = new DateTime(2023, 5, 19, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    CategoryId = "DEV"
                },
                new BlogPost
                {
                    Id = 4,
                    Title = "Microblog, day Four",
                    Content = "Added BlogPost/Edit view content. Added BlogPost/Delete view page and content. Tested passing the model around. Updated button on BlogPost/Edit view to reflect if making new post or updating existing one. Added Category class. Foreign key for Category added to BlogPost class. Added Category to MicroBlog Context to seed data. Added migration and updated database. Edited view to reflect new category. Added lowercase URL routing with optional slug parameter. Added slug property to BlogPost class. Although slug may not be a good choice for blog content. Played around with routing but will get back to it when I sort by category and tags. Added admin area folders.",
                    CreatedDate = new DateTime(2023, 5, 20, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    CategoryId = "TST"
                }
            );
        }
    }
}
