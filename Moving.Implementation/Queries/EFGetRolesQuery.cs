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
    public class EFGetRolesQuery : IGetRolesQuery
    {
        private readonly MovingContext context;
        private readonly IMapper _mapper;

        public EFGetRolesQuery(MovingContext context, IMapper mapper)
        {
            this.context = context;
            _mapper = mapper;
        }

        public int Id => 10;

        public string Name => "Role Search";

        public PagedResponse<RoleDto> Execute(RoleSearch search)
        {
            var query = context.Roles.AsQueryable();

            if (!string.IsNullOrEmpty(search.RoleName) || !string.IsNullOrWhiteSpace(search.RoleName))
            {
                query = query.Where(x => x.RoleName.ToLower().Contains(search.RoleName.ToLower()));
            }

            return query.Paged<RoleDto, Domain.Roles>(search, _mapper);
        }
    }
}
