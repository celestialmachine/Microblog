﻿// <auto-generated />
using System;
using Microblog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Microblog.Migrations
{
    [DbContext(typeof(MicroblogContext))]
    [Migration("20230611042440_daySixteenUpdate")]
    partial class daySixteenUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microblog.Models.BlogPost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("BlogPosts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = "PRS",
                            Content = "Set up folder structure. Deleted starter files. Added own HomeController. Added BlogPost class. Added own /Home/Index.cshtml. Added own _layout. Added Tagg Helper to _ViewImports",
                            CreatedDate = new DateTime(2023, 5, 17, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Microblog, day one",
                            UpdatedDate = new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4570)
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = "TRV",
                            Content = "Added EF Core. Added DBContext class(MicroblogContext) with starter seed data. Added EF Core dependency injection. Added bootstrap and supporting jQuery, popper. Added bootstrap and supporting scripts to _Layout. Added connection string. Created database using migrations. Added MicroblogContext to home controller to test mvc pattern. Quick render of data on home/index. Misspelled TagHelpers on _ViewImports and cried for an hour.",
                            CreatedDate = new DateTime(2023, 5, 18, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Microblog, day two",
                            UpdatedDate = new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4580)
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = "DEV",
                            Content = "Tried to do an initial style of blog with bootstrap but not sure the results are the best. For something so simple I might just do my own styling. Or I need to learn more about bootstrap. Added new migration(TestContentMigration) to update blog content and titles. Added BlogPost controller with initial add, edit, delete requests. Added BlogPost Edit view.",
                            CreatedDate = new DateTime(2023, 5, 19, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Microblog, day three",
                            UpdatedDate = new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4581)
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = "TST",
                            Content = "Added BlogPost/Edit view content. Added BlogPost/Delete view page and content. Tested passing the model around. Updated button on BlogPost/Edit view to reflect if making new post or updating existing one. Added Category class. Foreign key for Category added to BlogPost class. Added Category to MicroBlog Context to seed data. Added migration and updated database. Edited view to reflect new category. Added lowercase URL routing with optional slug parameter. Added slug property to BlogPost class. Although slug may not be a good choice for blog content. Played around with routing but will get back to it when I sort by category and tags. Added admin area folders.",
                            CreatedDate = new DateTime(2023, 5, 20, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Microblog, day Four",
                            UpdatedDate = new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4583)
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = "DEV",
                            Content = "Added Admin Area starter files. Added link in home page to admin area. Did a nested three tier layout with _Layout holding shared <head> code, _MainLayout holding header and fotter, and then the other views nested within. Added bootstrap navigation bar. Added option scripts section to _layout that loads validation scripts for views that need it.",
                            CreatedDate = new DateTime(2023, 5, 21, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Microblog, day Five",
                            UpdatedDate = new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4584)
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = "DEV",
                            Content = "Added BlogViewModel class. Udpated HomeController Index action to return new BlogModelView as the model for the view. Updated Home/index to use BlogModelView as view model. Added single blog post view. Added Index action to BlogPost controller for single blog post view.",
                            CreatedDate = new DateTime(2023, 5, 22, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Microblog, day Six",
                            UpdatedDate = new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4585)
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = "DEV",
                            Content = "Gave another go at bootstrap after watching a couple of videos. I understoo it a lot better. Removed bootstrap files and supporting library files from solution and added links to get from a CDN instead. Updated libman.json file. Styled blog, very basic setup but cleaner. Used TempData to pass a message from the Blog Post Controller to the Home Controller in order to display a message showing that a post was either added or updated. Definitely need to make a deeper dive on linq. Added ability to filer by a single category but will need to add a filtered category property to Blog View Model to filter by multiple. Same will apply to tags if implemented.",
                            CreatedDate = new DateTime(2023, 5, 24, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Microblog, day Seven",
                            UpdatedDate = new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4585)
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = "DEV",
                            Content = "Went back to single filter category but this time using a routing parameter. I think it's a better implementation as there is no need to keep this data saved in the model.",
                            CreatedDate = new DateTime(2023, 5, 26, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Microblog, day Eight",
                            UpdatedDate = new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4586)
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = "DEV",
                            Content = "Set up Visual Studio for mac. Updated application to use SQLite instead of SQL Server. Consisted up udpdating the Builder.Services.AddDbContext method's options parameter to use SQLite, the connection string, and deleting all migrations files to build a new Initial migration. There could be a workaround to deleting the migrations files, the issue seems to be that SQLite does not like the 'max' option as a varchar parameter. After that, updating the database was succesful and the application worked.",
                            CreatedDate = new DateTime(2023, 6, 1, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Microblog, day Nine",
                            UpdatedDate = new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4587)
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = "DEV",
                            Content = "Back to windows development. Updated connection string, DI, rebuilt initial migration and database. Fixed the alignment issues between nav header and main content. Fixed single blog post layout for Index, Edit, & Delete.",
                            CreatedDate = new DateTime(2023, 6, 3, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Microblog, day Ten",
                            UpdatedDate = new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4588)
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = "DEV",
                            Content = "Stared working on the Admin area in order to move some of the post/edit functionality to that area. Had some issues with the routing. The current area routing does not like it when I set up a controller/View in the admin area with the name of Home. Changing the name work. I'm sure this has something to do with routing but it's out of my knowledge scope at the moment. Added a form to the admin index page to create/edit posts. Updated Admin BlogPost controller to have create/edit post functionality. Removed the admin and new post placeholder links from home page. Moved the delete functionality to the admin area. Added AspNetCore.Identity functionality to require a log in to access the admin area. Created the Account Controller, LoginViewModel, & the Login view. Created the ConfigureIdentity class in order to seed admin user account data.",
                            CreatedDate = new DateTime(2023, 6, 4, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Microblog, day Eleven",
                            UpdatedDate = new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4588)
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = "DEV",
                            Content = "Plenned out final visual design of blog integrating design language from main website. Might introduce in phases in order to get this published asap.",
                            CreatedDate = new DateTime(2023, 6, 5, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Microblog, day Twelve",
                            UpdatedDate = new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4589)
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = "DEV",
                            Content = "Added ChangePassword view model & view. Added ChangePassword get and post actions to Account controller. Ultimately adding the ability for admin(me) to udpate password since inital seed data will be readily viewable in GitHub. Fixed _viewStart to point to _MainLayout and removed the layour call from the first views I built.",
                            CreatedDate = new DateTime(2023, 6, 6, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Microblog, day Thirteen",
                            UpdatedDate = new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4590)
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = "DEV",
                            Content = "Moved the edit/delte single post buttoms from home page to single post view and they only appear if admin is logged in. Added paging, filtering, & sorting for the home page. But routing is an issue so I will have to revisit.",
                            CreatedDate = new DateTime(2023, 6, 7, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Microblog, day Fourteen",
                            UpdatedDate = new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4590)
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = "DEV",
                            Content = "Did some research on routing prior to today and I was able to fix the single blogpost routing for all controllers including the admin area. Removed the grid data class added yesterday. After all it was not the best solution to page/sort the blog. Created a new Account controller in the Admin area in order to move the ChangePassword actions and view to the Admin area. Added custom css to control content width. Updated all views to use custom width. Updated MainLayout header and footer navigation: Moved brand to center, home link to left, and sign in/out to right. Moved link to change password to footer.",
                            CreatedDate = new DateTime(2023, 6, 9, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Microblog, day Fifteen",
                            UpdatedDate = new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4594)
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = "DEV",
                            Content = "Did some research on routing prior to today and I was able to fix the single blogpost routing for all controllers including the admin area. Removed the grid data class added yesterday. After all it was not the best solution to page/sort the blog. Created a new Account controller in the Admin area in order to move the ChangePassword actions and view to the Admin area. Added custom css to control content width. Updated all views to use custom width. Updated MainLayout header and footer navigation: Moved brand to center, home link to left, and sign in/out to right. Moved link to change password to footer.",
                            CreatedDate = new DateTime(2023, 6, 10, 21, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Microblog, day Sixteen",
                            UpdatedDate = new DateTime(2023, 6, 10, 21, 24, 40, 274, DateTimeKind.Local).AddTicks(4595)
                        });
                });

            modelBuilder.Entity("Microblog.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "PRS",
                            Name = "Personal"
                        },
                        new
                        {
                            CategoryId = "DEV",
                            Name = "Development"
                        },
                        new
                        {
                            CategoryId = "TRV",
                            Name = "Travel"
                        },
                        new
                        {
                            CategoryId = "TST",
                            Name = "Test"
                        });
                });

            modelBuilder.Entity("Microblog.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microblog.Models.BlogPost", b =>
                {
                    b.HasOne("Microblog.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microblog.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microblog.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microblog.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microblog.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
