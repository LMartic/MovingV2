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
    public class CreateJobValidator : AbstractValidator<JobDto>
    {

        public CreateJobValidator(MovingContext context)
        {
            RuleFor(x => x.MoveDate).NotEmpty()
                .Must(o => o.AddDays(30) > o);
            RuleFor(x => x.JobTypeId).NotEmpty()
                .Must(x => context.JobTypes.Any(user => user.Id == x))
                .WithMessage("Job Type does not exist");
            RuleFor(x => x.MinimumHours)
                .NotEmpty()
                .GreaterThanOrEqualTo(3)
                .WithMessage("Minimum hours must be 3 or more");
            RuleFor(x => x.NumberOfMovers)
                .NotEmpty()
                .InclusiveBetween(2, 10)
                .WithMessage("Minimum number of movers is 2, maximum is 10");
            RuleFor(x => x.NumberOfTrucks)
                .NotEmpty()
                .InclusiveBetween(1, 3)
                .WithMessage("Minimum number of truck is 1, maximum is 3"); ;
            RuleFor(x => x.PricePerHour).NotEmpty();
            RuleFor(x => x.CustomerId).NotEmpty()
                .Must(x => context.Customers.Any(user => user.Id == x))
                .WithMessage("Customer does not exist");
        }
    }
}
