using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework_PIV_Projekt2;

public partial class Miejsca
{
    [Key]
    public int Id { get; set; }

    public string NazwaObiektu { get; set; } = null!;


    public byte[]? ZdjecieObiektu { get; set; }

    public virtual Adres Adres { get; set; } = null!;

    public virtual ICollection<Wydarzenie> Wydarzenia { get; set; } = new List<Wydarzenie>();
}
