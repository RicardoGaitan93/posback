﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pos.Api.DataAccess;

namespace Pos.Api.DataAccess.Migrations
{
    [DbContext(typeof(PosDBContext))]
    [Migration("20200618022403_initialMigrationPOS")]
    partial class initialMigrationPOS
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pos.Api.DataAccess.Contracts.Entities.ProductEntity", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CantidadEnBodega")
                        .HasColumnType("int");

                    b.Property<int>("CantidadMaxima")
                        .HasColumnType("int");

                    b.Property<int>("CantidadMinima")
                        .HasColumnType("int");

                    b.Property<int>("CategoriaProducto")
                        .HasColumnType("int");

                    b.Property<int>("CodigoBarras")
                        .HasColumnType("int");

                    b.Property<string>("DescripcionProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdImpuesto")
                        .HasColumnType("int");

                    b.Property<string>("NombreProducto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoProducto")
                        .HasColumnType("int");

                    b.Property<int>("UnidadMedida")
                        .HasColumnType("int");

                    b.HasKey("IdProducto");

                    b.ToTable("Product");
                });
#pragma warning restore 612, 618
        }
    }
}