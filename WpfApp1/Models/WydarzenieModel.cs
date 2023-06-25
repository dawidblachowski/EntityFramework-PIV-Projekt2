using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_PIV_Projekt2;
[Table("Wydarzenia")]
public partial class WydarzenieModel
{
    [Key]
    public int Id { get; set; }

    public string Nazwa { get; set; } = null!;

    public DateTime Data { get; set; }

    public decimal CenaBiletu { get; set; }

    public int IloscBiletow { get; set; }

    public string Opis { get; set; } = null!;

    public byte[]? Plakat { get; set; }

    public virtual ICollection<BiletModel> Bilet { get; set; } = new List<BiletModel>();

    public virtual MiejsceModel? Miejsce { get; set; }

    public virtual OrganizatorModel Organizator { get; set; } = null!;

    public virtual ICollection<OcenaModel> Ocenies { get; set; } = new List<OcenaModel>();
}
