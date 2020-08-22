using Moving.Application.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Application.Searches
{
    public class UseCaseSearch : PagedSearch
    {
        public string UserName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
    }
}
