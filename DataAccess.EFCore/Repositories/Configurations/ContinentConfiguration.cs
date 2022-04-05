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
                Name = "Asia"
            },
            new Continent
            {
                Id = 2,
                Name = "Europe"
            },
            new Continent
            {
                Id = 3,
                Name = "Africa"
            },
            new Continent
            {
                Id = 4,
                Name = "North America"
            },
            new Continent
            {
                Id = 5,
                Name = "South America"
            },
            new Continent
            {
                Id = 6,
                Name = "Antarctica"
            },
            new Continent
            {
                Id = 7,
                Name = "Oceania"
            }
        );
    }
}
