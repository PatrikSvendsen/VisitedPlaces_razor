using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Continent
{
    [Key]
    [Column("ContinentId")]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public long? Population { get; set; } = 0;

    public ICollection<Country>? Countries { get; set; }
}
