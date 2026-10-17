using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zaharie_Alexandu_Lab2.Models;

namespace Zaharie_Alexandu_Lab2.Pages.PublisherPages;

public class CreateModel : PageModel
{
    private readonly Zaharie_Alexandu_Lab2Context _context;

    public CreateModel(Zaharie_Alexandu_Lab2Context context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        return Page();
    }

    [BindProperty]
    public Publisher Publisher { get; set; } = default!;

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Publisher.Add(Publisher);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
