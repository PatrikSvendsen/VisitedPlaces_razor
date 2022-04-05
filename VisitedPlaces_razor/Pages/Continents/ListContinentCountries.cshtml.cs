using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VisitedPlaces_razor.Pages.Continents;

public class ListContinentCountriesModel : PageModel
{
    //TODO:
    // Se över lösningen i cshtml filen för att sortera tomma continents.
    // Fungerar men är det bästa lösningen?

    private readonly IUnitOfWork _unitOfWork;
    public IEnumerable<Continent>? countryCount { get; set; }

    public ListContinentCountriesModel(IUnitOfWork unitOfWork) =>
        _unitOfWork = unitOfWork;


    public async Task<IActionResult> OnGetAsync(int id)
    {
        countryCount = await _unitOfWork.Continents.GetDetailedCountryList(id);
        return Page();
    }
}
