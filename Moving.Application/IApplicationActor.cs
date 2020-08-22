using System.Collections.Generic;

namespace Moving.Application
{
    public interface IApplicationActor
    {
        int Id { get; }
        string Identity { get; }
        string RoleName { get; }
        List<string> Permissions { get; }
    }
}
