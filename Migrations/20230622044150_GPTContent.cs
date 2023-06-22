using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Microblog.Migrations
{
    public partial class GPTContent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Content", "Title", "UpdatedDate" },
                values: new object[] { "DEV", ".NET is a powerful and versatile framework that can be used to develop a wide range of applications, including web, mobile, desktop, and cloud-based solutions. If you're interested in learning .NET, here are some steps you can follow to get started:\r\n\r\n1. **Choose a language**: .NET supports multiple programming languages, including C#, F#, and Visual Basic. C# is the most popular language for .NET development, so it's a good choice for beginners.\r\n\r\n2. **Install the .NET SDK**: The .NET SDK (Software Development Kit) includes everything you need to start developing .NET applications. You can download it from the official .NET website.\r\n\r\n3. **Learn the basics**: Once you have the .NET SDK installed and have chosen a language to work with, it's time to start learning the basics. There are many resources available online to help you learn the fundamentals of .NET development, including tutorials, documentation, and video courses.\r\n\r\n4. **Practice**: The best way to learn is by doing. Try building some simple applications to practice your skills and reinforce your understanding of the concepts you've learned.\r\n\r\n5. **Join the community**: The .NET community is large and active, with many resources available to help you learn and grow as a developer. Join online forums, attend meetups or conferences, and connect with other developers to share knowledge and learn from each other.\r\n\r\nBy following these steps and dedicating time to learning and practicing, you'll be well on your way to becoming a skilled .NET developer.", "Learning .NET: A Beginner’s Guide", new DateTime(2023, 6, 21, 21, 41, 50, 508, DateTimeKind.Local).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Content", "Title", "UpdatedDate" },
                values: new object[] { "DEV", "Developing a blog website using .NET can be a rewarding experience. In this post, I’ll share my journey of how I successfully developed a blog website using .NET.\r\n\r\nPlanning: Before starting any development work, it’s important to plan out the project. I spent time researching and deciding on the features and functionality I wanted to include in my blog website.\r\n\r\nChoosing the right tools: .NET offers a wide range of tools and technologies for web development. I chose to use ASP.NET Core for my blog website because it’s a modern, fast, and scalable framework.\r\n\r\nDesigning the architecture: With the features and tools decided, I designed the architecture of my blog website. This included deciding on the data models, database design, and overall structure of the application.\r\n\r\nImplementing the features: With the architecture in place, I started implementing the features of my blog website. This included creating the user interface, setting up authentication and authorization, and implementing the core functionality such as creating and managing blog posts.\r\n\r\nTesting and debugging: As with any development project, testing and debugging were an important part of the process. I tested my blog website thoroughly to ensure that everything was working as expected and fixed any issues that arose.\r\n\r\nDeploying: Once everything was tested and working correctly, I deployed my blog website to a hosting provider. This made it accessible to the public and allowed me to start sharing my content with the world.\r\n\r\nDeveloping a blog website using .NET was a challenging but rewarding experience. By following a structured approach and using the right tools and technologies, I was able to successfully create a functional and attractive blog website.", "How I Successfully Developed a Blog Website Using .NET", new DateTime(2023, 6, 21, 21, 41, 50, 508, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "Title", "UpdatedDate" },
                values: new object[] { "**ASP.NET MVC** is a popular framework for building web applications using the Model-View-Controller (MVC) design pattern. In this post, we’ll go through the steps needed to set up an ASP.NET MVC project in Visual Studio.\r\n\r\nInstall Visual Studio: If you don’t already have Visual Studio installed, you’ll need to download and install it. You can download the Community edition for free from the official Visual Studio website.\r\n\r\nCreate a new project: Once you have Visual Studio installed, open it and create a new project. Select File > New > Project... from the menu, then choose ASP.NET Web Application (.NET Framework) from the list of templates.\r\n\r\nChoose the MVC template: After selecting the ASP.NET Web Application (.NET Framework) template, you’ll be prompted to choose a specific template for your project. Choose the MVC template and click OK.\r\n\r\nConfigure the project: After choosing the MVC template, you’ll be taken to the New ASP.NET Web Application dialog. Here you can configure various settings for your project, such as authentication options and target framework version. Make any changes as needed and click OK to create the project.\r\n\r\nExplore the project: Once the project is created, take some time to explore it and familiarize yourself with its structure. You’ll see that Visual Studio has automatically generated several files and folders for you, including controllers, views, and models.\r\n\r\nBy following these steps, you’ll have successfully set up an ASP.NET MVC project in Visual Studio and will be ready to start developing your web application.", "Setting Up an ASP.NET MVC Project in Visual Studio: A Step-by-Step Guide", new DateTime(2023, 6, 21, 21, 41, 50, 508, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Content", "Title", "UpdatedDate" },
                values: new object[] { "DEV", "Entity Framework (EF) Core is a modern, lightweight, extensible, and cross-platform version of the popular Entity Framework data access technology. It serves as an object-relational mapper (O/RM), enabling .NET developers to work with a database using .NET objects and eliminating the need for most of the data-access code that typically needs to be written ².\r\n\r\nSome of the advantages of EF Core include:\r\n\r\n- **Support for multiple database engines**: EF Core supports many database engines, including SQL Server/Azure SQL Database, SQLite, Azure Cosmos DB, MySQL, PostgreSQL, and many more through a database provider plugin model ³.\r\n\r\n- **LINQ support**: EF Core allows developers to write LINQ (Language Integrated Query) queries to work with data using objects of domain-specific classes instead of the underlying database tables and columns where this data is stored ¹.\r\n\r\n- **Reduced development time and cost**: EF Core provides auto-generated code and allows developers to visually design models and mapping of databases. This can help reduce development time and cost ⁴.\r\n\r\n- **Unit of Work implementation**: EF Core provides Unit of Work (UOW) implementation out of the box ¹.\r\n\r\n- **Data binding friendly**: EF Core is data binding friendly ¹.\r\n\r\n- **Fast CRUD operations**: EF Core helps to perform fast CRUD (Create, Read, Update, Delete) operations in .NET applications ¹.\r\n\r\nThese are just some of the many advantages that EF Core offers over other frameworks. Its versatility and ease-of-use make it a popular choice for .NET developers.\r\n\r\n---\r\nSource: Conversation with Bing, 6/20/2023\r\n1. Overview of Entity Framework Core - EF Core | [Microsoft Learn](https://learn.microsoft.com/en-us/ef/core/)\r\n2. Compare EF6 and EF Core | [Microsoft Learn](https://learn.microsoft.com/en-us/ef/efcore-and-ef6/)\r\n3. Intro to Entity Framework Core 5 - New features | [DEV Community](https://dev.to/moe23/intro-to-entity-framework-core-5-new-features-1kle)\r\n4. Advantages and Disadvantages of Entity Framework | [Cybarlab](https://cybarlab.com/advantages-and-disadvantages-of-ef)", "The Advantages of Entity Framework Core", new DateTime(2023, 6, 21, 21, 41, 50, 508, DateTimeKind.Local).AddTicks(8606) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Content", "Title", "UpdatedDate" },
                values: new object[] { "Integrating Bootstrap in a .NET MVC application is a straightforward process. There are several ways to do this, but one of the easiest ways is to use the Library Manager (Libman) in Visual Studio. You can right-click on your project name in the Solution Explorer, then select Add > Client-Side Library which will open the Add Client-Side Library window.\r\n\r\nAnother way to integrate Bootstrap into your .NET MVC application is to download the Bootstrap files from their website and add them to your project manually. You can then include the necessary CSS and JavaScript files in your views or layout pages.\r\n\r\nYou can also use NuGet or NPM to install Bootstrap in your .NET MVC application.\r\n\r\n---\r\nSource: Conversation with Bing, 6/20/2023\r\n1. Bootstrap with ASP.NET MVC 4 – Step by Step - My Tec Bits | [MyTechBits](https://www.mytecbits.com/microsoft/dot-net/bootstrap-with-asp-net-mvc-4-step-by-step)\r\n2. Installing Bootstrap in an ASP.NET MVC App | [Stack Overflow](https://stackoverflow.com/questions/59563756/installing-bootstrap-in-an-asp-net-mvc-app) \r\n3. ASP .Net MVC Web Application integrating bootstrap templates | [Stack Overflow](https://stackoverflow.com/questions/26041853/asp-net-mvc-web-application-integrating-bootstrap-templates) ", "Using Bootstrap in .NET MVC Applications: A Simple Guide", new DateTime(2023, 6, 21, 21, 41, 50, 508, DateTimeKind.Local).AddTicks(8607) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Content", "Title", "UpdatedDate" },
                values: new object[] { "ASP.NET Identity is an API that supports user interface (UI) login functionality and manages users, passwords, profile data, roles, claims, tokens, email confirmation, and more. Users can create an account with the login information stored in Identity or they can use an external login provider. Supported external login providers include Facebook, Google, Microsoft Account, and Twitter².\r\n\r\nSome of the advantages of using ASP.NET Identity include:\r\n- Separation of storage\r\n- Asynchronous APIs\r\n- Custom password hashing using UserManager APIs with the help of IPasswordHasher interface\r\n- Support for any types of external login provider like Facebook, Google, etc. to authenticate the user details\r\n- Supports all types of ASP.NET applications like Web Forms, MVC, Web API, SignalR or web pages\r\n- Easy to customize\r\n- Designed based on interfaces which means highly customizable\r\n- Highly testable\r\n- Default implementation uses Entity Framework code first\r\n- By default, system uses SQL Server database¹\r\n---\r\n\r\nSource: Conversation with Bing, 6/20/2023\r\n\r\n1. Introduction to Identity on ASP.NET Core | [Microsoft Learn.](https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-7.0.)\r\n2. How To Implement Authentication Using Identity Model In ASP.NET Core | [C\\#Corner](https://www.c-sharpcorner.com/article/how-to-implement-authentication-using-identity-model-in-asp-net-core/.)", "ASP.NET Identity", new DateTime(2023, 6, 21, 21, 41, 50, 508, DateTimeKind.Local).AddTicks(8608) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Content", "Title", "UpdatedDate" },
                values: new object[] { "PRS", "Set up folder structure. Deleted starter files. Added own HomeController. Added BlogPost class. Added own /Home/Index.cshtml. Added own _layout. Added Tagg Helper to _ViewImports", "Microblog, day one", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Content", "Title", "UpdatedDate" },
                values: new object[] { "TRV", "Added EF Core. Added DBContext class(MicroblogContext) with starter seed data. Added EF Core dependency injection. Added bootstrap and supporting jQuery, popper. Added bootstrap and supporting scripts to _Layout. Added connection string. Created database using migrations. Added MicroblogContext to home controller to test mvc pattern. Quick render of data on home/index. Misspelled TagHelpers on _ViewImports and cried for an hour.", "Microblog, day two", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "Title", "UpdatedDate" },
                values: new object[] { "Tried to do an initial style of blog with bootstrap but not sure the results are the best. For something so simple I might just do my own styling. Or I need to learn more about bootstrap. Added new migration(TestContentMigration) to update blog content and titles. Added BlogPost controller with initial add, edit, delete requests. Added BlogPost Edit view.", "Microblog, day three", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Content", "Title", "UpdatedDate" },
                values: new object[] { "TST", "Added BlogPost/Edit view content. Added BlogPost/Delete view page and content. Tested passing the model around. Updated button on BlogPost/Edit view to reflect if making new post or updating existing one. Added Category class. Foreign key for Category added to BlogPost class. Added Category to MicroBlog Context to seed data. Added migration and updated database. Edited view to reflect new category. Added lowercase URL routing with optional slug parameter. Added slug property to BlogPost class. Although slug may not be a good choice for blog content. Played around with routing but will get back to it when I sort by category and tags. Added admin area folders.", "Microblog, day Four", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Content", "Title", "UpdatedDate" },
                values: new object[] { "Added Admin Area starter files. Added link in home page to admin area. Did a nested three tier layout with _Layout holding shared <head> code, _MainLayout holding header and fotter, and then the other views nested within. Added bootstrap navigation bar. Added option scripts section to _layout that loads validation scripts for views that need it.", "Microblog, day Five", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4584) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Content", "Title", "UpdatedDate" },
                values: new object[] { "Added BlogViewModel class. Udpated HomeController Index action to return new BlogModelView as the model for the view. Updated Home/index to use BlogModelView as view model. Added single blog post view. Added Index action to BlogPost controller for single blog post view.", "Microblog, day Six", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4585) });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 7, "DEV", "Gave another go at bootstrap after watching a couple of videos. I understoo it a lot better. Removed bootstrap files and supporting library files from solution and added links to get from a CDN instead. Updated libman.json file. Styled blog, very basic setup but cleaner. Used TempData to pass a message from the Blog Post Controller to the Home Controller in order to display a message showing that a post was either added or updated. Definitely need to make a deeper dive on linq. Added ability to filer by a single category but will need to add a filtered category property to Blog View Model to filter by multiple. Same will apply to tags if implemented.", new DateTime(2023, 5, 24, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Seven", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4585) },
                    { 8, "DEV", "Went back to single filter category but this time using a routing parameter. I think it's a better implementation as there is no need to keep this data saved in the model.", new DateTime(2023, 5, 26, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Eight", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4586) },
                    { 9, "DEV", "Set up Visual Studio for mac. Updated application to use SQLite instead of SQL Server. Consisted up udpdating the Builder.Services.AddDbContext method's options parameter to use SQLite, the connection string, and deleting all migrations files to build a new Initial migration. There could be a workaround to deleting the migrations files, the issue seems to be that SQLite does not like the 'max' option as a varchar parameter. After that, updating the database was succesful and the application worked.", new DateTime(2023, 6, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Nine", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4587) },
                    { 10, "DEV", "Back to windows development. Updated connection string, DI, rebuilt initial migration and database. Fixed the alignment issues between nav header and main content. Fixed single blog post layout for Index, Edit, & Delete.", new DateTime(2023, 6, 3, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Ten", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4588) },
                    { 11, "DEV", "Stared working on the Admin area in order to move some of the post/edit functionality to that area. Had some issues with the routing. The current area routing does not like it when I set up a controller/View in the admin area with the name of Home. Changing the name work. I'm sure this has something to do with routing but it's out of my knowledge scope at the moment. Added a form to the admin index page to create/edit posts. Updated Admin BlogPost controller to have create/edit post functionality. Removed the admin and new post placeholder links from home page. Moved the delete functionality to the admin area. Added AspNetCore.Identity functionality to require a log in to access the admin area. Created the Account Controller, LoginViewModel, & the Login view. Created the ConfigureIdentity class in order to seed admin user account data.", new DateTime(2023, 6, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Eleven", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4588) },
                    { 12, "DEV", "Plenned out final visual design of blog integrating design language from main website. Might introduce in phases in order to get this published asap.", new DateTime(2023, 6, 5, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Twelve", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4589) },
                    { 13, "DEV", "Added ChangePassword view model & view. Added ChangePassword get and post actions to Account controller. Ultimately adding the ability for admin(me) to udpate password since inital seed data will be readily viewable in GitHub. Fixed _viewStart to point to _MainLayout and removed the layour call from the first views I built.", new DateTime(2023, 6, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Thirteen", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4590) },
                    { 14, "DEV", "Moved the edit/delte single post buttoms from home page to single post view and they only appear if admin is logged in. Added paging, filtering, & sorting for the home page. But routing is an issue so I will have to revisit.", new DateTime(2023, 6, 7, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Fourteen", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4590) },
                    { 15, "DEV", "Did some research on routing prior to today and I was able to fix the single blogpost routing for all controllers including the admin area. Removed the grid data class added yesterday. After all it was not the best solution to page/sort the blog. Created a new Account controller in the Admin area in order to move the ChangePassword actions and view to the Admin area. Added custom css to control content width. Updated all views to use custom width. Updated MainLayout header and footer navigation: Moved brand to center, home link to left, and sign in/out to right. Moved link to change password to footer.", new DateTime(2023, 6, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Fifteen", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4594) },
                    { 16, "DEV", "Did some research on routing prior to today and I was able to fix the single blogpost routing for all controllers including the admin area. Removed the grid data class added yesterday. After all it was not the best solution to page/sort the blog. Created a new Account controller in the Admin area in order to move the ChangePassword actions and view to the Admin area. Added custom css to control content width. Updated all views to use custom width. Updated MainLayout header and footer navigation: Moved brand to center, home link to left, and sign in/out to right. Moved link to change password to footer.", new DateTime(2023, 6, 10, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Sixteen", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4595) }
                });
        }
    }
}
