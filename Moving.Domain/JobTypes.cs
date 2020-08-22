using System;
using System.Collections.Generic;

namespace Moving.Domain
{
    public partial class JobTypes
    {
        public JobTypes()
        {
            Jobs = new HashSet<Jobs>();
        }

        public int Id { get; set; }
        public string JobType { get; set; }

        public virtual ICollection<Jobs> Jobs { get; set; }
    }
}
