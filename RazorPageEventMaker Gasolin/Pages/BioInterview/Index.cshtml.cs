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
    public class IndexModel : PageModel
    {
        private readonly RazorPageEventMaker_Gasolin.Data.RazorPageEventMaker_GasolinContext _context;

        public IndexModel(RazorPageEventMaker_Gasolin.Data.RazorPageEventMaker_GasolinContext context)
        {
            _context = context;
        }

        public IList<BioInterviewModel> BioInterview { get; set; } = default!;

        /// <summary>
        /// PLuder plader er de bedste madder
        /// </summary>
        /// <returns></returns>
        public async Task OnGetAsync()

        {

            //Har udkommenteret nedenstående fordi den gør en masse som vi ikke har lært om endnu. Den mangler en database.
            //BioInterview = await _context.BioInterview.ToListAsync();
        }
    }
}
