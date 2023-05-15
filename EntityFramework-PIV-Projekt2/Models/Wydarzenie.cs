using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework_PIV_Projekt2;

public partial class Wydarzenie
{
    [Key]
    public int Id { get; set; }

    public string Nazwa { get; set; } = null!;

    public DateTime Data { get; set; }

    public decimal CenaBiletu { get; set; }

    public int IloscBiletow { get; set; }

    public string Opis { get; set; } = null!;

    public byte[]? Plakat { get; set; }

    public virtual ICollection<Bilety> Bilet { get; set; } = new List<Bilety>();

    public virtual Miejsca? Miejsce { get; set; }

    public virtual Organizatorzy Organizator { get; set; } = null!;

    public virtual ICollection<Oceny> Ocenies { get; set; } = new List<Oceny>();
}
