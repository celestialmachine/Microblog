using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Microblog.Migrations
{
    public partial class daySixteenUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDate",
                value: new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedDate",
                value: new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedDate",
                value: new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedDate",
                value: new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedDate",
                value: new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedDate",
                value: new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedDate",
                value: new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 1, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4587) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 3, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Content", "CreatedDate", "UpdatedDate" },
                values: new object[] { "Stared working on the Admin area in order to move some of the post/edit functionality to that area. Had some issues with the routing. The current area routing does not like it when I set up a controller/View in the admin area with the name of Home. Changing the name work. I'm sure this has something to do with routing but it's out of my knowledge scope at the moment. Added a form to the admin index page to create/edit posts. Updated Admin BlogPost controller to have create/edit post functionality. Removed the admin and new post placeholder links from home page. Moved the delete functionality to the admin area. Added AspNetCore.Identity functionality to require a log in to access the admin area. Created the Account Controller, LoginViewModel, & the Login view. Created the ConfigureIdentity class in order to seed admin user account data.", new DateTime(2023, 6, 4, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedDate", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 12, "DEV", "Plenned out final visual design of blog integrating design language from main website. Might introduce in phases in order to get this published asap.", new DateTime(2023, 6, 5, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Twelve", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4589) },
                    { 13, "DEV", "Added ChangePassword view model & view. Added ChangePassword get and post actions to Account controller. Ultimately adding the ability for admin(me) to udpate password since inital seed data will be readily viewable in GitHub. Fixed _viewStart to point to _MainLayout and removed the layour call from the first views I built.", new DateTime(2023, 6, 6, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Thirteen", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4590) },
                    { 14, "DEV", "Moved the edit/delte single post buttoms from home page to single post view and they only appear if admin is logged in. Added paging, filtering, & sorting for the home page. But routing is an issue so I will have to revisit.", new DateTime(2023, 6, 7, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Fourteen", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4590) },
                    { 15, "DEV", "Did some research on routing prior to today and I was able to fix the single blogpost routing for all controllers including the admin area. Removed the grid data class added yesterday. After all it was not the best solution to page/sort the blog. Created a new Account controller in the Admin area in order to move the ChangePassword actions and view to the Admin area. Added custom css to control content width. Updated all views to use custom width. Updated MainLayout header and footer navigation: Moved brand to center, home link to left, and sign in/out to right. Moved link to change password to footer.", new DateTime(2023, 6, 9, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Fifteen", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4594) },
                    { 16, "DEV", "Did some research on routing prior to today and I was able to fix the single blogpost routing for all controllers including the admin area. Removed the grid data class added yesterday. After all it was not the best solution to page/sort the blog. Created a new Account controller in the Admin area in order to move the ChangePassword actions and view to the Admin area. Added custom css to control content width. Updated all views to use custom width. Updated MainLayout header and footer navigation: Moved brand to center, home link to left, and sign in/out to right. Moved link to change password to footer.", new DateTime(2023, 6, 10, 21, 0, 0, 0, DateTimeKind.Unspecified), "Microblog, day Sixteen", new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4595) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "UpdatedDate",
                value: new DateTime(2023, 6, 3, 20, 12, 35, 261, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDate",
                value: new DateTime(2023, 6, 3, 20, 12, 35, 261, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedDate",
                value: new DateTime(2023, 6, 3, 20, 12, 35, 261, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedDate",
                value: new DateTime(2023, 6, 3, 20, 12, 35, 261, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedDate",
                value: new DateTime(2023, 6, 3, 20, 12, 35, 261, DateTimeKind.Local).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedDate",
                value: new DateTime(2023, 6, 3, 20, 12, 35, 261, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedDate",
                value: new DateTime(2023, 6, 3, 20, 12, 35, 261, DateTimeKind.Local).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedDate",
                value: new DateTime(2023, 6, 3, 20, 12, 35, 261, DateTimeKind.Local).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 3, 20, 12, 35, 261, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 5, 26, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 3, 20, 12, 35, 261, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Content", "CreatedDate", "UpdatedDate" },
                values: new object[] { "Stared working on the Admin area in order to move some of the post/edit functionality to that area. Had some issues with the routing. The current area routing does not like it when I set up a controller/View in the admin area with the name of Home. Changing the name work. I'm sure this has something to do with routing but it's out of my knowledge scope at the moment. Added a form to the admin index page to create/edit posts. Updated Admin BlogPost controller to have create/edit post functionality. Removed the admin and new post placeholder links from home page. Moved the delete functionality to the admin area.", new DateTime(2023, 5, 26, 21, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 3, 20, 12, 35, 261, DateTimeKind.Local).AddTicks(4589) });
        }
    }
}
