using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_PIV_Projekt2;

[Table("KlienciBiletyTransakcje")]
public partial class KlienciBiletyTransakcjeModel
{
    [Key]
    public int Id { get; set; }

    public string MetodaPlatnosci { get; set; } = null!;

    public bool Status { get; set; }

    public DateTime DataZakupu { get; set; }

    public int IloscZakupionychBiletow { get; set; }

    public virtual BiletModel Bilet { get; set; } = null!;

    public virtual KlientModel Klient { get; set; } = null!;

    public virtual RezerwacjaModel? Rezerwacja { get; set; }

    public virtual RabatModel? Rabat { get; set; }
}
