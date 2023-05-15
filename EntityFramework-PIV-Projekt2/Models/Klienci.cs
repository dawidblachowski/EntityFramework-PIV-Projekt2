using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework_PIV_Projekt2;

public partial class Klienci
{
    [Key]
    public int Id { get; set; }

    public string? Imie { get; set; }

    public string? Nazwisko { get; set; }

    public string? Plec { get; set; }

    public DateTime DataUrodzenia { get; set; }

    public string Haslo { get; set; } = null!;

    public string Mail { get; set; } = null!;

    public string? Telefon { get; set; }

    public virtual Adres? Adres { get; set; }

    public virtual ICollection<KlienciBiletyTransakcje> Transakcje { get; set; } = new List<KlienciBiletyTransakcje>();

    public virtual ICollection<Oceny> Oceny { get; set; } = new List<Oceny>();

    public virtual ICollection<Rezerwacje> Rezerwacje { get; set; } = new List<Rezerwacje>();
}
