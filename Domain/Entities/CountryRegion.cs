using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class CountryRegion
{
    [Key]
    [Column("CountryRegionId")]
    public int Id { get; set; }
    public string Name { get; set; }
    public int? Population { get; set; } = 0;

    public ICollection<City>? Cities { get; set; }


    [ForeignKey(nameof(Country))]
    public int CountryId { get; set; }
    public Country? Country { get; set; }
}
