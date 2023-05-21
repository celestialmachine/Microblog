using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Microblog.Migrations
{
    public partial class AddCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "BlogPosts");

            migrationBuilder.RenameColumn(
                name: "BlogPostId",
                table: "BlogPosts",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "BlogPosts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { "DEV", "Development" },
                    { "PRS", "Personal" },
                    { "TRV", "Travel" },
                    { "TST", "Test" }
                });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "UpdatedDate" },
                values: new object[] { "PRS", new DateTime(2023, 5, 17, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 15, 17, 38, 720, DateTimeKind.Local).AddTicks(7992) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Content", "CreatedDate", "UpdatedDate" },
                values: new object[] { "TRV", "Added EF Core. Added DBContext class(MicroblogContext) with starter seed data. Added EF Core dependency injection. Added bootstrap and supporting jQuery, popper. Added bootstrap and supporting scripts to _Layout. Added connection string. Created database using migrations. Added MicroblogContext to home controller to test mvc pattern. Quick render of data on home/index. Misspelled TagHelpers on _ViewImports and cried for an hour.", new DateTime(2023, 5, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 15, 17, 38, 720, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Content", "CreatedDate", "UpdatedDate" },
                values: new object[] { "DEV", "Tried to do an initial style of blog with bootstrap but not sure the results are the best. For something so simple I might just do my own styling. Or I need to learn more about bootstrap. Added new migration(TestContentMigration) to update blog content and titles. Added BlogPost controller with initial add, edit, delete requests. Added BlogPost Edit view.", new DateTime(2023, 5, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 20, 15, 17, 38, 720, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[] { 4, "TST", "Added BlogPost/Edit view content. Added BlogPost/Delete view page and content. Tested passing the model around. Updated button on BlogPost/Edit view to reflect if making new post or updating exhisting one.", new DateTime(2023, 5, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Four", new DateTime(2023, 5, 20, 15, 17, 38, 720, DateTimeKind.Local).AddTicks(8003) });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_CategoryId",
                table: "BlogPosts",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPosts_Categories_CategoryId",
                table: "BlogPosts",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPosts_Categories_CategoryId",
                table: "BlogPosts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_BlogPosts_CategoryId",
                table: "BlogPosts");

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "BlogPosts");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BlogPosts",
                newName: "BlogPostId");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: 1,
                columns: new[] { "Category", "CreatedDate", "UpdatedDate" },
                values: new object[] { "Personal", new DateTime(2023, 5, 19, 20, 19, 2, 56, DateTimeKind.Local).AddTicks(9605), new DateTime(2023, 5, 19, 20, 19, 2, 56, DateTimeKind.Local).AddTicks(9619) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: 2,
                columns: new[] { "Category", "Content", "CreatedDate", "UpdatedDate" },
                values: new object[] { "Development", "Added EF Core. Added DBContext class(MicroblogContext) with starter seed data. Added EF Core dependency injection. Added bootstrap and supporting jQuery, popper. Added bootstrap and supporting scripts to _Layout. Added connection string. Created database using migrations. Added mbcontext to home controller to test mvc pattern. Quick render of data on home/index. Misspelled TagHelpers on _ViewImports and cried for an hour.", new DateTime(2023, 5, 19, 20, 19, 2, 56, DateTimeKind.Local).AddTicks(9621), new DateTime(2023, 5, 19, 20, 19, 2, 56, DateTimeKind.Local).AddTicks(9621) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "BlogPostId",
                keyValue: 3,
                columns: new[] { "Category", "Content", "CreatedDate", "UpdatedDate" },
                values: new object[] { "Travel", "Tried to do an initial style of blog with bootstrap but not sure the results are the best. For something so simple I might just do my own styling.", new DateTime(2023, 5, 19, 20, 19, 2, 56, DateTimeKind.Local).AddTicks(9622), new DateTime(2023, 5, 19, 20, 19, 2, 56, DateTimeKind.Local).AddTicks(9623) });
        }
    }
}
