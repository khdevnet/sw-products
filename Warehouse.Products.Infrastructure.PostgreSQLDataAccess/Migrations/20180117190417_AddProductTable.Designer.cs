﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using Warehouse.Products.Infrastructure.PostgreSQLDataAccess.Database;

namespace Warehouse.Products.Infrastructure.PostgreSQLDataAccess.Migrations
{
    [DbContext(typeof(ProductDbContext))]
    [Migration("20180117190417_AddProductTable")]
    partial class AddProductTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("Warehouse.Products.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("Count")
                        .HasColumnName("count");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(255);

                    b.Property<decimal>("Price")
                        .HasColumnName("price");

                    b.Property<string>("Sku")
                        .HasColumnName("sku")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Sku")
                        .IsUnique();

                    b.ToTable("product");
                });
#pragma warning restore 612, 618
        }
    }
}
