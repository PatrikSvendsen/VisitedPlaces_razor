using DataAccess.EFCore.Repositories.Configurations;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore;

public class RepositoryContext : DbContext
{
    public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<City> Cities { get; set; }
    public virtual DbSet<Country> Countries { get; set; }
    public virtual DbSet<CountryRegion> CountryRegions { get; set; }
    public virtual DbSet<Continent> Continents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ContinentConfiguration());

        modelBuilder.Entity<CountryRegion>()
            .HasOne(co => co.Country)
            .WithMany(ci => ci.CountryRegions)
            .HasForeignKey(c => c.CountryId);

        modelBuilder.Entity<Country>()
            .HasMany(ci => ci.Cities)
            .WithOne(co => co.Country)
            .HasForeignKey(c => c.CountryId);
        //.HasConstraintName(nameof(Country.Id));

        modelBuilder.Entity<Continent>()
            .HasMany(co => co.Countries)
            .WithOne(c => c.Continent)
            .HasForeignKey(x => x.ContinentId);

    }
}
