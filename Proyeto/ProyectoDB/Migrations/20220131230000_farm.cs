using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoDB.Migrations
{
    public partial class farm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    cod_Categoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.cod_Categoria);
                });

            migrationBuilder.CreateTable(
                name: "Distritos",
                columns: table => new
                {
                    cod_Distrito = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_Distrito = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distritos", x => x.cod_Distrito);
                });

            migrationBuilder.CreateTable(
                name: "Presentaciones",
                columns: table => new
                {
                    cod_Presentacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_Presentacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presentaciones", x => x.cod_Presentacion);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    cod_Cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_Clinete = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direc_Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sexo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DNI = table.Column<int>(type: "int", nullable: false),
                    RUC = table.Column<long>(type: "bigint", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cod_Distrito = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.cod_Cliente);
                    table.ForeignKey(
                        name: "FK_Clientes_Distritos_cod_Distrito",
                        column: x => x.cod_Distrito,
                        principalTable: "Distritos",
                        principalColumn: "cod_Distrito",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    cod_Empleado = table.Column<int>(type: "int", nullable: false),
                    nom_Empleado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direc_Empleado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cod_Distrito = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.cod_Empleado);
                    table.ForeignKey(
                        name: "FK_Empleados_Distritos_cod_Empleado",
                        column: x => x.cod_Empleado,
                        principalTable: "Distritos",
                        principalColumn: "cod_Distrito",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    cod_Proveedor = table.Column<int>(type: "int", nullable: false),
                    nom_Proveedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    direc_Proveedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cod_distrito = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.cod_Proveedor);
                    table.ForeignKey(
                        name: "FK_Proveedores_Distritos_cod_Proveedor",
                        column: x => x.cod_Proveedor,
                        principalTable: "Distritos",
                        principalColumn: "cod_Distrito",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdenPedidos",
                columns: table => new
                {
                    num_ordenPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cod_tipoPago = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    cod_Cliente = table.Column<int>(type: "int", nullable: false),
                    Empleadocod_Empleado = table.Column<int>(type: "int", nullable: true),
                    cod_Empleado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenPedidos", x => x.num_ordenPedido);
                    table.ForeignKey(
                        name: "FK_OrdenPedidos_Clientes_cod_Cliente",
                        column: x => x.cod_Cliente,
                        principalTable: "Clientes",
                        principalColumn: "cod_Cliente",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenPedidos_Empleados_Empleadocod_Empleado",
                        column: x => x.Empleadocod_Empleado,
                        principalTable: "Empleados",
                        principalColumn: "cod_Empleado",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    cod_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nivel_Us = table.Column<int>(type: "int", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    activo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cod_Empleado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.cod_Usuario);
                    table.ForeignKey(
                        name: "FK_Usuarios_Empleados_cod_Empleado",
                        column: x => x.cod_Empleado,
                        principalTable: "Empleados",
                        principalColumn: "cod_Empleado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    cod_Producto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_Producto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    precio_Venta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    fecha_Venc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    cod_Presentacion = table.Column<int>(type: "int", nullable: false),
                    cod_Categoria = table.Column<int>(type: "int", nullable: false),
                    cod_Proveedor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.cod_Producto);
                    table.ForeignKey(
                        name: "FK_Productos_Categorias_cod_Categoria",
                        column: x => x.cod_Categoria,
                        principalTable: "Categorias",
                        principalColumn: "cod_Categoria",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Presentaciones_cod_Presentacion",
                        column: x => x.cod_Presentacion,
                        principalTable: "Presentaciones",
                        principalColumn: "cod_Presentacion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Productos_Proveedores_cod_Proveedor",
                        column: x => x.cod_Proveedor,
                        principalTable: "Proveedores",
                        principalColumn: "cod_Proveedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Boletas",
                columns: table => new
                {
                    num_boleta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sub_Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    num_OrdenPedido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boletas", x => x.num_boleta);
                    table.ForeignKey(
                        name: "FK_Boletas_OrdenPedidos_num_OrdenPedido",
                        column: x => x.num_OrdenPedido,
                        principalTable: "OrdenPedidos",
                        principalColumn: "num_ordenPedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleOrdenPedidos",
                columns: table => new
                {
                    num_OrdenPedido = table.Column<int>(type: "int", nullable: false),
                    Catidad = table.Column<int>(type: "int", nullable: false),
                    precio_venta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    importe = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    cod_Prodructo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleOrdenPedidos", x => x.num_OrdenPedido);
                    table.ForeignKey(
                        name: "FK_DetalleOrdenPedidos_Productos_num_OrdenPedido",
                        column: x => x.num_OrdenPedido,
                        principalTable: "Productos",
                        principalColumn: "cod_Producto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boletas_num_OrdenPedido",
                table: "Boletas",
                column: "num_OrdenPedido");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_cod_Distrito",
                table: "Clientes",
                column: "cod_Distrito");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenPedidos_cod_Cliente",
                table: "OrdenPedidos",
                column: "cod_Cliente");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenPedidos_Empleadocod_Empleado",
                table: "OrdenPedidos",
                column: "Empleadocod_Empleado");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_cod_Categoria",
                table: "Productos",
                column: "cod_Categoria");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_cod_Presentacion",
                table: "Productos",
                column: "cod_Presentacion");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_cod_Proveedor",
                table: "Productos",
                column: "cod_Proveedor");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_cod_Empleado",
                table: "Usuarios",
                column: "cod_Empleado");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boletas");

            migrationBuilder.DropTable(
                name: "DetalleOrdenPedidos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "OrdenPedidos");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Presentaciones");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropTable(
                name: "Distritos");
        }
    }
}
