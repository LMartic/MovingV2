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
    public class EfGetJobReviewQuery : IGetJobReviewsQuery
    {
        private readonly MovingContext context;
        private readonly IMapper _mapper;

        public EfGetJobReviewQuery(MovingContext context, IMapper mapper)
        {
            this.context = context;
            _mapper = mapper;
        }

        public int Id => 15;

        public string Name => "JobReview Search";

        public PagedResponse<JobReviewDto> Execute(JobReviewSearch search)
        {
            var query = context.JobReviews.Include(u => u.Job).ThenInclude(c => c.Customer).AsQueryable();

            if (!string.IsNullOrEmpty(search.CustomerName) || !string.IsNullOrWhiteSpace(search.CustomerName))
            {
                query = query.Where(x => x.Job.Customer.FirstName.ToLower().Contains(search.CustomerName.ToLower()));
            }

            return query.Paged<JobReviewDto, Domain.JobReviews>(search, _mapper);
        }
    }
}
