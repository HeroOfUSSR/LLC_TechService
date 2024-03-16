using System;
using System.Collections.Generic;

namespace LLC_TechService_Context.Models
{
    public partial class Order
    {
        public Order()
        {
            Reports = new HashSet<Report>();
        }

        public int IdOrder { get; set; }
        public int EquipmentOrder { get; set; }
        public string? DescOrder { get; set; }
        public int MalfunctionOrder { get; set; }
        public int ClientOrder { get; set; }
        public int StatusOrder { get; set; }
        public int PriorityOrder { get; set; }
        public DateTime DateOrder { get; set; }
        public int? MasterOrder { get; set; }

        public virtual User ClientOrderNavigation { get; set; } = null!;
        public virtual Equipment EquipmentOrderNavigation { get; set; } = null!;
        public virtual Malfunction MalfunctionOrderNavigation { get; set; } = null!;
        public virtual User? MasterOrderNavigation { get; set; }
        public virtual Priority PriorityOrderNavigation { get; set; } = null!;
        public virtual Status StatusOrderNavigation { get; set; } = null!;
        public virtual ICollection<Report> Reports { get; set; }
    }
}
