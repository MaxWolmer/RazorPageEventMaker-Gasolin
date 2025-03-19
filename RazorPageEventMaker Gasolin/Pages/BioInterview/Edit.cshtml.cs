using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPageEventMaker_Gasolin.Data;
using RazorPageEventMaker_Gasolin.Models;

namespace RazorPageEventMaker_Gasolin.Pages.BioInterview
{
    public class EditModel : PageModel
    {
        private readonly RazorPageEventMaker_Gasolin.Data.RazorPageEventMaker_GasolinContext _context;

        public EditModel(RazorPageEventMaker_Gasolin.Data.RazorPageEventMaker_GasolinContext context)
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

            var biointerview =  await _context.BioInterview.FirstOrDefaultAsync(m => m.Id == id);
            if (biointerview == null)
            {
                return NotFound();
            }
            BioInterview = biointerview;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(BioInterview).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BioInterviewExists(BioInterview.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BioInterviewExists(int id)
        {
            return _context.BioInterview.Any(e => e.Id == id);
        }
    }
}
