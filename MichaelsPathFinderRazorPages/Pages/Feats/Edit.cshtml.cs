using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MichaelsPathFinderRazorPages.Models;

namespace MichaelsPathFinderRazorPages.Pages_Feats
{
    public class EditModel : PageModel
    {
        private readonly MichaelsPathfinderRazorPagesContext _context;

        public EditModel(MichaelsPathfinderRazorPagesContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Feats).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FeatsExists(Feats.ID))
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

        private bool FeatsExists(int id)
        {
            return _context.Feats.Any(e => e.ID == id);
        }
    }
}
