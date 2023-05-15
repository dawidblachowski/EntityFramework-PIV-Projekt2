using System;
using System.Collections.Generic;

namespace EntityFramework_PIV_Projekt2;

public partial class Rezerwacje
{
    public int Id { get; set; }

    public DateTime DataRezerwacji { get; set; }

    public DateTime? DlugoscRezerwacji { get; set; }

    public decimal CenaRezerwacji { get; set; }

    public bool Status { get; set; }

    public virtual Klienci Klient { get; set; } = null!;

    public virtual ICollection<KlienciBiletyTransakcje> Transakcje { get; set; } = new List<KlienciBiletyTransakcje>();
}
