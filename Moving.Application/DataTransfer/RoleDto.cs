using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Application.DataTransfer
{
    public class RoleDto
    {
        public RoleDto()
        {
            PerimissionIds = new List<int>();
        }
        public int Id { get; set; }
        public string RoleName { get; set; }
        public List<int> PerimissionIds { get; set; }
    }
}
