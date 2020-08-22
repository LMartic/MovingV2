using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Application.DataTransfer
{
    public class JobReviewDto
    {
        public JobReviewDto()
        {

        }
        public string Description { get; set; }
        public int JobId { get; set; }
        public int UserId { get; set; }
        public string CreatedByCustomerName { get; set; }
        
    }
}
