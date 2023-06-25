using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_PIV_Projekt2;
[Table("Bilety")]
public partial class BiletModel
{
    [Key]
    public int Id { get; set; }

    public string Rodzaj { get; set; } = null!;

    public int? Miejsce { get; set; }

    public virtual WydarzenieModel Wydarzenie { get; set; } = null!;

    public virtual ICollection<KlienciBiletyTransakcjeModel> KlienciBiletyTransakcje { get; set; } = new List<KlienciBiletyTransakcjeModel>();
}
