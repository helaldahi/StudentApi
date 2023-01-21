﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test.Data;

namespace Test.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210412205301_customer-img")]
    partial class customerimg
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("Test.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.Property<string>("lastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Test.Models.Gategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Gategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Drinks"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Books"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Food"
                        });
                });

            modelBuilder.Entity("Test.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Qantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.HasIndex("GategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Test.Models.Product", b =>
                {
                    b.HasOne("Test.Models.Customer", "customer")
                        .WithOne("Product")
                        .HasForeignKey("Test.Models.Product", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test.Models.Gategory", "Gategory")
                        .WithMany("Products")
                        .HasForeignKey("GategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");

                    b.Navigation("Gategory");
                });

            modelBuilder.Entity("Test.Models.Customer", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("Test.Models.Gategory", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
