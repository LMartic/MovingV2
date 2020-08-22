using AutoMapper;
using Moving.Application.DataTransfer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Implementation.Profiles
{
    public class UseCaseProfile : Profile
    {
        public UseCaseProfile()
        {
            CreateMap<Domain.UseCaseLog, UseCaseDto>();
            CreateMap<Domain.UseCaseLog, UseCaseDto>().ReverseMap();
        }
    }
}
