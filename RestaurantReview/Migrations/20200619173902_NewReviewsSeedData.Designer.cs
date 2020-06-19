﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantReview;

namespace RestaurantReview.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    [Migration("20200619173902_NewReviewsSeedData")]
    partial class NewReviewsSeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RestaurantReview.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Details = "Great pizza place",
                            LinkDescription = "Donatos Image",
                            LinkImage = "./images/Donatos-Pizza-restaurant-1200x900.jpg",
                            LinkUrl = "https://www.donatos.com",
                            Name = "Donato's"
                        },
                        new
                        {
                            Id = 2,
                            Details = "Like chipotle but 10x better",
                            LinkDescription = "Agave Image",
                            LinkImage = "./images/agave.jpg",
                            LinkUrl = "https://www.facebook.com/agaveburritobar/",
                            Name = "Agave"
                        },
                        new
                        {
                            Id = 3,
                            Details = "Really great seafood",
                            LinkDescription = "Pier W Image",
                            LinkImage = "./images/pierW.jpg",
                            LinkUrl = "http://pierw.com/",
                            Name = "Pier W"
                        });
                });

            modelBuilder.Entity("RestaurantReview.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Creator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Comment = " Pepporoni Pizza is awesome",
                            Creator = "Bernard",
                            RestaurantId = 1,
                            ReviewDate = new DateTime(2020, 6, 19, 13, 39, 1, 536, DateTimeKind.Local).AddTicks(4933)
                        },
                        new
                        {
                            Id = 2,
                            Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos",
                            Creator = "Brenda",
                            RestaurantId = 1,
                            ReviewDate = new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4134)
                        },
                        new
                        {
                            Id = 3,
                            Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos",
                            Creator = "Corey",
                            RestaurantId = 1,
                            ReviewDate = new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4233)
                        },
                        new
                        {
                            Id = 4,
                            Comment = " Their burritos were great!",
                            Creator = "Laurie",
                            RestaurantId = 2,
                            ReviewDate = new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4244)
                        },
                        new
                        {
                            Id = 5,
                            Comment = " Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos",
                            Creator = "Jay",
                            RestaurantId = 2,
                            ReviewDate = new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4249)
                        },
                        new
                        {
                            Id = 6,
                            Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos",
                            Creator = "Josh",
                            RestaurantId = 2,
                            ReviewDate = new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4255)
                        },
                        new
                        {
                            Id = 7,
                            Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos",
                            Creator = "Corey",
                            RestaurantId = 3,
                            ReviewDate = new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4260)
                        },
                        new
                        {
                            Id = 8,
                            Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed est quam, ornare sit amet pretium non, posuere rhoncus dui. Curabitur gravida risus eget risus scelerisque, eu tristique velit accumsan. Nam ligula purus, sagittis sed dolor vitae, posuere accumsan purus. Donec metus velit, commodo eu viverra in, lobortis ac diam. Suspendisse lacinia mi mauris, at ultrices dolor maximus eget. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos",
                            Creator = "John",
                            RestaurantId = 3,
                            ReviewDate = new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4265)
                        },
                        new
                        {
                            Id = 9,
                            Comment = "The seafood here is pretty ok for Lake Erie",
                            Creator = "Dakota",
                            RestaurantId = 3,
                            ReviewDate = new DateTime(2020, 6, 19, 13, 39, 1, 541, DateTimeKind.Local).AddTicks(4269)
                        });
                });

            modelBuilder.Entity("RestaurantReview.Models.Review", b =>
                {
                    b.HasOne("RestaurantReview.Models.Restaurant", "Restaurant")
                        .WithMany("Reviews")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
