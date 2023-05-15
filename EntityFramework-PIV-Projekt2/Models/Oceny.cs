using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework_PIV_Projekt2;

public partial class Oceny
{
    [Key]
    public int Id { get; set; }

    public decimal Ocena { get; set; }

    public DateTime Data { get; set; }

    public string? Komentarz { get; set; }

    public virtual Klienci Klient { get; set; } = null!;

    public virtual Wydarzenie Wydarzenie { get; set; } = null!;
}
