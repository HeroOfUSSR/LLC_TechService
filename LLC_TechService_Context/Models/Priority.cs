using System;
using System.Collections.Generic;

namespace LLC_TechService_Context.Models
{
    public partial class Priority
    {
        public Priority()
        {
            Orders = new HashSet<Order>();
        }

        public int IdPriority { get; set; }
        public string NamePriority { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
