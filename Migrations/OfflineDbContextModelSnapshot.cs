﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Offline_System;

#nullable disable

namespace Offline_System.Migrations
{
    [DbContext(typeof(OfflineDbContext))]
    partial class OfflineDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Offline_System.Models.Data.Departments", b =>
                {
                    b.Property<int>("DepartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartId"));

                    b.Property<int>("DepartActive")
                        .HasColumnType("int");

                    b.Property<string>("DepartName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartId");

                    b.ToTable("ContDepart");
                });

            modelBuilder.Entity("Offline_System.Models.Data.Employees", b =>
                {
                    b.Property<int>("EmployeesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeesID"));

                    b.Property<string>("EmployeesName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeesID");

                    b.ToTable("ContEmployee");
                });

            modelBuilder.Entity("Offline_System.Models.Data.Positions", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PositionId"));

                    b.Property<string>("PositionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PositionId");

                    b.ToTable("ContPos");
                });
#pragma warning restore 612, 618
        }
    }
}
