using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace VisitedPlaces_razor.Pages.Continents;

public class IndexContinentModel : PageModel
{
    private readonly IUnitOfWork _unitOfWork;
    public IEnumerable<Continent> Continents { get; set; }

    public IndexContinentModel(IUnitOfWork unitOfWork) =>
        _unitOfWork = unitOfWork;

    public async Task<IActionResult> OnGetAsync()
    {
        Continents = await _unitOfWork.Continents.GetAll();
        await _unitOfWork.CompleteAsync();
        return Page();
    }
}
