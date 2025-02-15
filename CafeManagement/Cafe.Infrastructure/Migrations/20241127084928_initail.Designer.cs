﻿// <auto-generated />
using System;
using Cafe.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Cafe.Infrastructure.Migrations
{
    [DbContext(typeof(CafeDbContext))]
    [Migration("20241127084928_initail")]
    partial class initail
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Cafe.Domain.Entities.CafeEmployeeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CafeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CafeId");

                    b.HasIndex("EmployeeId", "IsActive")
                        .IsUnique()
                        .HasFilter("[IsActive] = 1");

                    b.ToTable("CafeEmployees");
                });

            modelBuilder.Entity("Cafe.Domain.Entities.CafeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Cafes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c8f1c92a-1234-4e6d-915f-223344d4f73a"),
                            CreatedDate = new DateTime(2024, 11, 27, 8, 49, 28, 110, DateTimeKind.Utc).AddTicks(9199),
                            Description = "A cozy place with great coffee and pastries.",
                            IsActive = true,
                            Location = "123 Maple Street, Springfield",
                            Logo = "",
                            Name = "Su Cafe"
                        },
                        new
                        {
                            Id = new Guid("a8f3c92a-2345-4e6d-915f-223344d4f74b"),
                            CreatedDate = new DateTime(2024, 11, 27, 8, 49, 28, 110, DateTimeKind.Utc).AddTicks(9203),
                            Description = "Modern cafe serving organic coffee and teas.",
                            IsActive = true,
                            Location = "456 Oak Avenue, Riverdale",
                            Logo = "",
                            Name = "City Brew"
                        },
                        new
                        {
                            Id = new Guid("d9e4c92a-3456-4e6d-915f-223344d4f75c"),
                            CreatedDate = new DateTime(2024, 11, 27, 8, 49, 28, 110, DateTimeKind.Utc).AddTicks(9204),
                            Description = "Vegan-friendly cafe with a range of smoothies.",
                            IsActive = true,
                            Location = "789 Pine Road, Sunnyvale",
                            Logo = "",
                            Name = "Green Leaf"
                        });
                });

            modelBuilder.Entity("Cafe.Domain.Entities.EmployeeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a1b2c3d4-e5f6-7890-1234-56789abcdef0"),
                            CreatedDate = new DateTime(2024, 11, 27, 8, 49, 28, 110, DateTimeKind.Utc).AddTicks(9208),
                            EmailAddress = "john.doe@gmail.com",
                            EmployeeId = "UI0000001",
                            Gender = 0,
                            IsActive = true,
                            Name = "John",
                            PhoneNumber = "88888884"
                        },
                        new
                        {
                            Id = new Guid("b2c3d4e5-f6a7-8901-2345-67890abcdef1"),
                            CreatedDate = new DateTime(2024, 11, 27, 8, 49, 28, 110, DateTimeKind.Utc).AddTicks(9211),
                            EmailAddress = "jane.smith@gmail.com",
                            EmployeeId = "UI0000002",
                            Gender = 1,
                            IsActive = true,
                            Name = "Smith",
                            PhoneNumber = "88888885"
                        },
                        new
                        {
                            Id = new Guid("c3d4e5f6-a7b8-9012-3456-7890abcdef12"),
                            CreatedDate = new DateTime(2024, 11, 27, 8, 49, 28, 110, DateTimeKind.Utc).AddTicks(9213),
                            EmailAddress = "alex.johnson@gmail.com",
                            EmployeeId = "UI0000003",
                            Gender = 0,
                            IsActive = true,
                            Name = "Alex",
                            PhoneNumber = "88888886"
                        },
                        new
                        {
                            Id = new Guid("d4e5f6a7-b8c9-0123-4567-890abcdef123"),
                            CreatedDate = new DateTime(2024, 11, 27, 8, 49, 28, 110, DateTimeKind.Utc).AddTicks(9215),
                            EmailAddress = "emily.davis@gmail.com",
                            EmployeeId = "UI0000004",
                            Gender = 1,
                            IsActive = true,
                            Name = "Emily",
                            PhoneNumber = "88888887"
                        },
                        new
                        {
                            Id = new Guid("e5f6a7b8-c9d0-1234-5678-90abcdef1234"),
                            CreatedDate = new DateTime(2024, 11, 27, 8, 49, 28, 110, DateTimeKind.Utc).AddTicks(9217),
                            EmailAddress = "daniel.brown@gmail.com",
                            EmployeeId = "UI0000005",
                            Gender = 0,
                            IsActive = true,
                            Name = "Daniel",
                            PhoneNumber = "88888888"
                        });
                });

            modelBuilder.Entity("Cafe.Domain.Entities.CafeEmployeeEntity", b =>
                {
                    b.HasOne("Cafe.Domain.Entities.CafeEntity", "CafeEntity")
                        .WithMany("CafeEmployees")
                        .HasForeignKey("CafeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cafe.Domain.Entities.EmployeeEntity", "EmployeeEntity")
                        .WithMany("CafeEmployees")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CafeEntity");

                    b.Navigation("EmployeeEntity");
                });

            modelBuilder.Entity("Cafe.Domain.Entities.CafeEntity", b =>
                {
                    b.Navigation("CafeEmployees");
                });

            modelBuilder.Entity("Cafe.Domain.Entities.EmployeeEntity", b =>
                {
                    b.Navigation("CafeEmployees");
                });
#pragma warning restore 612, 618
        }
    }
}
