using System;
using System.Collections.Generic;

namespace LLC_TechService_Context.Models
{
    public partial class Malfunction
    {
        public Malfunction()
        {
            Orders = new HashSet<Order>();
            Reports = new HashSet<Report>();
        }

        public int IdMalfunction { get; set; }
        public string NameMalfunction { get; set; } = null!;
        public string? DescMalfunction { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
