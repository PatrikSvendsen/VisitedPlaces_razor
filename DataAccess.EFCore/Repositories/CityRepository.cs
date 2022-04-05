using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore.Repositories;

public class CityRepository : GenericRepository<City>, ICityRepository
{

    public CityRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public async Task<IEnumerable<City>> GetDetailedList()
    {
        var countryList = _repositoryContext.Countries;
        var cityList = _repositoryContext.Cities;

        var detailedCityList = from country in countryList
                               join cities in cityList
                               on country.Id equals cities.CountryId
                               orderby country.Name
                               select cities;

        return detailedCityList;
    }
}