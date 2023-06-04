using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Microblog.Models
{
    public class MicroblogContext : IdentityDbContext<User>
    {
        public MicroblogContext(DbContextOptions<MicroblogContext> options) : base(options) { }

        public DbSet<BlogPost> BlogPosts { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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
                },
                new BlogPost
                {
                    Id = 5,
                    Title = "Microblog, day Five",
                    Content = "Added Admin Area starter files. Added link in home page to admin area. Did a nested three tier layout with _Layout holding shared <head> code, _MainLayout holding header and fotter, and then the other views nested within. Added bootstrap navigation bar. Added option scripts section to _layout that loads validation scripts for views that need it.",
                    CreatedDate = new DateTime(2023, 5, 21, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    CategoryId = "DEV"
                },
                new BlogPost
                {
                    Id = 6,
                    Title = "Microblog, day Six",
                    Content = "Added BlogViewModel class. Udpated HomeController Index action to return new BlogModelView as the model for the view. Updated Home/index to use BlogModelView as view model. Added single blog post view. Added Index action to BlogPost controller for single blog post view.",
                    CreatedDate = new DateTime(2023, 5, 22, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    CategoryId = "DEV"
                },
                new BlogPost
                {
                    Id = 7,
                    Title = "Microblog, day Seven",
                    Content = "Gave another go at bootstrap after watching a couple of videos. I understoo it a lot better. Removed bootstrap files and supporting library files from solution and added links to get from a CDN instead. Updated libman.json file. Styled blog, very basic setup but cleaner. Used TempData to pass a message from the Blog Post Controller to the Home Controller in order to display a message showing that a post was either added or updated. Definitely need to make a deeper dive on linq. Added ability to filer by a single category but will need to add a filtered category property to Blog View Model to filter by multiple. Same will apply to tags if implemented.",
                    CreatedDate = new DateTime(2023, 5, 24, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    CategoryId = "DEV"
                },
                new BlogPost
                {
                    Id = 8,
                    Title = "Microblog, day Eight",
                    Content = "Went back to single filter category but this time using a routing parameter. I think it's a better implementation as there is no need to keep this data saved in the model.",
                    CreatedDate = new DateTime(2023, 5, 26, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    CategoryId = "DEV"
                },
                new BlogPost
                {
                    Id = 9,
                    Title = "Microblog, day Nine",
                    Content = "Set up Visual Studio for mac. Updated application to use SQLite instead of SQL Server. Consisted up udpdating the Builder.Services.AddDbContext method's options parameter to use SQLite, the connection string, and deleting all migrations files to build a new Initial migration. There could be a workaround to deleting the migrations files, the issue seems to be that SQLite does not like the 'max' option as a varchar parameter. After that, updating the database was succesful and the application worked.",
                    CreatedDate = new DateTime(2023, 5, 26, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    CategoryId = "DEV"
                },
                new BlogPost
                {
                    Id = 10,
                    Title = "Microblog, day Ten",
                    Content = "Back to windows development. Updated connection string, DI, rebuilt initial migration and database. Fixed the alignment issues between nav header and main content. Fixed single blog post layout for Index, Edit, & Delete.",
                    CreatedDate = new DateTime(2023, 5, 26, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    CategoryId = "DEV"
                }
                ,
                new BlogPost
                {
                    Id = 11,
                    Title = "Microblog, day Eleven",
                    Content = "Stared working on the Admin area in order to move some of the post/edit functionality to that area. Had some issues with the routing. The current area routing does not like it when I set up a controller/View in the admin area with the name of Home. Changing the name work. I'm sure this has something to do with routing but it's out of my knowledge scope at the moment. Added a form to the admin index page to create/edit posts. Updated Admin BlogPost controller to have create/edit post functionality. Removed the admin and new post placeholder links from home page. Moved the delete functionality to the admin area. Added AspNetCore.Identity functionality to require a log in to access the admin area. Created the Account Controller, LoginViewModel, & the Login view. Created the ConfigureIdentity class in order to seed admin user account data.",
                    CreatedDate = new DateTime(2023, 5, 26, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    CategoryId = "DEV"
                }
            );
        }
    }
}
