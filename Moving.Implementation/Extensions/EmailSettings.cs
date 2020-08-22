using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moving.Implementation.Extensions
{
    public class EmailSettings
    {
      
        public string SmtpServer { get; set; }
        public string SmtpPort { get; set; }
        public string SmtpUserName { get; set; }
        public string SmtpPassword { get; set; }
        public string FromEmailAddress { get; set; }
    }
}
