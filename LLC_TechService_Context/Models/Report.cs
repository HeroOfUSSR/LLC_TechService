using System;
using System.Collections.Generic;

namespace LLC_TechService_Context.Models
{
    public partial class Report
    {
        public int IdReport { get; set; }
        public int OrderReport { get; set; }
        public DateTime DateReport { get; set; }
        public decimal CostReport { get; set; }
        public int MalfunctionReport { get; set; }
        public int PartReport { get; set; }
        public int PartAmountReport { get; set; }
        public string? DescReport { get; set; }
        public int MasterReport { get; set; }

        public virtual Malfunction MalfunctionReportNavigation { get; set; } = null!;
        public virtual User MasterReportNavigation { get; set; } = null!;
        public virtual Order OrderReportNavigation { get; set; } = null!;
        public virtual Part PartReportNavigation { get; set; } = null!;
    }
}
