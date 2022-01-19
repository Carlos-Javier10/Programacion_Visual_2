using Microsoft.EntityFrameworkCore;
using Proyecto.Entidades;

namespace ProyectoDB
{
    public class Conexion : DbContext
    {

        public DbSet<Distrito> Distritos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opciones)
        {
            opciones.UseSqlServer("Server= CARLOS ; initial catalog = Farmacia_Pro; trusted_connection = true; ");

            //opciones.UseNpgsql(" Host = localhost; Database = Insti; Username = postgres; Password = carlos00; ");

        }
    }
}
