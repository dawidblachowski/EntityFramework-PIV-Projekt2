using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_PIV_Projekt2;
[Table("Klienci")]
public partial class KlientModel
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

    public virtual AdresModel? Adres { get; set; }

    public virtual ICollection<KlienciBiletyTransakcjeModel> Transakcje { get; set; } = new List<KlienciBiletyTransakcjeModel>();

    public virtual ICollection<OcenaModel> Oceny { get; set; } = new List<OcenaModel>();

    public virtual ICollection<RezerwacjaModel> Rezerwacje { get; set; } = new List<RezerwacjaModel>();
}
