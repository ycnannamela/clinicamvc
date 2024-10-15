using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Models;

public partial class ClinicadbContext : DbContext
{
    public ClinicadbContext()
    {
    }

    public ClinicadbContext(DbContextOptions<ClinicadbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Medico> Medicos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:servidor15octubre.database.windows.net,1433;Database=clinicadb;User Id=nimda;Password=0ctubr3.24;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Medico>(entity =>
        {
            entity.HasKey(e => e.Matricula);

            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
