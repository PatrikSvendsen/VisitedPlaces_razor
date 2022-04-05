using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VisitedPlaces_razor.Pages.Countries;

public class CreateCountryModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;
    public Country Country { get; set; }

    public CreateCountryModel(IUnitOfWork unitOfWork) =>
        _unitOfWork = unitOfWork;

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPost(Country country)
    {
        await _unitOfWork.Countries.Insert(country);
        await _unitOfWork.CompleteAsync();
        return RedirectToPage("IndexCountries");
    }
}
