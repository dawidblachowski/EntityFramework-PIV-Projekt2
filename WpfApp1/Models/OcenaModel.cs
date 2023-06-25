using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_PIV_Projekt2;
[Table("Oceny")]
public partial class OcenaModel
{
    [Key]
    public int Id { get; set; }

    public decimal Ocena { get; set; }

    public DateTime Data { get; set; }

    public string? Komentarz { get; set; }

    public virtual KlientModel Klient { get; set; } = null!;

    public virtual WydarzenieModel Wydarzenie { get; set; } = null!;
}
