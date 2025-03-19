using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageEventMaker_Gasolin.Models;

namespace RazorPageEventMaker_Gasolin.Data
{
    public class RazorPageEventMaker_GasolinContext : DbContext
    {
        public RazorPageEventMaker_GasolinContext (DbContextOptions<RazorPageEventMaker_GasolinContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageEventMaker_Gasolin.Models.BioInterviewModel> BioInterview { get; set; } = default!;
    }
}
