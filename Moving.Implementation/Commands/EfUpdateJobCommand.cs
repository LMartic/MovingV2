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
    public class EfUpdateJobCommand : IUpdateJobCommand
    {

        private readonly MovingContext _context;
        private readonly UpdateJobValidator _validator;

        public EfUpdateJobCommand(MovingContext context, UpdateJobValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 5;

        public string Name => "Update Job";

        public void Execute(JobDto request)
        {
            _validator.ValidateAndThrow(request); //ValidationException

            var job = new Jobs
            {
                CustomerId = request.CustomerId,
                Deposit = request.Deposit,
                JobStatusId = request.JobStatusId,
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
