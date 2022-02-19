using System;
using System.ComponentModel.DataAnnotations;

namespace MichaelsPathFinderRazorPages.Models
{
    public class Feats
    {
        public int ID { get; set; }
        public string featName { get; set; }

        [DataType(DataType.Date)]
        public DateTime FeatLearnedDate { get; set; }
        public string shortDescription { get; set; }
        public string description { get; set; }
    }
}