using System;
using System.Collections.Generic;

namespace LLC_TechService_Context.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public int IdRole { get; set; }
        public string? TitleRole { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
