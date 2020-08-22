using AutoMapper;
using Moving.Application.DataTransfer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Implementation.Profiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<Domain.Roles, RoleDto>();
        }
    }
}
