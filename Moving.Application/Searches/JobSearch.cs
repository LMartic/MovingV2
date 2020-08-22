using Moving.Application.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Application.Searches
{
    public class JobSearch : PagedSearch
    {
        public string CustomerName { get; set; }
    }
}
