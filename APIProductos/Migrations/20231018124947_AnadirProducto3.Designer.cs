﻿// <auto-generated />
using APIProductos.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APIProductos.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20231018124947_AnadirProducto3")]
    partial class AnadirProducto3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("APIProductos.Models.Producto", b =>
                {
                    b.Property<int>("IdProducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducto"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProducto");

                    b.ToTable("Producto");

                    b.HasData(
                        new
                        {
                            IdProducto = 1,
                            Cantidad = 12,
                            Descripcion = "Album Musical: ALternativo",
                            Nombre = "Scaled and Icy"
                        },
                        new
                        {
                            IdProducto = 2,
                            Cantidad = 2,
                            Descripcion = "Album Musical: Pop",
                            Nombre = "1989"
                        },
                        new
                        {
                            IdProducto = 3,
                            Cantidad = 2,
                            Descripcion = "Album Musical: Pop",
                            Nombre = "CALM"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
