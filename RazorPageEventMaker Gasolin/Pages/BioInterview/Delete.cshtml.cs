using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageEventMaker_Gasolin.Data;
using RazorPageEventMaker_Gasolin.Models;

namespace RazorPageEventMaker_Gasolin.Pages.BioInterview
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPageEventMaker_Gasolin.Data.RazorPageEventMaker_GasolinContext _context;

        public DeleteModel(RazorPageEventMaker_Gasolin.Data.RazorPageEventMaker_GasolinContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BioInterviewModel BioInterview { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var biointerview = await _context.BioInterview.FirstOrDefaultAsync(m => m.Id == id);

            if (biointerview == null)
            {
                return NotFound();
            }
            else
            {
                BioInterview = biointerview;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var biointerview = await _context.BioInterview.FindAsync(id);
            if (biointerview != null)
            {
                BioInterview = biointerview;
                _context.BioInterview.Remove(BioInterview);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
