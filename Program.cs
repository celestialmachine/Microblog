using Microblog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.Password.RequiredLength = 10;
}).AddEntityFrameworkStores<MicroblogContext>()
    .AddDefaultTokenProviders();


// Add EF Core Dependency Injection
// When working on windows
// connection string: "Server=(localdb)\\mssqllocaldb;Database=CMMicroblog;Trusted_Connection=True;MultipleActiveResultSets=true"
builder.Services.AddDbContext<MicroblogContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MicroblogContext")));

// When working on mac
// connection string: "Filename=Microblog.sqlite"
//builder.Services.AddDbContext<MicroblogContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("MicroblogContext")));

builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
    options.AppendTrailingSlash = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapAreaControllerRoute(
    name: "admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "SingleBlogPostView",
    pattern: "{controller=BlogPost}/{action=Index}/{id}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{FilterCategory?}");

app.Run();
