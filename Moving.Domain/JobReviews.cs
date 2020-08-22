using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moving.Domain
{
    public partial class JobReviews : Entity
    {
        public JobReviews()
        {

        }

        public string Description { get; set; }
        [ForeignKey(nameof(Job))]
        public int JobId { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public virtual Jobs Job { get; set; }
        public virtual Users User { get; set; }
    }
}
