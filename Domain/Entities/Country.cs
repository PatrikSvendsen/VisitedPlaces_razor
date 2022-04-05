using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Country
{
    [Key]
    [Column("CountryId")]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public int? Population { get; set; } = 0;
    public string MainLanguage { get; set; }
    public string? SecondLanguage { get; set; }
    public int? YearVisited { get; set; }
    public int? TimesVisited { get; set; }

    // FK kopplingar
    public ICollection<City>? Cities{ get; set; }
    public ICollection<CountryRegion>? CountryRegions { get; set; }

    [ForeignKey(nameof(Continent))]
    public int? WorldRegionId { get; set; }
    public Continent? Continent { get; set; }
}
