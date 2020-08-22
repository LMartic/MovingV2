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
    public class EfCreateRoleCommand : ICreateRoleCommand
    {

        private readonly MovingContext _context;
        private readonly CreateRoleValidator _validator;

        public EfCreateRoleCommand(MovingContext context, CreateRoleValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 11;

        public string Name => "Create New Role";

        public void Execute(RoleDto request)
        {
            _validator.ValidateAndThrow(request); //ValidationException
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
            _context.Entry(role).State = EntityState.Added;

            _context.SaveChanges();
        }
    }
}
