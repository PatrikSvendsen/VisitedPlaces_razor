using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EFCore.Repositories;

public class CityRepository : GenericRepository<City>, ICityRepository
{

    public CityRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    //public Task<IEnumerable<City>> GetDetailedList()
    //{
    //    //var detailedCityList = from s in _repositoryContext.Countries
    //    //                       join st in studentAdditionalInfo on s.Id equals st.StudentId into st2
    //    //                       from st in st2.DefaultIfEmpty()
    //    //                       select new StudentViewModel { studentVm = s, studentAdditionalInfoVm = st };


    //    var testList = _repositoryContext.Cities
    //        .Include(x => x.Country)
    //        .ThenInclude(y => y.)
    //}
}