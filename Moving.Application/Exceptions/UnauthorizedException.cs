using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Application.Exceptions
{
    public class UnauthorizedException : Exception
    {
        public UnauthorizedException(IUseCase useCase, IApplicationActor actor)
            : base($"Actor with an id of {actor.Id} - {actor.Identity} tried to execute {useCase.Name}.")
        {

        }
    }
}
