using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Application
{
    public interface IUseCaseLogger
    {
        void Log(IUseCase userCase, IApplicationActor actor, object useCaseData);
    }
}
