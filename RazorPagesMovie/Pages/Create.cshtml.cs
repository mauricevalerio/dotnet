using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages;
public class CreateModel : PageModel
{
    private readonly RazorPagesMovieContext _context;

    [BindProperty]
    public Movie Movie { get; set; } = default!;
    public CreateModel(RazorPagesMovieContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        return Page();
    }

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        if (await TryUpdateModelAsync(Movie))
        {
            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

        }
        return RedirectToPage("./Index");
    }
}
