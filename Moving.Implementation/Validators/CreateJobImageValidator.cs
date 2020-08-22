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
    public class CreateJobImageValidator : AbstractValidator<JobImageDto>
    {

        public CreateJobImageValidator(MovingContext context)
        {
            RuleFor(x => x.ImagePath).NotEmpty();
            RuleFor(x => x.JobId).NotEmpty()
                .Must(x => context.Jobs.Any(job => job.Id == x))
                .WithMessage("Job does not exist");
        }
    }
}
