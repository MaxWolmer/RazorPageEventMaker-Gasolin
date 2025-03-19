using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageEventMaker_Gasolin.Pages;

public class Tidslinje : PageModel
{
    private readonly ILogger<Tidslinje> _logger;

    public Tidslinje(ILogger<Tidslinje> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

