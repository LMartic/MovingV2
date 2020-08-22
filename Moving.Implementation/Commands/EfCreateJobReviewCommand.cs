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
    public class EfCreateJobReviewCommand : ICreateJobReviewCommand
    {

        private readonly MovingContext _context;
        private readonly CreateJobReviewValidator _validator;

        public EfCreateJobReviewCommand(MovingContext context, CreateJobReviewValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 13;

        public string Name => "Create New Job Review";


        public void Execute(JobReviewDto request)
        {
            _validator.ValidateAndThrow(request); //ValidationException
            var jobReview = new JobReviews()
            {
                Description = request.Description,
                JobId = request.JobId,
                UserId = request.UserId
            };
            _context.Entry(jobReview).State = EntityState.Added;
            _context.SaveChanges();
        }
    }
}
