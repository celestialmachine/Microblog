using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Microblog.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    Content = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CategoryId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogPosts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { "DEV", "Development" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { "PRS", "Personal" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { "TRV", "Travel" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { "TST", "Test" });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { 1, "PRS", "Set up folder structure. Deleted starter files. Added own HomeController. Added BlogPost class. Added own /Home/Index.cshtml. Added own _layout. Added Tagg Helper to _ViewImports", new DateTime(2023, 5, 17, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day one", new DateTime(2023, 5, 30, 20, 21, 18, 19, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { 2, "TRV", "Added EF Core. Added DBContext class(MicroblogContext) with starter seed data. Added EF Core dependency injection. Added bootstrap and supporting jQuery, popper. Added bootstrap and supporting scripts to _Layout. Added connection string. Created database using migrations. Added MicroblogContext to home controller to test mvc pattern. Quick render of data on home/index. Misspelled TagHelpers on _ViewImports and cried for an hour.", new DateTime(2023, 5, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day two", new DateTime(2023, 5, 30, 20, 21, 18, 19, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { 3, "DEV", "Tried to do an initial style of blog with bootstrap but not sure the results are the best. For something so simple I might just do my own styling. Or I need to learn more about bootstrap. Added new migration(TestContentMigration) to update blog content and titles. Added BlogPost controller with initial add, edit, delete requests. Added BlogPost Edit view.", new DateTime(2023, 5, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day three", new DateTime(2023, 5, 30, 20, 21, 18, 19, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { 4, "TST", "Added BlogPost/Edit view content. Added BlogPost/Delete view page and content. Tested passing the model around. Updated button on BlogPost/Edit view to reflect if making new post or updating existing one. Added Category class. Foreign key for Category added to BlogPost class. Added Category to MicroBlog Context to seed data. Added migration and updated database. Edited view to reflect new category. Added lowercase URL routing with optional slug parameter. Added slug property to BlogPost class. Although slug may not be a good choice for blog content. Played around with routing but will get back to it when I sort by category and tags. Added admin area folders.", new DateTime(2023, 5, 20, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Four", new DateTime(2023, 5, 30, 20, 21, 18, 19, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { 5, "DEV", "Added Admin Area starter files. Added link in home page to admin area. Did a nested three tier layout with _Layout holding shared <head> code, _MainLayout holding header and fotter, and then the other views nested within. Added bootstrap navigation bar. Added option scripts section to _layout that loads validation scripts for views that need it.", new DateTime(2023, 5, 21, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Five", new DateTime(2023, 5, 30, 20, 21, 18, 19, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { 6, "DEV", "Added BlogViewModel class. Udpated HomeController Index action to return new BlogModelView as the model for the view. Updated Home/index to use BlogModelView as view model. Added single blog post view. Added Index action to BlogPost controller for single blog post view.", new DateTime(2023, 5, 22, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Six", new DateTime(2023, 5, 30, 20, 21, 18, 19, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { 7, "DEV", "Gave another go at bootstrap after watching a couple of videos. I understoo it a lot better. Removed bootstrap files and supporting library files from solution and added links to get from a CDN instead. Updated libman.json file. Styled blog, very basic setup but cleaner. Used TempData to pass a message from the Blog Post Controller to the Home Controller in order to display a message showing that a post was either added or updated. Definitely need to make a deeper dive on linq. Added ability to filer by a single category but will need to add a filtered category property to Blog View Model to filter by multiple. Same will apply to tags if implemented.", new DateTime(2023, 5, 24, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Seven", new DateTime(2023, 5, 30, 20, 21, 18, 19, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { 8, "DEV", "Went back to single filter category but this time using a routing parameter. I think it's a better implementation as there is no need to keep this data saved in the model.", new DateTime(2023, 5, 26, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Eight", new DateTime(2023, 5, 30, 20, 21, 18, 19, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_CategoryId",
                table: "BlogPosts",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
