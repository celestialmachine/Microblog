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
                    Title = "Learning .NET: A Beginner’s Guide",
                    Content = "Sure! Here's a blog post about learning .NET:\r\n\r\n**Learning .NET: A Beginner's Guide**\r\n\r\n.NET is a powerful and versatile framework that can be used to develop a wide range of applications, including web, mobile, desktop, and cloud-based solutions. If you're interested in learning .NET, here are some steps you can follow to get started:\r\n\r\n1. **Choose a language**: .NET supports multiple programming languages, including C#, F#, and Visual Basic. C# is the most popular language for .NET development, so it's a good choice for beginners.\r\n\r\n2. **Install the .NET SDK**: The .NET SDK (Software Development Kit) includes everything you need to start developing .NET applications. You can download it from the official .NET website.\r\n\r\n3. **Learn the basics**: Once you have the .NET SDK installed and have chosen a language to work with, it's time to start learning the basics. There are many resources available online to help you learn the fundamentals of .NET development, including tutorials, documentation, and video courses.\r\n\r\n4. **Practice**: The best way to learn is by doing. Try building some simple applications to practice your skills and reinforce your understanding of the concepts you've learned.\r\n\r\n5. **Join the community**: The .NET community is large and active, with many resources available to help you learn and grow as a developer. Join online forums, attend meetups or conferences, and connect with other developers to share knowledge and learn from each other.\r\n\r\nBy following these steps and dedicating time to learning and practicing, you'll be well on your way to becoming a skilled .NET developer.\r\n\r\nIs there anything else you would like me to include in this blog post?",
                    CreatedDate = new DateTime(2023, 5, 17, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    CategoryId = "PRS"
                },
                new BlogPost
                {
                    Id = 2,
                    Title = "How I Successfully Developed a Blog Website Using .NET",
                    Content = "Developing a blog website using .NET can be a rewarding experience. In this post, I’ll share my journey of how I successfully developed a blog website using .NET.\r\n\r\nPlanning: Before starting any development work, it’s important to plan out the project. I spent time researching and deciding on the features and functionality I wanted to include in my blog website.\r\n\r\nChoosing the right tools: .NET offers a wide range of tools and technologies for web development. I chose to use ASP.NET Core for my blog website because it’s a modern, fast, and scalable framework.\r\n\r\nDesigning the architecture: With the features and tools decided, I designed the architecture of my blog website. This included deciding on the data models, database design, and overall structure of the application.\r\n\r\nImplementing the features: With the architecture in place, I started implementing the features of my blog website. This included creating the user interface, setting up authentication and authorization, and implementing the core functionality such as creating and managing blog posts.\r\n\r\nTesting and debugging: As with any development project, testing and debugging were an important part of the process. I tested my blog website thoroughly to ensure that everything was working as expected and fixed any issues that arose.\r\n\r\nDeploying: Once everything was tested and working correctly, I deployed my blog website to a hosting provider. This made it accessible to the public and allowed me to start sharing my content with the world.\r\n\r\nDeveloping a blog website using .NET was a challenging but rewarding experience. By following a structured approach and using the right tools and technologies, I was able to successfully create a functional and attractive blog website.\r\n\r\nIs there anything else you would like me to include in this blog post?",
                    CreatedDate = new DateTime(2023, 5, 18, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    CategoryId = "TRV"
                },
                new BlogPost
                {
                    Id = 3,
                    Title = "Setting Up an ASP.NET MVC Project in Visual Studio: A Step-by-Step Guide",
                    Content = "ASP.NET MVC is a popular framework for building web applications using the Model-View-Controller (MVC) design pattern. In this post, we’ll go through the steps needed to set up an ASP.NET MVC project in Visual Studio.\r\n\r\nInstall Visual Studio: If you don’t already have Visual Studio installed, you’ll need to download and install it. You can download the Community edition for free from the official Visual Studio website.\r\n\r\nCreate a new project: Once you have Visual Studio installed, open it and create a new project. Select File > New > Project... from the menu, then choose ASP.NET Web Application (.NET Framework) from the list of templates.\r\n\r\nChoose the MVC template: After selecting the ASP.NET Web Application (.NET Framework) template, you’ll be prompted to choose a specific template for your project. Choose the MVC template and click OK.\r\n\r\nConfigure the project: After choosing the MVC template, you’ll be taken to the New ASP.NET Web Application dialog. Here you can configure various settings for your project, such as authentication options and target framework version. Make any changes as needed and click OK to create the project.\r\n\r\nExplore the project: Once the project is created, take some time to explore it and familiarize yourself with its structure. You’ll see that Visual Studio has automatically generated several files and folders for you, including controllers, views, and models.\r\n\r\nBy following these steps, you’ll have successfully set up an ASP.NET MVC project in Visual Studio and will be ready to start developing your web application.\r\n\r\nIs there anything else you would like me to include in this blog post?",
                    CreatedDate = new DateTime(2023, 5, 19, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    CategoryId = "DEV"
                },
                new BlogPost
                {
                    Id = 4,
                    Title = "The Advantages of Entity Framework Core",
                    Content = "Sure! Here's a blog post about the advantages of Entity Framework (EF) Core as opposed to other frameworks:\r\n\r\n**The Advantages of Entity Framework Core**\r\n\r\nEntity Framework (EF) Core is a modern, lightweight, extensible, and cross-platform version of the popular Entity Framework data access technology. It serves as an object-relational mapper (O/RM), enabling .NET developers to work with a database using .NET objects and eliminating the need for most of the data-access code that typically needs to be written ².\r\n\r\nSome of the advantages of EF Core include:\r\n\r\n- **Support for multiple database engines**: EF Core supports many database engines, including SQL Server/Azure SQL Database, SQLite, Azure Cosmos DB, MySQL, PostgreSQL, and many more through a database provider plugin model ³.\r\n\r\n- **LINQ support**: EF Core allows developers to write LINQ (Language Integrated Query) queries to work with data using objects of domain-specific classes instead of the underlying database tables and columns where this data is stored ¹.\r\n\r\n- **Reduced development time and cost**: EF Core provides auto-generated code and allows developers to visually design models and mapping of databases. This can help reduce development time and cost ⁴.\r\n\r\n- **Unit of Work implementation**: EF Core provides Unit of Work (UOW) implementation out of the box ¹.\r\n\r\n- **Data binding friendly**: EF Core is data binding friendly ¹.\r\n\r\n- **Fast CRUD operations**: EF Core helps to perform fast CRUD (Create, Read, Update, Delete) operations in .NET applications ¹.\r\n\r\nThese are just some of the many advantages that EF Core offers over other frameworks. Its versatility and ease-of-use make it a popular choice for .NET developers.\r\n\r\nIs there anything else you would like me to include in this blog post?\r\n\r\nSource: Conversation with Bing, 6/20/2023\r\n(1) Overview of Entity Framework Core - EF Core | Microsoft Learn. https://learn.microsoft.com/en-us/ef/core/.\r\n(2) Compare EF6 and EF Core | Microsoft Learn. https://learn.microsoft.com/en-us/ef/efcore-and-ef6/.\r\n(3) Intro to Entity Framework Core 5 - New features - DEV Community. https://dev.to/moe23/intro-to-entity-framework-core-5-new-features-1kle.\r\n(4) Advantages and Disadvantages of Entity Framework - Cybarlab. https://cybarlab.com/advantages-and-disadvantages-of-ef.",
                    CreatedDate = new DateTime(2023, 5, 20, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    CategoryId = "TST"
                },
                new BlogPost
                {
                    Id = 5,
                    Title = "Using Bootstrap in .NET MVC Applications: A Simple Guide",
                    Content = "Sure! Here's a blog post about how easy it is to integrate Bootstrap in a .NET MVC application:\r\n\r\nIntegrating Bootstrap in a .NET MVC application is a straightforward process. There are several ways to do this, but one of the easiest ways is to use the Library Manager (Libman) in Visual Studio. You can right-click on your project name in the Solution Explorer, then select “Add > Client-Side Library” which will open the “Add Client-Side Library” window³.\r\n\r\nAnother way to integrate Bootstrap into your .NET MVC application is to download the Bootstrap files from their website and add them to your project manually. You can then include the necessary CSS and JavaScript files in your views or layout pages⁴.\r\n\r\nYou can also use NuGet or NPM to install Bootstrap in your .NET MVC application².\r\n\r\nI hope this helps! Let me know if you need more information.\r\n\r\nSource: Conversation with Bing, 6/20/2023\r\n(1) How to Install Bootstrap in ASP.NET Core MVC. https://dotnettutorials.net/lesson/how-to-install-bootstrap-in-asp-net-core/.\r\n(2) Bootstrap with ASP.NET MVC 4 – Step by Step - My Tec Bits. https://www.mytecbits.com/microsoft/dot-net/bootstrap-with-asp-net-mvc-4-step-by-step.\r\n(3) Installing Bootstrap in an ASP.NET MVC App - Stack Overflow. https://stackoverflow.com/questions/59563756/installing-bootstrap-in-an-asp-net-mvc-app.\r\n(4) ASP .Net MVC Web Application integrating bootstrap templates. https://stackoverflow.com/questions/26041853/asp-net-mvc-web-application-integrating-bootstrap-templates.\r\n(5) ASP.NET MVC: Customizing Bootstrap Templates. https://social.technet.microsoft.com/wiki/contents/articles/37157.asp-net-mvc-customizing-bootstrap-templates.aspx.",
                    CreatedDate = new DateTime(2023, 5, 21, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    CategoryId = "DEV"
                },
                new BlogPost
                {
                    Id = 6,
                    Title = "ASP.NET Identity",
                    Content = "Sure! Here's a blog post about the advantages of using ASP.NET Identity:\r\n\r\nASP.NET Identity is an API that supports user interface (UI) login functionality and manages users, passwords, profile data, roles, claims, tokens, email confirmation, and more. Users can create an account with the login information stored in Identity or they can use an external login provider. Supported external login providers include Facebook, Google, Microsoft Account, and Twitter².\r\n\r\nSome of the advantages of using ASP.NET Identity include:\r\n- Separation of storage\r\n- Asynchronous APIs\r\n- Custom password hashing using UserManager APIs with the help of IPasswordHasher interface\r\n- Support for any types of external login provider like Facebook, Google, etc. to authenticate the user details\r\n- Supports all types of ASP.NET applications like Web Forms, MVC, Web API, SignalR or web pages\r\n- Easy to customize\r\n- Designed based on interfaces which means highly customizable\r\n- Highly testable\r\n- Default implementation uses Entity Framework code first\r\n- By default, system uses SQL Server database¹\r\n\r\nI hope this helps! Let me know if you need more information.\r\n\r\nSource: Conversation with Bing, 6/20/2023\r\n(1) Introduction to Identity on ASP.NET Core | Microsoft Learn. https://learn.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-7.0.\r\n(2) How To Implement Authentication Using Identity Model In ASP.NET Core. https://www.c-sharpcorner.com/article/how-to-implement-authentication-using-identity-model-in-asp-net-core/.\r\n(3) ASP.NET Identity vs Simple membership Pros and Cons?. https://stackoverflow.com/questions/21207246/asp-net-identity-vs-simple-membership-pros-and-cons.\r\n(4) Introduction to ASP.NET Identity - ASP.NET 4.x | Microsoft Learn. https://learn.microsoft.com/en-us/aspnet/identity/overview/getting-started/introduction-to-aspnet-identity.",
                    CreatedDate = new DateTime(2023, 5, 22, 21, 0, 0),
                    UpdatedDate = DateTime.Now,
                    CategoryId = "DEV"
                }
            );
        }
    }
}
