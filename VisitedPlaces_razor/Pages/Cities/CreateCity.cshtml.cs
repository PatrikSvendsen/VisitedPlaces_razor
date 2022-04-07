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
    public string CountryId { get; set; } // Koden m�ste skrivas om f�r att enklast l�gga till land


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
        city.IsCapital = IsCapital;             //TODO Detta �r ingen bra l�sning men checkboxes �r fan jobbiga. Funkar 
        await _unitOfWork.Cities.Insert(city);
        await _unitOfWork.CompleteAsync();
        return RedirectToPage("IndexCities");
    }
}
