using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_PIV_Projekt2;
[Table("Rabaty")]
public partial class RabatModel
{
    [Key]
    public string Kod { get; set; } = null!;

    public decimal Znizka { get; set; }

    public virtual ICollection<KlienciBiletyTransakcjeModel> KlienciBiletyTransakcje { get; set; } = new List<KlienciBiletyTransakcjeModel>();
}
