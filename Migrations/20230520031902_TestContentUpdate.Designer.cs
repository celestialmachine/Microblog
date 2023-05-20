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
    [Migration("20230520031902_TestContentUpdate")]
    partial class TestContentUpdate
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
                    b.Property<int>("BlogPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogPostId"), 1L, 1);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BlogPostId");

                    b.ToTable("BlogPosts");

                    b.HasData(
                        new
                        {
                            BlogPostId = 1,
                            Category = "Personal",
                            Content = "Set up folder structure. Deleted starter files. Added own HomeController. Added BlogPost class. Added own /Home/Index.chtml. Added own _layout. Added Tagg Helper to _ViewImports",
                            CreatedDate = new DateTime(2023, 5, 19, 20, 19, 2, 56, DateTimeKind.Local).AddTicks(9605),
                            Title = "Microblog, day one",
                            UpdatedDate = new DateTime(2023, 5, 19, 20, 19, 2, 56, DateTimeKind.Local).AddTicks(9619)
                        },
                        new
                        {
                            BlogPostId = 2,
                            Category = "Development",
                            Content = "Added EF Core. Added DBContext class(MicroblogContext) with starter seed data. Added EF Core dependency injection. Added bootstrap and supporting jQuery, popper. Added bootstrap and supporting scripts to _Layout. Added connection string. Created database using migrations. Added mbcontext to home controller to test mvc pattern. Quick render of data on home/index. Misspelled TagHelpers on _ViewImports and cried for an hour.",
                            CreatedDate = new DateTime(2023, 5, 19, 20, 19, 2, 56, DateTimeKind.Local).AddTicks(9621),
                            Title = "Microblog, day two",
                            UpdatedDate = new DateTime(2023, 5, 19, 20, 19, 2, 56, DateTimeKind.Local).AddTicks(9621)
                        },
                        new
                        {
                            BlogPostId = 3,
                            Category = "Travel",
                            Content = "Tried to do an initial style of blog with bootstrap but not sure the results are the best. For something so simple I might just do my own styling.",
                            CreatedDate = new DateTime(2023, 5, 19, 20, 19, 2, 56, DateTimeKind.Local).AddTicks(9622),
                            Title = "Microblog, day three",
                            UpdatedDate = new DateTime(2023, 5, 19, 20, 19, 2, 56, DateTimeKind.Local).AddTicks(9623)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
