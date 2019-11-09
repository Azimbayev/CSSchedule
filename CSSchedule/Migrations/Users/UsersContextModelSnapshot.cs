﻿// <auto-generated />
using System;
using CSSchedule.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CSSchedule.Migrations.Users
{
    [DbContext(typeof(UsersContext))]
    partial class UsersContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099");

            modelBuilder.Entity("CSSchedule.Models.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Fullname");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, CreatedAt = new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), Fullname = "Azimbayev Edilzhan", Username = "edilzhan12" },
                        new { Id = 2, CreatedAt = new DateTime(2019, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), Fullname = "Azimbayeva Madina", Username = "mxmadina" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
