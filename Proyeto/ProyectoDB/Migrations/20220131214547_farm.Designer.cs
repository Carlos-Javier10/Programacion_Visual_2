﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoDB;

namespace ProyectoDB.Migrations
{
    [DbContext(typeof(Conexion))]
    [Migration("20220131214547_farm")]
    partial class farm
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proyecto.Entidades.Boleta", b =>
                {
                    b.Property<int>("num_boleta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("num_OrdenPedido")
                        .HasColumnType("int");

                    b.Property<decimal>("sub_Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("num_boleta");

                    b.HasIndex("num_OrdenPedido");

                    b.ToTable("Boletas");
                });

            modelBuilder.Entity("Proyecto.Entidades.Categoria", b =>
                {
                    b.Property<int>("cod_Categoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nom_Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cod_Categoria");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Proyecto.Entidades.Cliente", b =>
                {
                    b.Property<int>("cod_Cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DNI")
                        .HasColumnType("int");

                    b.Property<long>("RUC")
                        .HasColumnType("bigint");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<int>("cod_Distrito")
                        .HasColumnType("int");

                    b.Property<string>("direc_Cliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom_Clinete")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sexo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cod_Cliente");

                    b.HasIndex("cod_Distrito");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Proyecto.Entidades.DetalleOrdenPedido", b =>
                {
                    b.Property<int>("num_OrdenPedido")
                        .HasColumnType("int");

                    b.Property<int>("Catidad")
                        .HasColumnType("int");

                    b.Property<int>("cod_Prodructo")
                        .HasColumnType("int");

                    b.Property<decimal>("importe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("precio_venta")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("num_OrdenPedido");

                    b.ToTable("DetalleOrdenPedidos");
                });

            modelBuilder.Entity("Proyecto.Entidades.Distrito", b =>
                {
                    b.Property<int>("cod_Distrito")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nom_Distrito")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cod_Distrito");

                    b.ToTable("Distritos");
                });

            modelBuilder.Entity("Proyecto.Entidades.Empleado", b =>
                {
                    b.Property<int>("cod_Empleado")
                        .HasColumnType("int");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Clave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Edad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ingreso")
                        .HasColumnType("datetime2");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<int>("cod_Distrito")
                        .HasColumnType("int");

                    b.Property<string>("direc_Empleado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom_Empleado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cod_Empleado");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Proyecto.Entidades.OrdenPedido", b =>
                {
                    b.Property<int>("num_ordenPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("cod_Cliente")
                        .HasColumnType("int");

                    b.Property<int>("cod_Empleado")
                        .HasColumnType("int");

                    b.Property<string>("cod_tipoPago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("num_ordenPedido");

                    b.HasIndex("cod_Cliente");

                    b.HasIndex("cod_Empleado");

                    b.ToTable("OrdenPedidos");
                });

            modelBuilder.Entity("Proyecto.Entidades.Presentacion", b =>
                {
                    b.Property<int>("cod_Presentacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nom_Presentacion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cod_Presentacion");

                    b.ToTable("Presentaciones");
                });

            modelBuilder.Entity("Proyecto.Entidades.Producto", b =>
                {
                    b.Property<int>("cod_Producto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("cod_Categoria")
                        .HasColumnType("int");

                    b.Property<int>("cod_Presentacion")
                        .HasColumnType("int");

                    b.Property<int>("cod_Proveedor")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha_Venc")
                        .HasColumnType("datetime2");

                    b.Property<string>("nom_Producto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("precio_Venta")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("cod_Producto");

                    b.HasIndex("cod_Categoria");

                    b.HasIndex("cod_Presentacion");

                    b.HasIndex("cod_Proveedor");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Proyecto.Entidades.Proveedor", b =>
                {
                    b.Property<int>("cod_Proveedor")
                        .HasColumnType("int");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<int>("cod_distrito")
                        .HasColumnType("int");

                    b.Property<string>("direc_Proveedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom_Proveedor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cod_Proveedor");

                    b.ToTable("Proveedores");
                });

            modelBuilder.Entity("Proyecto.Entidades.Usuario", b =>
                {
                    b.Property<int>("cod_Usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("activo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cod_Empleado")
                        .HasColumnType("int");

                    b.Property<int>("nivel_Us")
                        .HasColumnType("int");

                    b.Property<string>("nom_Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cod_Usuario");

                    b.HasIndex("cod_Empleado");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("Proyecto.Entidades.Boleta", b =>
                {
                    b.HasOne("Proyecto.Entidades.OrdenPedido", "OrdenPedido")
                        .WithMany("Boleta")
                        .HasForeignKey("num_OrdenPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrdenPedido");
                });

            modelBuilder.Entity("Proyecto.Entidades.Cliente", b =>
                {
                    b.HasOne("Proyecto.Entidades.Distrito", "Distrito")
                        .WithMany("Cliente")
                        .HasForeignKey("cod_Distrito")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Distrito");
                });

            modelBuilder.Entity("Proyecto.Entidades.DetalleOrdenPedido", b =>
                {
                    b.HasOne("Proyecto.Entidades.Producto", "Producto")
                        .WithMany("DetalleOrdenPedido")
                        .HasForeignKey("num_OrdenPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Proyecto.Entidades.Empleado", b =>
                {
                    b.HasOne("Proyecto.Entidades.Distrito", "Distrito")
                        .WithMany("Empleado")
                        .HasForeignKey("cod_Empleado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Distrito");
                });

            modelBuilder.Entity("Proyecto.Entidades.OrdenPedido", b =>
                {
                    b.HasOne("Proyecto.Entidades.Cliente", "Cliente")
                        .WithMany("OrdenPedido")
                        .HasForeignKey("cod_Cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto.Entidades.Empleado", "Empleado")
                        .WithMany("OrdenPedido")
                        .HasForeignKey("cod_Empleado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Proyecto.Entidades.Producto", b =>
                {
                    b.HasOne("Proyecto.Entidades.Categoria", "Categoria")
                        .WithMany("Producto")
                        .HasForeignKey("cod_Categoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto.Entidades.Presentacion", "Presentacion")
                        .WithMany("Producto")
                        .HasForeignKey("cod_Presentacion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proyecto.Entidades.Proveedor", "Proveedor")
                        .WithMany("Producto")
                        .HasForeignKey("cod_Proveedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Presentacion");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("Proyecto.Entidades.Proveedor", b =>
                {
                    b.HasOne("Proyecto.Entidades.Distrito", "Distrito")
                        .WithMany("Proveedor")
                        .HasForeignKey("cod_Proveedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Distrito");
                });

            modelBuilder.Entity("Proyecto.Entidades.Usuario", b =>
                {
                    b.HasOne("Proyecto.Entidades.Empleado", "Empleado")
                        .WithMany("Usuario")
                        .HasForeignKey("cod_Empleado")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empleado");
                });

            modelBuilder.Entity("Proyecto.Entidades.Categoria", b =>
                {
                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Proyecto.Entidades.Cliente", b =>
                {
                    b.Navigation("OrdenPedido");
                });

            modelBuilder.Entity("Proyecto.Entidades.Distrito", b =>
                {
                    b.Navigation("Cliente");

                    b.Navigation("Empleado");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("Proyecto.Entidades.Empleado", b =>
                {
                    b.Navigation("OrdenPedido");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Proyecto.Entidades.OrdenPedido", b =>
                {
                    b.Navigation("Boleta");
                });

            modelBuilder.Entity("Proyecto.Entidades.Presentacion", b =>
                {
                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Proyecto.Entidades.Producto", b =>
                {
                    b.Navigation("DetalleOrdenPedido");
                });

            modelBuilder.Entity("Proyecto.Entidades.Proveedor", b =>
                {
                    b.Navigation("Producto");
                });
#pragma warning restore 612, 618
        }
    }
}
