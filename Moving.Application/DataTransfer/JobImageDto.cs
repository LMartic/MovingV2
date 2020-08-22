using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Application.DataTransfer
{
    public class JobImageDto
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public int JobId { get; set; }
    }
}
