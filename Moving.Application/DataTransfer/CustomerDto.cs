﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Application.DataTransfer
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
