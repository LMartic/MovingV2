using Moving.Application.Exceptions;
using System;
using System.Linq;

namespace Moving.Application
{
    public class UseCaseExecutor
    {
        private readonly IApplicationActor actor;
        private readonly IUseCaseLogger logger;

        public UseCaseExecutor(IApplicationActor actor, IUseCaseLogger logger)
        {
            this.actor = actor;
            this.logger = logger;
        }

        public TResult ExecuteQuery<TSearch, TResult>(IQuery<TSearch, TResult> query, TSearch search)
        {
            logger.Log(query, actor, search);

            if (!actor.Permissions.Contains(query.Name))
            {
                throw new UnauthorizedException(query, actor);
            }

            return query.Execute(search);
        }
        public void ExecuteRegisterCommand<TRequest>(
           ICommand<TRequest> command,
           TRequest request)
        {
            logger.Log(command, actor, request);
            command.Execute(request);

        }
        public void ExecuteCommand<TRequest>(
            ICommand<TRequest> command,
            TRequest request)
        {
            logger.Log(command, actor, request);
            if (!actor.Permissions.Contains(command.Name))
            {
                throw new UnauthorizedException(command, actor);
            }

            command.Execute(request);

        }

    }
}
