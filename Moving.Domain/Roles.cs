using System;
using System.Collections.Generic;

namespace Moving.Domain
{
    public partial class Roles : Entity
    {
        public Roles()
        {
            RolePermissions = new HashSet<RolePermissions>();
            UserRoles = new HashSet<UserRoles>();
        }

        public string RoleName { get; set; }

        public virtual ICollection<RolePermissions> RolePermissions { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
