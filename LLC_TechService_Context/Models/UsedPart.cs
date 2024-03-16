using System;
using System.Collections.Generic;

namespace LLC_TechService_Context.Models
{
    public partial class UsedPart
    {
        public int IdUsedParts { get; set; }
        public int AmountUsedParts { get; set; }
        public int PartsId { get; set; }

        public virtual Part Parts { get; set; } = null!;
    }
}
