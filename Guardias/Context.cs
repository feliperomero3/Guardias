using System;
using System.Data.Entity;

namespace Guardias
{
    class Context : DbContext
    {
        public DbSet<Unidad> Unidades { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Guardia> Guardias { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // Unidad
        //    modelBuilder.Entity<Unidad>()
        //        .HasKey(p => p.Id);

        //    // Áreas
        //    modelBuilder.Entity<Area>()
        //        .HasKey(p => p.Id);


        //    // Guardias
        //    modelBuilder.Entity<Guardia>()
        //        .HasKey(p => p.Id);
            
        //}
    }
}
