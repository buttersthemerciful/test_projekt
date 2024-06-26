﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Api.Context;

#nullable disable

namespace Shop.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shop.Api.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UserId")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = "1"
                        },
                        new
                        {
                            Id = 2,
                            UserId = "2"
                        });
                });

            modelBuilder.Entity("Shop.Api.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Shop.Api.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IconCSS")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconCSS = "fas fa-spa",
                            Name = "Beleza"
                        },
                        new
                        {
                            Id = 2,
                            IconCSS = "fas fa-couch",
                            Name = "Moveis"
                        },
                        new
                        {
                            Id = 3,
                            IconCSS = "fas fa-headphones",
                            Name = "Eletronicos"
                        },
                        new
                        {
                            Id = 4,
                            IconCSS = "fas fa-shoe-prints",
                            Name = "Calcados"
                        });
                });

            modelBuilder.Entity("Shop.Api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Um kit fornecido pela Natura, contendo Products para cuidados com a pele",
                            ImageUrl = "/Images/Beauty/Beleza1.png",
                            Name = "Glossier - Beleza Kit",
                            Price = 100m,
                            Total = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Um kit fornecido pela Curology, contendo Products para cuidados com a pele",
                            ImageUrl = "/Images/Beauty/Beleza2.png",
                            Name = "Curology - Kit para Pele",
                            Price = 50m,
                            Total = 45
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Um kit fornecido pela Glossier, contendo Products para cuidados com a pele",
                            ImageUrl = "/Images/Beauty/Beleza3.png",
                            Name = "Óleo de Coco Orgânico",
                            Price = 20m,
                            Total = 30
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Um kit fornecido pela Curology, contendo Products para cuidados com a pele",
                            ImageUrl = "/Images/Beauty/Beleza4.png",
                            Name = "Schwarzkopf - Kit de cuidados com a pele e cabelo",
                            Price = 50m,
                            Total = 60
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Kit de cuidados com a pele, contendo Products para cuidados com a pele e cabelos",
                            ImageUrl = "/Images/Beauty/Beleza5.png",
                            Name = "Kit de cuidados com a pele",
                            Price = 30m,
                            Total = 85
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "Air Pods - fones de ouvido sem fio intra-auriculares",
                            ImageUrl = "/Images/Electronics/eletronico1.png",
                            Name = "Fones de ouvidos",
                            Price = 100m,
                            Total = 120
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Fones de ouvido dourados na orelha - esses fones de ouvido não são sem fio",
                            ImageUrl = "/Images/Electronics/eletronico2.png",
                            Name = "Fones de ouvido dourados",
                            Price = 40m,
                            Total = 200
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Fones de ouvido pretos na orelha - esses fones de ouvido não são sem fio",
                            ImageUrl = "/Images/Electronics/eletronico3.png",
                            Name = "Fones de ouvido pretos",
                            Price = 40m,
                            Total = 300
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Câmera Digital Sennheiser - Câmera digital de alta qualidade fornecida pela Sennheiser - inclui tripé",
                            ImageUrl = "/Images/Electronics/eletronico4.png",
                            Name = "Câmera digital Sennheiser com tripé",
                            Price = 600m,
                            Total = 20
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "Canon Digital Camera - Câmera digital de alta qualidade fornecida pela Canon",
                            ImageUrl = "/Images/Electronics/eletronico5.png",
                            Name = "Câmera Digital Canon",
                            Price = 500m,
                            Total = 15
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "Gameboy - Fornecido por Nintendo",
                            ImageUrl = "/Images/Electronics/tecnologia6.png",
                            Name = "Nintendo Gameboy",
                            Price = 100m,
                            Total = 60
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "Cadeira de escritório em couro preto muito confortável",
                            ImageUrl = "/Images/Furniture/moveis1.png",
                            Name = "Cadeira de escritório de couro preto",
                            Price = 50m,
                            Total = 212
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "Cadeira de escritório em couro rosa muito confortável",
                            ImageUrl = "/Images/Furniture/moveis2.png",
                            Name = "Cadeira de escritório de couro rosa",
                            Price = 50m,
                            Total = 112
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Description = "Poltrona muito confortável",
                            ImageUrl = "/Images/Furniture/moveis3.png",
                            Name = "Espreguiçadeira",
                            Price = 70m,
                            Total = 90
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            Description = "Poltrona prateada muito confortável",
                            ImageUrl = "/Images/Furniture/moveis4.png",
                            Name = "Silver Lounge Chair",
                            Price = 120m,
                            Total = 95
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            Description = "Abajur de mesa de porcelana branco e azul",
                            ImageUrl = "/Images/Furniture/moveis6.png",
                            Name = "Luminária de mesa de porcelana",
                            Price = 15m,
                            Total = 100
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            Description = "Abajur de mesa de escritório",
                            ImageUrl = "/Images/Furniture/moveis7.png",
                            Name = "Office Table Lamp",
                            Price = 20m,
                            Total = 73
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            Description = "Tênis Puma confortáveis na maioria dos tamanhos",
                            ImageUrl = "/Images/Shoes/calcado1.png",
                            Name = "Tênis Puma",
                            Price = 100m,
                            Total = 50
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Description = "Tênis coloridos - disponíveis na maioria dos tamanhos",
                            ImageUrl = "/Images/Shoes/calcado2.png",
                            Name = "Tênis Colodiros",
                            Price = 150m,
                            Total = 60
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Description = "Tênis Nike azul - disponível na maioria dos tamanhos",
                            ImageUrl = "/Images/Shoes/calcado3.png",
                            Name = "Tênis Nike Azul",
                            Price = 200m,
                            Total = 70
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 4,
                            Description = "Treinadores Hummel coloridos - disponíveis na maioria dos tamanhos",
                            ImageUrl = "/Images/Shoes/calcado4.png",
                            Name = "Tênis Hummel Coloridos",
                            Price = 120m,
                            Total = 120
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            Description = "Tênis Nike vermelho - disponível na maioria dos tamanhos",
                            ImageUrl = "/Images/Shoes/calcado5.png",
                            Name = "Tênis Nike Vermelho",
                            Price = 200m,
                            Total = 100
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 4,
                            Description = "Sandálias Birkenstock - disponíveis na maioria dos tamanhos",
                            ImageUrl = "/Images/Shoes/calcado6.png",
                            Name = "Sandálidas Birkenstock",
                            Price = 50m,
                            Total = 150
                        });
                });

            modelBuilder.Entity("Shop.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Flavio"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Estela"
                        });
                });

            modelBuilder.Entity("Shop.Api.Entities.CartItem", b =>
                {
                    b.HasOne("Shop.Api.Entities.Cart", "Cart")
                        .WithMany("Items")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Shop.Api.Entities.Product", "Product")
                        .WithMany("Items")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Shop.Api.Entities.Product", b =>
                {
                    b.HasOne("Shop.Api.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Shop.Api.Entities.User", b =>
                {
                    b.HasOne("Shop.Api.Entities.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId");

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("Shop.Api.Entities.Cart", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Shop.Api.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Shop.Api.Entities.Product", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
