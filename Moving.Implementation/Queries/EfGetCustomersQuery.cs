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
    public class EfGetCustomersQuery : IGetCustomersQuery
    {
        private readonly MovingContext context;
        private readonly IMapper _mapper;

        public EfGetCustomersQuery(MovingContext context, IMapper mapper)
        {
            this.context = context;
            _mapper = mapper;
        }

        public int Id => 4;

        public string Name => "Customer search";

        public PagedResponse<CustomerDto> Execute(CustomerSearch search)
        {
            var query = context.Customers.AsQueryable();

            if (!string.IsNullOrEmpty(search.Name) || !string.IsNullOrWhiteSpace(search.Name))
            {
                query = query.Where(x => x.FirstName.ToLower().Contains(search.Name.ToLower()));
            }

            return query.Paged<CustomerDto, Domain.Customers>(search, _mapper);
        }
    }
}
