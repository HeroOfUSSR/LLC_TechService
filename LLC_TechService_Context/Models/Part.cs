using System;
using System.Collections.Generic;

namespace LLC_TechService_Context.Models
{
    public partial class Part
    {
        public Part()
        {
            UsedParts = new HashSet<UsedPart>();
        }

        public int IdPart { get; set; }
        public string TitlePart { get; set; } = null!;
        public string? DescPart { get; set; }
        public int AmountPart { get; set; }

        public virtual ICollection<UsedPart> UsedParts { get; set; }
    }
}
