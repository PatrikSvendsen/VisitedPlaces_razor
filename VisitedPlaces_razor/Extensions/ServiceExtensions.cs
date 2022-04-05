using DataAccess.EFCore;
using DataAccess.EFCore.Repositories;
using DataAccess.EFCore.UnitOfWork;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace VisitedPlaces_razor.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureSqlContext(this IServiceCollection services,
    IConfiguration configuration) =>
    services.AddDbContext<RepositoryContext>(opts =>
    opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

    public static void ConfigureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        //-----------|  DbContext
        services.AddScoped<RepositoryContext>();
        //-----------|  Repositories
        services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddTransient<IUnitOfWork, UnitOfWork>();
        services.AddTransient<IContinentRepository, ContinentRepository>();
        services.AddTransient<ICountryRepository, CountryRepository>();
        services.AddTransient<ICountryRegionRepository, CountryRegionRepository>();
        services.AddTransient<ICityRepository, CityRepository>();
        //-----------|  Services
        //services.AddTransient<IActiveMovieService, ActiveMovieService>();
        //services.AddTransient<IMovieService, MovieService>();
        //services.AddTransient<IBookingService, BookingService>();
        //services.AddTransient<ITimeService, TimeService>();
        //services.AddTransient<ISaloonService, SaloonService>();
        //services.AddTransient<ISeatService, SeatService>();
    }
}
