using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework_PIV_Projekt2;

public partial class Rabat
{
    [Key]
    public string Kod { get; set; } = null!;

    public decimal Znizka { get; set; }

    public virtual ICollection<KlienciBiletyTransakcje> KlienciBiletyTransakcjes { get; set; } = new List<KlienciBiletyTransakcje>();
}
