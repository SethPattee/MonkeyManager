﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonkeyManager.Data;

#nullable disable

namespace MonkeyManager.Migrations
{
    [DbContext(typeof(EmployeeManagerDbContext))]
    [Migration("20231017021759_AddTimestamp")]
    partial class AddTimestamp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MonkeyManager.Data.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Banana Counting"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sales"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Monkey Resources"
                        },
                        new
                        {
                            Id = 5,
                            Name = "IT"
                        });
                });

            modelBuilder.Entity("MonkeyManager.Data.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsDeveloper")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Emplyees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 5,
                            FirstName = "Funky",
                            IsDeveloper = true,
                            LastName = "Kong"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 3,
                            FirstName = "Donkey",
                            IsDeveloper = false,
                            LastName = "Kong"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 2,
                            FirstName = "Diddy",
                            IsDeveloper = false,
                            LastName = "Kong"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 4,
                            FirstName = "Cranky",
                            IsDeveloper = false,
                            LastName = "Kong"
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 3,
                            FirstName = "Dixie",
                            IsDeveloper = false,
                            LastName = "Kong"
                        },
                        new
                        {
                            Id = 6,
                            DepartmentId = 2,
                            FirstName = "Candy",
                            IsDeveloper = false,
                            LastName = "Kong"
                        },
                        new
                        {
                            Id = 7,
                            DepartmentId = 4,
                            FirstName = "Chunky",
                            IsDeveloper = false,
                            LastName = "Kong"
                        });
                });

            modelBuilder.Entity("MonkeyManager.Data.Models.Employee", b =>
                {
                    b.HasOne("MonkeyManager.Data.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MonkeyManager.Data.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
