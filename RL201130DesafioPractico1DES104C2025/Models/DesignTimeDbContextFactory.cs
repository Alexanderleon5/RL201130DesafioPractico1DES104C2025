using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RL201130DesafioPractico1DES104C2025.Models;
using System.IO;

namespace RL201130DesafioPractico1DES104C2025
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BodegaDBContext>
    {
        public BodegaDBContext CreateDbContext(string[] args)
        {
            // Configuración para encontrar el archivo appsettings.json
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<BodegaDBContext>();
            var connectionString = configuration.GetConnectionString("BodegaConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                // Cadena de conexión alternativa si no se encuentra en appsettings.json
                connectionString = "Server=(localdb)\\mssqllocaldb;Database=BodegaDB;Trusted_Connection=True;";
            }

            builder.UseSqlServer(connectionString);

            return new BodegaDBContext(builder.Options);
        }
    }
}