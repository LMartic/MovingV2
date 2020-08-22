using AutoMapper;
using Moving.Application.DataTransfer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Implementation.Profiles
{
    public class JobProfile : Profile
    {
        public JobProfile()
        {
            CreateMap<Domain.JobImages, JobImageDto>();
            CreateMap<Domain.Jobs, JobDto>()
                .ForMember(destination => destination.JobImages, opts => opts.MapFrom(source => source.JobImages))
            .ForMember(destination => destination.CustomerName, opts => opts.MapFrom(source => string.Concat(source.Customer.FirstName, " ", source.Customer.LastName)))
            .ForMember(destination => destination.JobStatusName, opts => opts.MapFrom(source => source.JobStatus.JobStatus))
            .ForMember(destination => destination.JobTypeName, opts => opts.MapFrom(source => source.JobType.JobType))
            .ForMember(destination => destination.CreatedByUserName, opts => opts.MapFrom(source => string.Concat(source.CreatedByUser.FirstName, " ", source.CreatedByUser.LastName)));
        }
    }
}
