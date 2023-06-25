using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_PIV_Projekt2;

[Table("Adres")]
public partial class AdresModel
{
    [Key]
    public int Id { get; set; }

    public string KodPocztowy { get; set; } = null!;

    public string Kraj { get; set; } = null!;

    public string Miasto { get; set; } = null!;

    public string Ulica { get; set; } = null!;

    public string NumerBudynku { get; set; } = null!;

    public virtual ICollection<KlientModel> Klienci { get; set; } = new List<KlientModel>();

    public virtual ICollection<MiejsceModel> Miejsca { get; set; } = new List<MiejsceModel>();

    public virtual ICollection<OrganizatorModel> Organizatorzy { get; set; } = new List<OrganizatorModel>();

    public override string ToString()
    {
        //return base.ToString();
        return $"{Ulica} {NumerBudynku}, {Miasto} {KodPocztowy} {Kraj}";
    }
}
