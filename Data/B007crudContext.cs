using System;
using System.Collections.Generic;
using B007Clases.Models;
using Microsoft.EntityFrameworkCore;

namespace B007Clases.Data;

public partial class B007CrudContext : DbContext
{
    public B007CrudContext()
    {
    }

    public B007CrudContext(DbContextOptions<B007CrudContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    /*
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(Configuracion.CadenaConexion);
        */
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.Property(e => e.Creado).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Email).IsFixedLength();
            entity.Property(e => e.FechaAlta).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.IdCliente).ValueGeneratedOnAdd();
            entity.Property(e => e.Modificado).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Telefono).IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
