using System;
using System.Collections.Generic;

namespace LLC_TechService_Context.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            Orders = new HashSet<Order>();
        }

        public int IdEquipment { get; set; }
        public string NameEquipment { get; set; } = null!;
        public int SerialEquipment { get; set; }
        public int TypeEquipment { get; set; }

        public virtual EquipmentType TypeEquipmentNavigation { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
    }
}
