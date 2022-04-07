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
    public string CountryId { get; set; } // Koden måste skrivas om för att enklast lägga till land


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
        city.IsCapital = IsCapital;             //TODO Detta är ingen bra lösning men checkboxes är fan jobbiga. Funkar 
        await _unitOfWork.Cities.Insert(city);
        await _unitOfWork.CompleteAsync();
        return RedirectToPage("IndexCities");
    }
}
