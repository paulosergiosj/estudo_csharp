﻿// <auto-generated />
using System;
using AspNetMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNetMVC.Migrations
{
    [DbContext(typeof(AspNetMVCContext))]
    partial class AspNetMVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AspNetMVC.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("AspNetMVC.Models.SalesRecord", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int>("SellerID");

                    b.Property<int>("Status");

                    b.HasKey("ID");

                    b.HasIndex("SellerID");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("AspNetMVC.Models.Seller", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("DepartmentID");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("AspNetMVC.Models.SalesRecord", b =>
                {
                    b.HasOne("AspNetMVC.Models.Seller", "Seller")
                        .WithMany("Sales")
                        .HasForeignKey("SellerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AspNetMVC.Models.Seller", b =>
                {
                    b.HasOne("AspNetMVC.Models.Department", "Department")
                        .WithMany("Sellers")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
