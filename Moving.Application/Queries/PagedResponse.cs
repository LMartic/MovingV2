using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Application.Queries
{
    public class PagedResponse<T> where T : class
    {
        public int TotalCount { get; set; }
        public int CurrentPage { get; set; }
        public int ItemsPerPage { get; set; }
        public IEnumerable<T> Items { get; set; } 

        // TotalCount 19 10
        public int PagesCount => (int)Math.Ceiling((float)TotalCount / ItemsPerPage);
    }
}
