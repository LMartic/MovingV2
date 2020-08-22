using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Moving.Application.Email
{
    public interface IEmailSender
    {
        Task Send(SendEmailDto dto);
    }

    public class SendEmailDto
    {
        public string Subject { get; set; }
        public string Content { get; set; }
        public string SendTo { get; set; }
    }
}
