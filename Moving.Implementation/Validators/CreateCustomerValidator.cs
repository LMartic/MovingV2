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
    public class CreateCustomerValidator : AbstractValidator<CustomerDto>
    {

        public CreateCustomerValidator(MovingContext context)
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .MinimumLength(3)
                .WithMessage("Must be more than 3 characters");
            RuleFor(x => x.LastName)
                .NotEmpty()
                .MinimumLength(3)
                .WithMessage("Must be more than 3 characters");
            RuleFor(x=>x.Email)
                .NotEmpty()
                .EmailAddress()
                .Must(x => !context.Customers.Any(cust => cust.Email == x))
                .WithMessage("Email already exist in the database");
        }
    }
}
