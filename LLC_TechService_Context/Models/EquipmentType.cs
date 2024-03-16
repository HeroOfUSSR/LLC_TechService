using System;
using System.Collections.Generic;

namespace LLC_TechService_Context.Models
{
    public partial class EquipmentType
    {
        public EquipmentType()
        {
            Equipment = new HashSet<Equipment>();
        }

        public int IdEquipType { get; set; }
        public string NameEquipType { get; set; } = null!;

        public virtual ICollection<Equipment> Equipment { get; set; }
    }
}
