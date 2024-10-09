using System;
using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

namespace Back_end_Challenge.Models
{
    public partial class DBempleadoContext : DbContext
    {
        public DBempleadoContext() { 
        
        }

        public DBempleadoContext(DbContextOptions<DBempleadoContext> options) : base(options) 
        {
        }
        public virtual DbSet<Departamento> Departamentos { get; set;}

        public virtual DbSet<Empleado> Empleados { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(local); DataBase=DBEmpleados; Trusted_Connection=true;TrustServerCertificate=true;");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>(entity =>
            { entity.HasKey(e => e.IdDepartamento).HasName("PK_Departam_78fsfsf5435");
                entity.ToTable("Departamento");
            });
        }
    }
}
