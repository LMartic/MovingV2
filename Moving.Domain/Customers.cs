using System;
using System.Collections.Generic;

namespace Moving.Domain
{
    public partial class Customers : Entity
    {
        public Customers()
        {
            Jobs = new HashSet<Jobs>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Jobs> Jobs { get; set; }
    }
}
