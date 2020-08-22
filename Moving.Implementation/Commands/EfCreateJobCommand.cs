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
using System.Text;

namespace Moving.Implementation.Commands
{
    public class EfCreateJobCommand : ICreateJobCommand
    {

        private readonly MovingContext _context;
        private readonly CreateJobValidator _validator;

        public EfCreateJobCommand(MovingContext context, CreateJobValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 5;

        public string Name => "Create New Job";

        public void Execute(JobDto request)
        {
            _validator.ValidateAndThrow(request); //ValidationException

            var job = new Jobs
            {
                CustomerId = request.CustomerId,
                Deposit = request.Deposit,
                JobStatusId = 1,
                JobTypeId = request.JobTypeId,
                MinimumHours = request.MinimumHours,
                MoveDate = request.MoveDate,
                NumberOfMovers = request.NumberOfMovers,
                NumberOfTrucks = request.NumberOfTrucks,
                CreatedByUserId = request.CreatedByUserId,
                PricePerHour = request.PricePerHour,
                Pickup = false,
                Delivery = false,
                Id = request.Id
            };

            _context.Entry(job).State = job.Id > 0 ? EntityState.Modified : EntityState.Added;

            _context.SaveChanges();
        }
    }
}
