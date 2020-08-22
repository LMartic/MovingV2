using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;
using Moving.Application.DataTransfer;
using Moving.EfDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Moving.Implementation.Validators
{
    public class RegisterUserValidator : AbstractValidator<RegisterUserDto>
    {

        public RegisterUserValidator(MovingContext context)
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(6);

            RuleFor(x => x.UserName)
                .NotEmpty()
                .MinimumLength(4)
                .Must(x => !context.Users.Any(user => user.UserName == x))
                .WithMessage("Username is already taken.");

            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress()
                 .Must(x => !context.Users.Any(user => user.Email == x))
                .WithMessage("Email is already taken.");

            RuleFor(x => x.RoleId)
                .NotEmpty()
                .Must(id => context.Roles.Any(x => x.Id == id))
                .WithMessage("Role does not exist.");


        }
    }
}
