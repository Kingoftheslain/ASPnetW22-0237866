using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MichaelsPathFinderRazorPages.Models;

namespace MichaelsPathFinderRazorPages.Pages_Feats
{
    public class CreateModel : PageModel
    {
        private readonly MichaelsPathfinderRazorPagesContext _context;

        public CreateModel(MichaelsPathfinderRazorPagesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Feats Feats { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Feats.Add(Feats);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
