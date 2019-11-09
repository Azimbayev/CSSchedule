﻿// <auto-generated />
using System;
using CSSchedule.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CSSchedule.Migrations
{
    [DbContext(typeof(MoviesContext))]
    [Migration("20191108204349_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("CSSchedule.Models.Movies.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Author");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Genre");

                    b.Property<string>("Name");

                    b.Property<string>("Poster");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new { Id = 1, Author = "Todd Phillips", CreatedAt = new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), Genre = "Crime , Drama , Thriller", Name = "Joker", Poster = "https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/joker_dabf394a-d4f2-4b68-90e2-011ed6b54012_poster.png?d=270x360&q=20" },
                        new { Id = 2, Author = "David Leitch", CreatedAt = new DateTime(2019, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), Genre = "Action , Adventure", Name = "Fast & Furious Presents: Hobbs & Shaw", Poster = "https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/fast-furious-presents-hobbs-shaw_14d1ab4f-c90c-46d1-9e04-f7d69f285ebd_poster.png?d=270x360&q=20" },
                        new { Id = 3, Author = "Jon Favreau", CreatedAt = new DateTime(2019, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), Genre = "Adventure , Animation , Drama , Family , Musical", Name = "The Lion King", Poster = "https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/the-lion-king_3904aadc-3a07-4836-892f-763b2dfdeea3_poster.png?d=270x360&q=20" },
                        new { Id = 4, Author = "Joachim Rønning", CreatedAt = new DateTime(2019, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), Genre = "Adventure , Family , Fantasy", Name = "Maleficent: Mistress of Evil", Poster = "https://dz7u9q3vpd4eo.cloudfront.net/admin-uploads/posters/mxt_movies_poster/maleficent-mistress-of-evil_c8507e61-a6b3-404d-b8c5-df6f74bc62be_poster.png?d=270x360&q=20" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
