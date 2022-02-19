using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MichaelsPathFinderRazorPages.Models;

    public class MichaelsPathfinderRazorPagesContext : DbContext
    {
        public MichaelsPathfinderRazorPagesContext (DbContextOptions<MichaelsPathfinderRazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<MichaelsPathFinderRazorPages.Models.Feats> Feats { get; set; }
    }
