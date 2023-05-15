using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework_PIV_Projekt2;

public partial class Bilety
{
    [Key]
    public int Id { get; set; }

    public string Rodzaj { get; set; } = null!;

    public int? Miejsce { get; set; }

    public virtual Wydarzenie Wydarzenie { get; set; } = null!;

    public virtual ICollection<KlienciBiletyTransakcje> KlienciBiletyTransakcjes { get; set; } = new List<KlienciBiletyTransakcje>();
}
