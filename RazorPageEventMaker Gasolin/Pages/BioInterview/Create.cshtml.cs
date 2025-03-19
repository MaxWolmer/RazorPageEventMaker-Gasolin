using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPageEventMaker_Gasolin.Data;
using RazorPageEventMaker_Gasolin.Models;

namespace RazorPageEventMaker_Gasolin.Pages.BioInterview
{
    public class CreateModel : PageModel
    {
        private readonly RazorPageEventMaker_Gasolin.Data.RazorPageEventMaker_GasolinContext _context;

        public CreateModel(RazorPageEventMaker_Gasolin.Data.RazorPageEventMaker_GasolinContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public BioInterviewModel BioInterview { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.BioInterview.Add(BioInterview);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
