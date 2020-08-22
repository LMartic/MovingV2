using Moving.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moving.Core
{
    public class AnonymousActor : IApplicationActor
    {
        public int Id => 0;

        public string Identity => "Anonymus";

        public string RoleName => "Anonymus";
        public List<string> Permissions => new List<string>();
    }
}
