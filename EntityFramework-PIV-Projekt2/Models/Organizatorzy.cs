using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework_PIV_Projekt2;

public partial class Organizatorzy
{
    [Key]
    public int Id { get; set; }

    public string Nip { get; set; } = null!;

    public string Telefon { get; set; } = null!;

    public string NazwaFirmy { get; set; } = null!;

    public string Imie { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public string Mail { get; set; } = null!;


    public virtual Adres Adres { get; set; } = null!;

    public virtual ICollection<Wydarzenie> Wydarzenia { get; set; } = new List<Wydarzenie>();
}
