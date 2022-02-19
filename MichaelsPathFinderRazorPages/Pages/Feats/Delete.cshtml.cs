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
    public class DeleteModel : PageModel
    {
        private readonly MichaelsPathfinderRazorPagesContext _context;

        public DeleteModel(MichaelsPathfinderRazorPagesContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Feats = await _context.Feats.FindAsync(id);

            if (Feats != null)
            {
                _context.Feats.Remove(Feats);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
