using System;
using System.Data.Entity;

namespace Guardias
{
    class Context : DbContext
    {
        public DbSet<Unidad> Unidades { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Guardia> Guardias { get; set; }
        public DbSet<Semana> Semanas { get; set; }
        public DbSet<SemanaArea> SemanasAreas { get; set; }
        public DbSet<SemanaGuardia> SemanaGuardias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Unidad
            modelBuilder.Entity<Unidad>()
                .ToTable("Unidades");

            // Áreas


            // Guardias

            // SemanasAreas
            modelBuilder.Entity<SemanaArea>()
                .ToTable("SemanasAreas");

            // SemanasGuardias
            modelBuilder.Entity<SemanaGuardia>()
                .ToTable("SemanasGuardias");
        }
    }
}
