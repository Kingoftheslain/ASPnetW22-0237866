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
    public class IndexModel : PageModel
    {
        private readonly MichaelsPathfinderRazorPagesContext _context;

        public IndexModel(MichaelsPathfinderRazorPagesContext context)
        {
            _context = context;
        }

        public IList<Feats> Feats { get;set; }

        public async Task OnGetAsync()
        {
            Feats = await _context.Feats.ToListAsync();
        }
    }
}
