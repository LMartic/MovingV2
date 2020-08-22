using Moving.Application.DataTransfer;
using Moving.Application.Queries;
using Moving.Application.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moving.Implementation.Extensions;
using AutoMapper;
using Moving.EfDataAccess;

namespace Moving.Implementation.Queries
{
    public class EfGetUseCaseLogsQuery : IGetUseCaseQuery
    {
        private readonly MovingContext context;
        private readonly IMapper _mapper;

        public EfGetUseCaseLogsQuery(MovingContext context, IMapper mapper)
        {
            this.context = context;
            _mapper = mapper;
        }

        public int Id => 9;

        public string Name => "Use Case Search";

        public PagedResponse<UseCaseDto> Execute(UseCaseSearch search)
        {
            var query = context.UseCaseLogs.AsQueryable();

            if (!string.IsNullOrEmpty(search.UserName) || !string.IsNullOrWhiteSpace(search.UserName))
            {
                query = query.Where(x => x.Actor.ToLower().Contains(search.UserName.ToLower()) && (x.Date >= search.FromDate && x.Date <= search.ToDate));
            }

            return query.Paged<UseCaseDto, Domain.UseCaseLog>(search, _mapper);
        }
    }
}
