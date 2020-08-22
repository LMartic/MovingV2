using System;
using System.Collections.Generic;

namespace Moving.Domain
{
    public partial class RolePermissions
    {
        public int PermissionId { get; set; }
        public int RoleId { get; set; }

        public virtual Permissions Permission { get; set; }
        public virtual Roles Role { get; set; }
    }
}
