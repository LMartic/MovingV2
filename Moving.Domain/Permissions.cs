using System;
using System.Collections.Generic;

namespace Moving.Domain
{
    public partial class Permissions : Entity
    {
        public Permissions()
        {
            RolePermissions = new HashSet<RolePermissions>();
        }

        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<RolePermissions> RolePermissions { get; set; }
    }
}
