namespace Domain.Interfaces;

public interface IUnitOfWork
{
    IContinentRepository Continents { get; }
    ICountryRepository Countries { get; }
    ICountryRegionRepository CountyRegions { get; }
    ICityRepository Cities { get; }
    Task CompleteAsync();
}
