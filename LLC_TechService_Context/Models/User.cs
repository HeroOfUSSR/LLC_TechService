using System;
using System.Collections.Generic;

namespace LLC_TechService_Context.Models
{
    public partial class User
    {
        public User()
        {
            OrderClientOrderNavigations = new HashSet<Order>();
            OrderMasterOrderNavigations = new HashSet<Order>();
            Reports = new HashSet<Report>();
        }

        public int IdUser { get; set; }
        public string NameUser { get; set; } = null!;
        public string SurnameUser { get; set; } = null!;
        public string PatronymicUser { get; set; } = null!;
        public string LoginUser { get; set; } = null!;
        public string PasswordUser { get; set; } = null!;
        public int RoleUser { get; set; }

        public virtual Role RoleUserNavigation { get; set; } = null!;
        public virtual ICollection<Order> OrderClientOrderNavigations { get; set; }
        public virtual ICollection<Order> OrderMasterOrderNavigations { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
