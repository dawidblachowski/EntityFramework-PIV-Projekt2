using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework_PIV_Projekt2;

public partial class SystemBiletContext : DbContext
{
    public SystemBiletContext()
    {
    }

    public SystemBiletContext(DbContextOptions<SystemBiletContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Adres> Adres { get; set; }

    public virtual DbSet<Bilety> Bilety { get; set; }

    public virtual DbSet<Klienci> Klienci { get; set; }

    public virtual DbSet<KlienciBiletyTransakcje> Transakcje { get; set; }

    public virtual DbSet<Miejsca> Miejsca { get; set; }

    public virtual DbSet<Oceny> Oceny { get; set; }

    public virtual DbSet<Organizatorzy> Organizatorzy { get; set; }

    public virtual DbSet<Rabat> Rabaty { get; set; }

    public virtual DbSet<Rezerwacje> Rezerwacje { get; set; }

    public virtual DbSet<Wydarzenie> Wydarzenia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost;Database=SB;Trusted_Connection=True;TrustServerCertificate=Yes");

}
