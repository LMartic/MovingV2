using System;
using System.Collections.Generic;

namespace Moving.Domain
{
    public partial class JobStatuses
    {
        public JobStatuses()
        {
            Jobs = new HashSet<Jobs>();
        }

        public int Id { get; set; }
        public string JobStatus { get; set; }

        public virtual ICollection<Jobs> Jobs { get; set; }
    }
}
