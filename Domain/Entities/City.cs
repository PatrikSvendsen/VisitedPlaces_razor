using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class City
{
    [Key]
    [Column("CityId")]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public bool IsCapital { get; set; } = false;
    public string BestMemory { get; set; } = string.Empty;

    [ForeignKey(nameof(Country))]
    public int? CountryId { get; set; }
    public Country? Country { get; set; }

    [ForeignKey(nameof(CountryRegion))]
    public int? CountryRegionId { get; set; }
    public CountryRegion? CountryRegion { get; set; }
}
