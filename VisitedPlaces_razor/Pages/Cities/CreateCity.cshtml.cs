using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VisitedPlaces_razor.Pages.Cities;

public class CreateCityModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;
    public IEnumerable<Country> allCountries { get; set; }
    public City City { get; set; }

    [BindProperty(SupportsGet = true)]
    public bool IsCapital { get; set; }


    public CreateCityModel(IUnitOfWork unitOfWork) => 
        _unitOfWork = unitOfWork;

    public async Task OnGetAsync()
    {
        allCountries = await _unitOfWork.Countries.GetAll();
    }

    public async Task<IActionResult> OnPost(City city)
    {
        await _unitOfWork.Cities.Insert(city);
        await _unitOfWork.CompleteAsync();
        return RedirectToPage("IndexCities");
    }
}
