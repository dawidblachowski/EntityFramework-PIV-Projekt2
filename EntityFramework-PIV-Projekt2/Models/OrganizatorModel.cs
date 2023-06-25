using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_PIV_Projekt2;
[Table("Organizatorzy")]
public partial class OrganizatorModel
{
    [Key]
    public int Id { get; set; }

    public string Nip { get; set; } = null!;

    public string Telefon { get; set; } = null!;

    public string NazwaFirmy { get; set; } = null!;

    public string Imie { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public string Mail { get; set; } = null!;


    public virtual AdresModel Adres { get; set; } = null!;

    public virtual ICollection<WydarzenieModel> Wydarzenia { get; set; } = new List<WydarzenieModel>();
}
