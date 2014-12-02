using System;
using System.Data.Entity;

namespace Guardias
{
    class Context : DbContext
    {
        public DbSet<Unidad> Unidades { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Guardia> Guardias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Unidad
            modelBuilder.Entity<Unidad>()
                .ToTable("Unidades");

            // Áreas


            // Guardias
            
        }
    }
}
