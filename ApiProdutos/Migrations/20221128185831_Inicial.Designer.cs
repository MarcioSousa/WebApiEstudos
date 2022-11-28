﻿// <auto-generated />
using ApiProdutos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiProdutos.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221128185831_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("ApiProdutos.Data.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Estoque")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<decimal>("Preco")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Estoque = 10,
                            Nome = "Caderno",
                            Preco = 7.95m
                        },
                        new
                        {
                            Id = 2,
                            Estoque = 30,
                            Nome = "Borracha",
                            Preco = 2.45m
                        },
                        new
                        {
                            Id = 3,
                            Estoque = 15,
                            Nome = "Estojo",
                            Preco = 6.25m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
