using Moving.Application;
using Moving.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moving.Api.Core
{
    public class JwtActor : IApplicationActor
    {
        public int Id { get; set; }

        public string Identity { get; set; }
        public string RoleName { get; set; }
        public List<string> Permissions { get; set; }
    }
}
