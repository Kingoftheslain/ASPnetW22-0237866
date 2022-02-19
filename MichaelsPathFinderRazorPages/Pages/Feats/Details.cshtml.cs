using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MichaelsPathFinderRazorPages.Models;

namespace MichaelsPathFinderRazorPages.Pages_Feats
{
    public class DetailsModel : PageModel
    {
        private readonly MichaelsPathfinderRazorPagesContext _context;

        public DetailsModel(MichaelsPathfinderRazorPagesContext context)
        {
            _context = context;
        }

        public Feats Feats { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Feats = await _context.Feats.FirstOrDefaultAsync(m => m.ID == id);

            if (Feats == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
