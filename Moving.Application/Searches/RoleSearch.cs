using Moving.Application.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Application.Searches
{
    public class RoleSearch : PagedSearch
    {
        public string RoleName { get; set; }
    }
}
