using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class CountryRegion
{
    [Key]
    [Column("CountryRegionId")]
    public int Id { get; set; }

    [Required(ErrorMessage = "This field needs to be filled")]
    [MaxLength(30)]
    public string Name { get; set; }

    public ICollection<City>? Cities { get; set; }


    [ForeignKey(nameof(Country))]
    public int? CountryId { get; set; }
    public Country? Country { get; set; }
}
