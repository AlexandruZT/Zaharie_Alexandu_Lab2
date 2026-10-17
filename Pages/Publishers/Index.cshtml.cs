using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Zaharie_Alexandu_Lab2.Models;

namespace Zaharie_Alexandu_Lab2.Pages.PublisherPages;

public class IndexModel : PageModel
{
    private readonly Zaharie_Alexandu_Lab2Context _context;

    public IndexModel(Zaharie_Alexandu_Lab2Context context)
    {
        _context = context;
    }

    public IList<Publisher> Publisher { get; set; } = default!;

    public async Task OnGetAsync()
    {
        Publisher = await _context.Publisher.ToListAsync();
    }
}
