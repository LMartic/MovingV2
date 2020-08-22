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
using Microsoft.EntityFrameworkCore;

namespace Moving.Implementation.Queries
{
    public class EfGetJobsQuery : IGetJobsQuery
    {
        private readonly MovingContext context;
        private readonly IMapper _mapper;

        public EfGetJobsQuery(MovingContext context, IMapper mapper)
        {
            this.context = context;
            _mapper = mapper;
        }

        public int Id => 4;

        public string Name => "Job search";

        public PagedResponse<JobDto> Execute(JobSearch search)
        {
            var query = context.Jobs.Include(o => o.Customer).Include(o => o.JobImages).Include(o => o.CreatedByUser).Include(o => o.JobStatus).Include(o => o.JobType).AsQueryable();

            if (!string.IsNullOrEmpty(search.CustomerName) || !string.IsNullOrWhiteSpace(search.CustomerName))
            {
                query = query.Where(x => x.Customer.FirstName.ToLower().Contains(search.CustomerName.ToLower()) || x.Customer.LastName.ToLower().Contains(search.CustomerName.ToLower()));
            }

            return query.Paged<JobDto, Domain.Jobs>(search, _mapper);
        }
    }
}
