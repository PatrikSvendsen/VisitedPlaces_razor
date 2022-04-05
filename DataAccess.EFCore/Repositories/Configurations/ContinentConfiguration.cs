using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EFCore.Repositories.Configurations;

public class ContinentConfiguration : IEntityTypeConfiguration<Continent>
{
    public void Configure(EntityTypeBuilder<Continent> builder)
    {
        builder.HasData
        (
            new Continent
            {
                Id = 1,
                Name = "Asia",
                Population = 4400000000
            },
            new Continent
            {
                Id = 2,
                Name = "Europe",
                Population = 746419440
            },
            new Continent
            {
                Id = 3,
                Name = "Africa",
                Population = 1275920972
            },
            new Continent
            {
                Id = 4,
                Name = "North America",
                Population = 592296233
            },
            new Continent
            {
                Id = 5,
                Name = "South America",
                Population = 423581078
            },
            new Continent
            {
                Id = 6,
                Name = "Antarctica",
                Population = 1000
            },
            new Continent
            {
                Id = 7,
                Name = "Oceania",
                Population =41570842
            }
        );
    }
}
