﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurant_Manage_Backened.Data;

#nullable disable

namespace Restaurant_Manage_Backened.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Restaurant_Manage_Backened.Models.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Bsbcode")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("account")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("Restaurant_Manage_Backened.Models.Designation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Designations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Administration"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Chef"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Waitstaff"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Janitor"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Dishwasher"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Manager"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Kitchenhand"
                        });
                });

            modelBuilder.Entity("Restaurant_Manage_Backened.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BankId")
                        .HasColumnType("int");

                    b.Property<int?>("DesignationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SuperId")
                        .HasColumnType("int");

                    b.Property<int>("TFN")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("doj")
                        .HasColumnType("datetime2");

                    b.Property<string>("emailaddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.HasIndex("DesignationId");

                    b.HasIndex("SuperId");

                    b.HasIndex("UserId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Restaurant_Manage_Backened.Models.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Other"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Kitchen"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Owner"
                        });
                });

            modelBuilder.Entity("Restaurant_Manage_Backened.Models.Super", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("account")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Supers");
                });

            modelBuilder.Entity("Restaurant_Manage_Backened.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Restaurant_Manage_Backened.Models.Employee", b =>
                {
                    b.HasOne("Restaurant_Manage_Backened.Models.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId");

                    b.HasOne("Restaurant_Manage_Backened.Models.Designation", "Designation")
                        .WithMany()
                        .HasForeignKey("DesignationId");

                    b.HasOne("Restaurant_Manage_Backened.Models.Super", "Super")
                        .WithMany()
                        .HasForeignKey("SuperId");

                    b.HasOne("Restaurant_Manage_Backened.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Bank");

                    b.Navigation("Designation");

                    b.Navigation("Super");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Restaurant_Manage_Backened.Models.Super", b =>
                {
                    b.HasOne("Restaurant_Manage_Backened.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
