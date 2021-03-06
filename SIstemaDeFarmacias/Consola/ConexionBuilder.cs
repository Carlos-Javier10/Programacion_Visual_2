using System;
using System.Collections.Generic;
using ModeloDB;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Consola
{
    public class ConexionBuilder
    {
        const string DBTipo = "DBTipo";
        enum DBTipoConn { SqlServer, Postgres, Memoria }
        static Conexion db;

        public static Conexion Crear()
        {
            // Lee la configuración acerca de qué base usar del archivo App.config
            string dbtipo = ConfigurationManager.AppSettings[DBTipo];
            string conn = ConfigurationManager.ConnectionStrings[dbtipo].ConnectionString;

            // Construye la conección acorde con el tipo
            DbContextOptions<Conexion> contextOptions;
            switch (dbtipo)
            {
                case nameof(DBTipoConn.SqlServer):
                    contextOptions = new DbContextOptionsBuilder<Conexion>()
                        .UseSqlServer(conn)
                        .Options;
                    break;
                case nameof(DBTipoConn.Postgres):
                    contextOptions = new DbContextOptionsBuilder<Conexion>()
                        .UseNpgsql(conn)
                        .Options;
                    break;
                default: // Por defecto usa la memoria como base de datos
                    contextOptions = new DbContextOptionsBuilder<Conexion>()
                        .UseInMemoryDatabase(conn)
                        .Options;
                    break;
            }

            db = new Conexion(contextOptions);

            return db;
        }
    }
}
