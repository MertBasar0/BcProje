﻿// <auto-generated />
using System;
using BcProje.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BcProje.DataAccess.Migrations
{
    [DbContext(typeof(BcProjeDbContext))]
    [Migration("20221009182422_MigSix")]
    partial class MigSix
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BcProje.Entities.AnotherCompanyProduct", b =>
                {
                    b.Property<int>("AnotherProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnotherProductId"), 1L, 1);

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("AnotherProductId");

                    b.HasIndex("CustomerId");

                    b.ToTable("AnotherCompanyProducts");
                });

            modelBuilder.Entity("BcProje.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GeneralManager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaleManager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UnitCount")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BcProje.Entities.CustomerProduct", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CustomerProducts");
                });

            modelBuilder.Entity("BcProje.Entities.DTO_s.CompositeKeyTables.SoldEmployee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "SaleId");

                    b.HasIndex("SaleId");

                    b.ToTable("SoldEmployees");
                });

            modelBuilder.Entity("BcProje.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BcProje.Entities.EmployeeCustomer", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "CustomerId");

                    b.HasIndex("CustomerId");

                    b.ToTable("EmployeeCustomers");
                });

            modelBuilder.Entity("BcProje.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("BcProje.Entities.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<decimal>("SaleCount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SaleId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("BcProje.Entities.SoldProduct", b =>
                {
                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("SaleId", "ProductId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProductId");

                    b.ToTable("soldProducts");
                });

            modelBuilder.Entity("BcProje.Entities.AnotherCompanyProduct", b =>
                {
                    b.HasOne("BcProje.Entities.Customer", "Customer")
                        .WithMany("AnotherCompanyProducts")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BcProje.Entities.CustomerProduct", b =>
                {
                    b.HasOne("BcProje.Entities.Customer", "Customer")
                        .WithMany("CustomerProducts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BcProje.Entities.Product", "Product")
                        .WithMany("CustomerProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BcProje.Entities.DTO_s.CompositeKeyTables.SoldEmployee", b =>
                {
                    b.HasOne("BcProje.Entities.Employee", "Employee")
                        .WithMany("SoldEmployees")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BcProje.Entities.Sale", "Sale")
                        .WithMany("SoldEmployees")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("BcProje.Entities.EmployeeCustomer", b =>
                {
                    b.HasOne("BcProje.Entities.Customer", "Customer")
                        .WithMany("EmployeeCustomers")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BcProje.Entities.Employee", "Employee")
                        .WithMany("EmployeeCustomers")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BcProje.Entities.Sale", b =>
                {
                    b.HasOne("BcProje.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BcProje.Entities.SoldProduct", b =>
                {
                    b.HasOne("BcProje.Entities.Employee", null)
                        .WithMany("SoldProducts")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("BcProje.Entities.Product", "Product")
                        .WithMany("SoldProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BcProje.Entities.Sale", "Sale")
                        .WithMany("SoldProducts")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("BcProje.Entities.Customer", b =>
                {
                    b.Navigation("AnotherCompanyProducts");

                    b.Navigation("CustomerProducts");

                    b.Navigation("EmployeeCustomers");
                });

            modelBuilder.Entity("BcProje.Entities.Employee", b =>
                {
                    b.Navigation("EmployeeCustomers");

                    b.Navigation("SoldEmployees");

                    b.Navigation("SoldProducts");
                });

            modelBuilder.Entity("BcProje.Entities.Product", b =>
                {
                    b.Navigation("CustomerProducts");

                    b.Navigation("SoldProducts");
                });

            modelBuilder.Entity("BcProje.Entities.Sale", b =>
                {
                    b.Navigation("SoldEmployees");

                    b.Navigation("SoldProducts");
                });
#pragma warning restore 612, 618
        }
    }
}