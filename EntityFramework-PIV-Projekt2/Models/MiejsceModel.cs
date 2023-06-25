using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_PIV_Projekt2;
[Table("Miejsca")]
public partial class MiejsceModel
{
    [Key]
    public int Id { get; set; }

    public string NazwaObiektu { get; set; } = null!;


    public byte[]? ZdjecieObiektu { get; set; }

    public virtual AdresModel Adres { get; set; } = null!;

    public virtual ICollection<WydarzenieModel> Wydarzenia { get; set; } = new List<WydarzenieModel>();
}
