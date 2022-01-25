using Microsoft.EntityFrameworkCore;
using Proyecto.Entidades;

namespace ProyectoDB
{
    public class Conexion : DbContext
    {

        public DbSet<Boleta> Boletas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetalleOrdenPedido> DetalleOrdenPedidos { get; set; }
        public DbSet<Distrito> Distritos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<OrdenPedido> OrdenPedidos { get; set; }
        public DbSet<Presentacion> Presentaciones { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        //confirgurar el modelo 
        protected override void OnModelCreating (ModelBuilder model)
        {
            //configuracion
            //Distrito
            model.Entity<Distrito>()
                .HasOne(Distrito => Distrito.Proveedors)
                .WithMany(Proveedor => Proveedor.Distritos)


        }

        protected override void OnConfiguring(DbContextOptionsBuilder opciones)
        {
            opciones.UseSqlServer("Server= CARLOS ; initial catalog = Farmacia_Pro; trusted_connection = true; ");

            //opciones.UseNpgsql(" Host = localhost; Database = Insti; Username = postgres; Password = carlos00; ");

        }
    }
}
