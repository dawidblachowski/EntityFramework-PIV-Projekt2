using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework_PIV_Projekt2;

public partial class KlienciBiletyTransakcje
{
    [Key]
    public int Id { get; set; }

    public string MetodaPlatnosci { get; set; } = null!;

    public bool Status { get; set; }

    public DateTime DataZakupu { get; set; }

    public int IloscZakupionychBiletow { get; set; }

    public virtual Bilety Bilet { get; set; } = null!;

    public virtual Klienci Klient { get; set; } = null!;

    public virtual Rezerwacje? Rezerwacja { get; set; }

    public virtual Rabat? Rabat { get; set; }
}
