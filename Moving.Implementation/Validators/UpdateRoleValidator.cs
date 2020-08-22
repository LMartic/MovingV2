using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;
using Moving.Application.DataTransfer;
using Moving.EfDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moving.Implementation.Validators
{
    public class UpdateRoleValidator : AbstractValidator<RoleDto>
    {

        public UpdateRoleValidator(MovingContext context)
        {
            RuleFor(x => x.Id).NotEmpty().GreaterThan(0).Must(x => context.Roles.Any(role => role.Id == x)).WithMessage("Role Id does not exist");
            RuleFor(x => x.RoleName).NotEmpty()
                .WithMessage("Role name must not be empty");
            RuleFor(x => x.PerimissionIds).NotEmpty().Must(x => x.All(d => context.Permissions.Any(f => f.Id == d))).WithMessage("Permission does not exist"); 
        }
    }
}
