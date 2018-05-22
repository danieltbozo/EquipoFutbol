using EquipoFutbol1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipoFutbol1.Data
{
    public class FutbolContext : DbContext
    {
        public FutbolContext(DbContextOptions<FutbolContext> options) : base(options)
        {
        }

        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipo>().ToTable("Equipo");
            modelBuilder.Entity<Jugador>().ToTable("Jugador");
        }
    }
}
