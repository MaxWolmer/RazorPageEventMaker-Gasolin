using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageEventMaker_Gasolin.Data;
using RazorPageEventMaker_Gasolin.Models;

namespace RazorPageEventMaker_Gasolin.Pages.Shared
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageEventMaker_GasolinContext _context;

        public IndexModel(RazorPageEventMaker_GasolinContext context)
        {
            _context = context;
        }

        public IList<BioInterviewModel> BioInterview { get;set; } = default!;

        public async Task OnGetAsync()
        {
            BioInterview = await _context.BioInterview.ToListAsync();
        }
    }
}
