﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nlayer.Repository;

#nullable disable

namespace Nlayer.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220322174929_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Nlayer.Core.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Kalemler"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Silgiler"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Suluklar"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Çantalar"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Defterler"
                        });
                });

            modelBuilder.Entity("Nlayer.Core.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2022, 3, 22, 20, 49, 29, 537, DateTimeKind.Local).AddTicks(9584),
                            Name = "Kalem 1",
                            Price = 100m,
                            Stock = 30
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2022, 3, 22, 20, 49, 29, 537, DateTimeKind.Local).AddTicks(9593),
                            Name = "Silgi 1",
                            Price = 200m,
                            Stock = 40
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2022, 3, 22, 20, 49, 29, 537, DateTimeKind.Local).AddTicks(9594),
                            Name = "Suluk 1",
                            Price = 150m,
                            Stock = 20
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2022, 3, 22, 20, 49, 29, 537, DateTimeKind.Local).AddTicks(9595),
                            Name = "Çanta 1",
                            Price = 130m,
                            Stock = 10
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 5,
                            CreatedDate = new DateTime(2022, 3, 22, 20, 49, 29, 537, DateTimeKind.Local).AddTicks(9596),
                            Name = "Defter 1",
                            Price = 140m,
                            Stock = 50
                        });
                });

            modelBuilder.Entity("Nlayer.Core.ProductFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductFeatures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Kırmızı",
                            Height = 200,
                            ProductId = 1,
                            Width = 100
                        },
                        new
                        {
                            Id = 2,
                            Color = "Siyah",
                            Height = 200,
                            ProductId = 2,
                            Width = 10
                        },
                        new
                        {
                            Id = 3,
                            Color = "Beyaz",
                            Height = 200,
                            ProductId = 3,
                            Width = 100
                        },
                        new
                        {
                            Id = 4,
                            Color = "Mor",
                            Height = 200,
                            ProductId = 4,
                            Width = 100
                        },
                        new
                        {
                            Id = 5,
                            Color = "Lacivert",
                            Height = 200,
                            ProductId = 5,
                            Width = 100
                        });
                });

            modelBuilder.Entity("Nlayer.Core.Product", b =>
                {
                    b.HasOne("Nlayer.Core.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Nlayer.Core.ProductFeature", b =>
                {
                    b.HasOne("Nlayer.Core.Product", "Products")
                        .WithOne("ProductFeature")
                        .HasForeignKey("Nlayer.Core.ProductFeature", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Nlayer.Core.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Nlayer.Core.Product", b =>
                {
                    b.Navigation("ProductFeature");
                });
#pragma warning restore 612, 618
        }
    }
}