using Moving.Application.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Application.Searches
{
    public class CustomerSearch : PagedSearch
    {
        public string Name { get; set; }
    }
}
