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

    public virtual DbSet<AdresModel> Adresy { get; set; }

    public virtual DbSet<BiletModel> Bilety { get; set; }

    public virtual DbSet<KlientModel> Klienci { get; set; }

    public virtual DbSet<KlienciBiletyTransakcjeModel> Transakcje { get; set; }

    public virtual DbSet<MiejsceModel> Miejsca { get; set; }

    public virtual DbSet<OcenaModel> Oceny { get; set; }

    public virtual DbSet<OrganizatorModel> Organizatorzy { get; set; }

    public virtual DbSet<RabatModel> Rabaty { get; set; }

    public virtual DbSet<RezerwacjaModel> Rezerwacje { get; set; }

    public virtual DbSet<WydarzenieModel> Wydarzenia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlServer("Server=localhost;Database=SBP4;Trusted_Connection=True;TrustServerCertificate=Yes");
        => optionsBuilder.UseSqlite(@"Data Source=C:\ATH\P4\EF\db.db");

}
