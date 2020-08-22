using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Application
{
    //CQRS - Command Query Responsibility Seggregation

    //CQS
    public interface ICommand<TRequest> : IUseCase
    {
        void Execute(TRequest request);
    }

    public interface IQuery<TSearch, TResult> : IUseCase
    {
        TResult Execute(TSearch search);
    }

    public interface IUseCase
    {
        int Id { get; }
        string Name { get; }
    }
}


