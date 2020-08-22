using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Moving.Application.Commands;
using Moving.Application.Commands;
using Moving.Application.DataTransfer;
using Moving.Domain;
using Moving.EfDataAccess;
using Moving.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moving.Implementation.Commands
{
    public class EfUpdateRoleCommand : IUpdateRoleCommand
    {

        private readonly MovingContext _context;
        private readonly UpdateRoleValidator _validator;

        public EfUpdateRoleCommand(MovingContext context, UpdateRoleValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 12;

        public string Name => "Update Role";

        public void Execute(RoleDto request)
        {
            _validator.ValidateAndThrow(request); //ValidationException
            var exisitingPermissions = _context.RolePermissions.Where(o => o.RoleId == request.Id).ToList();
            foreach (var item in exisitingPermissions)
            {
                _context.Entry(item).State = EntityState.Deleted;
            }
            var role = new Roles()
            {
                Id = request.Id,
                RoleName = request.RoleName
            };
            foreach (var item in request.PerimissionIds)
            {
                var rolePermission = new RolePermissions()
                {
                    PermissionId = item,
                    RoleId = request.Id
                };
                _context.Entry(rolePermission).State = EntityState.Added;
            }
            _context.Entry(role).State = EntityState.Modified;

            _context.SaveChanges();
        }
    }
}
