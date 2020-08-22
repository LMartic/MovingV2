using AutoMapper;
using Moving.Application.DataTransfer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Implementation.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Domain.Customers, CustomerDto>();
            CreateMap<Domain.Customers, CustomerDto>().ReverseMap();
        }
    }
}
