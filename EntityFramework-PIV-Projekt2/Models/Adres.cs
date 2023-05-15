using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework_PIV_Projekt2;

public partial class Adres
{
    [Key]
    public int Id { get; set; }

    public string KodPocztowy { get; set; } = null!;

    public string Kraj { get; set; } = null!;

    public string Miasto { get; set; } = null!;

    public string Ulica { get; set; } = null!;

    public string NumerBudynku { get; set; } = null!;

    public virtual ICollection<Klienci> Kliencis { get; set; } = new List<Klienci>();

    public virtual ICollection<Miejsca> Miejscas { get; set; } = new List<Miejsca>();

    public virtual ICollection<Organizatorzy> Organizatorzies { get; set; } = new List<Organizatorzy>();
}
