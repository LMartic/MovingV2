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
    public class EfCreateJobImageCommand : ICreateJobImageCommand
    {

        private readonly MovingContext _context;
        private readonly CreateJobImageValidator _validator;

        public EfCreateJobImageCommand(MovingContext context, CreateJobImageValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 5;

        public string Name => "Create New Job";

        public void Execute(JobImageDto request)
        {
            _validator.ValidateAndThrow(request); //ValidationException

            var jobImage = new JobImages
            {
                ImagePath = request.ImagePath,
                JobId = request.JobId
            };

            _context.Entry(jobImage).State = jobImage.Id > 0 ? EntityState.Modified : EntityState.Added;

            _context.SaveChanges();
        }
    }
}
