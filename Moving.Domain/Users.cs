using System;
using System.Collections.Generic;

namespace Moving.Domain
{
    public partial class Users : Entity
    {
        public Users()
        {
            Jobs = new HashSet<Jobs>();
            UserRoles = new HashSet<UserRoles>();
            JobReviews = new HashSet<JobReviews>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Jobs> Jobs { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
        public virtual ICollection<JobReviews> JobReviews { get; set; }
    }
}
