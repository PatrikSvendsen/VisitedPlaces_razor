using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VisitedPlaces_razor.Pages.Countries;

public class CreateCountryModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;
    public IEnumerable<Continent> continents { get; set; }
    public Country Country { get; set; }

    [BindProperty(SupportsGet = true)]
    public int ContinentId { get; set; }

    public CreateCountryModel(IUnitOfWork unitOfWork) =>
        _unitOfWork = unitOfWork;

    public async Task OnGetAsync()
    {
        continents = await _unitOfWork.Continents.GetAll();
    }

    public async Task<IActionResult> OnPost(Country country)
    {
        country.ContinentId = ContinentId; 
        await _unitOfWork.Countries.Insert(country);
        await _unitOfWork.CompleteAsync();
        return RedirectToPage("IndexCountries");
    }
}
