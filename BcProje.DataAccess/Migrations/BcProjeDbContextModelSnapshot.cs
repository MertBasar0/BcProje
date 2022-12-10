﻿// <auto-generated />
using System;
using BcProje.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BcProje.DataAccess.Migrations
{
    [DbContext(typeof(BcProjeDbContext))]
    partial class BcProjeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

            modelBuilder.Entity("BcProje.Entities.Models.AnotherCompanyProduct", b =>
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

            modelBuilder.Entity("BcProje.Entities.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorName")
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

            modelBuilder.Entity("BcProje.Entities.Models.Employee", b =>
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

            modelBuilder.Entity("BcProje.Entities.Models.Product", b =>
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

            modelBuilder.Entity("BcProje.Entities.Models.Report", b =>
                {
                    b.Property<int>("ReportId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("VisitId")
                        .HasColumnType("int");

                    b.Property<string>("VisitNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("_Result")
                        .HasColumnType("int");

                    b.HasKey("ReportId");

                    b.HasIndex("VisitId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("BcProje.Entities.Models.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"), 1L, 1);

                    b.Property<decimal>("SaleCount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VisitId")
                        .HasColumnType("int");

                    b.HasKey("SaleId");

                    b.HasIndex("VisitId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("BcProje.Entities.Models.Visit", b =>
                {
                    b.Property<int>("VisitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitId"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("VisitId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("BcProje.Entities.SaleProduct", b =>
                {
                    b.Property<int>("SaleId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("SaleId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("SaleProducts");
                });

            modelBuilder.Entity("BcProje.Entities.CustomerProduct", b =>
                {
                    b.HasOne("BcProje.Entities.Models.Customer", "Customer")
                        .WithMany("CustomerProducts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BcProje.Entities.Models.Product", "Product")
                        .WithMany("CustomerProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BcProje.Entities.EmployeeCustomer", b =>
                {
                    b.HasOne("BcProje.Entities.Models.Customer", "Customer")
                        .WithMany("EmployeeCustomers")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BcProje.Entities.Models.Employee", "Employee")
                        .WithMany("EmployeeCustomers")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BcProje.Entities.Models.AnotherCompanyProduct", b =>
                {
                    b.HasOne("BcProje.Entities.Models.Customer", "Customer")
                        .WithMany("AnotherCompanyProducts")
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("BcProje.Entities.Models.Report", b =>
                {
                    b.HasOne("BcProje.Entities.Models.Visit", "Visit")
                        .WithMany("Reports")
                        .HasForeignKey("VisitId");

                    b.Navigation("Visit");
                });

            modelBuilder.Entity("BcProje.Entities.Models.Sale", b =>
                {
                    b.HasOne("BcProje.Entities.Models.Visit", "Visit")
                        .WithMany("Sale")
                        .HasForeignKey("VisitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Visit");
                });

            modelBuilder.Entity("BcProje.Entities.Models.Visit", b =>
                {
                    b.HasOne("BcProje.Entities.Models.Customer", "Customer")
                        .WithMany("Visits")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BcProje.Entities.Models.Employee", "Employee")
                        .WithMany("Visits")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("BcProje.Entities.SaleProduct", b =>
                {
                    b.HasOne("BcProje.Entities.Models.Product", "Product")
                        .WithMany("SaleProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BcProje.Entities.Models.Sale", "Sale")
                        .WithMany("SaleProducts")
                        .HasForeignKey("SaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Sale");
                });

            modelBuilder.Entity("BcProje.Entities.Models.Customer", b =>
                {
                    b.Navigation("AnotherCompanyProducts");

                    b.Navigation("CustomerProducts");

                    b.Navigation("EmployeeCustomers");

                    b.Navigation("Visits");
                });

            modelBuilder.Entity("BcProje.Entities.Models.Employee", b =>
                {
                    b.Navigation("EmployeeCustomers");

                    b.Navigation("Visits");
                });

            modelBuilder.Entity("BcProje.Entities.Models.Product", b =>
                {
                    b.Navigation("CustomerProducts");

                    b.Navigation("SaleProducts");
                });

            modelBuilder.Entity("BcProje.Entities.Models.Sale", b =>
                {
                    b.Navigation("SaleProducts");
                });

            modelBuilder.Entity("BcProje.Entities.Models.Visit", b =>
                {
                    b.Navigation("Reports");

                    b.Navigation("Sale");
                });
#pragma warning restore 612, 618
        }
    }
}