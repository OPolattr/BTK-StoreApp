﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreApp.Models;

#nullable disable

namespace StoreApp.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    partial class RepositoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("StoreApp.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductName = "Computer",
                            ProductPrice = 17000m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductName = "Keyboard",
                            ProductPrice = 1000m
                        },
                        new
                        {
                            ProductId = 3,
                            ProductName = "Mouse",
                            ProductPrice = 500m
                        },
                        new
                        {
                            ProductId = 4,
                            ProductName = "Monitor",
                            ProductPrice = 7000m
                        },
                        new
                        {
                            ProductId = 5,
                            ProductName = "Deck",
                            ProductPrice = 1500m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
