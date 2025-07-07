using FarmaciaWinFormsEF.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace FarmaciaWinFormsEF.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Medicamento> Medicamentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Puedes ajustar el nombre de la base de datos y las credenciales aquí:
            var conexion = "server=localhost;database=farmacia_db;uid=root;pwd=";
            var version_mysql = new MySqlServerVersion(new Version("10.4.32"));
            optionsBuilder.UseMySql(conexion, version_mysql);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
