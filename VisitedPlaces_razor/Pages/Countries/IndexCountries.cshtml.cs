using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VisitedPlaces_razor.Pages.Countries;

public class IndexCountriesModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;
    //public IEnumerable<Country> Countries { get; set; }
    public IEnumerable<Country> Countries2 { get; set; }

    public IndexCountriesModel(IUnitOfWork unitOfWork) =>
        _unitOfWork = unitOfWork;
    
    public async Task<IActionResult> OnGetAsync()
    {
        //Countries = await _unitOfWork.Countries.GetAll();
        Countries2 = await _unitOfWork.Countries.GetDetailedCountryList();
        await _unitOfWork.CompleteAsync();
        return Page();
    }
}
