using AutoMapper;
using Moving.Application.DataTransfer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Implementation.Profiles
{
    public class JobReviewProfile : Profile
    {
        public JobReviewProfile()
        {
            CreateMap<Domain.JobReviews, JobReviewDto>()
                .ForMember(destination => destination.CreatedByCustomerName, opts => opts.MapFrom(source => string.Concat(source.Job.Customer.FirstName, " With Id of:", source.Job.CustomerId)));
            
        }
    }
}
