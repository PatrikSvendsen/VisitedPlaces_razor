using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace VisitedPlaces_razor.Pages.Cities;

public class IndexCitiesModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;
    public IEnumerable<City> Cities { get; set; }
    public Country Country { get; set; }

    public IndexCitiesModel(IUnitOfWork unitOfWork) =>
        _unitOfWork = unitOfWork;
    

    public async Task<IActionResult> OnGetAsync()
    {

        Cities = await _unitOfWork.Cities.GetAll();
        await _unitOfWork.CompleteAsync();
        return Page();
    }
}
