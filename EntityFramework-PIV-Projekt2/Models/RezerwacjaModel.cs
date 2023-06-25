using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_PIV_Projekt2;
[Table("Rezerwacje")]
public partial class RezerwacjaModel
{
    public int Id { get; set; }

    public DateTime DataRezerwacji { get; set; }

    public DateTime? DlugoscRezerwacji { get; set; }

    public decimal CenaRezerwacji { get; set; }

    public bool Status { get; set; }

    public virtual KlientModel Klient { get; set; } = null!;

    public virtual ICollection<KlienciBiletyTransakcjeModel> Transakcje { get; set; } = new List<KlienciBiletyTransakcjeModel>();
}
