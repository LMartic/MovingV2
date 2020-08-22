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
    public class EfUpdateCustomerCommand : IUpdateCustomerCommand
    {

        private readonly MovingContext _context;
        private readonly UpdateCustomerValidator _validator;

        public EfUpdateCustomerCommand(MovingContext context, UpdateCustomerValidator validator)
        {
            _context = context;
            _validator = validator;
        }

        public int Id => 3;

        public string Name => "Update Customer";

        public void Execute(CustomerDto request)
        {
            _validator.ValidateAndThrow(request); //ValidationException

            var customer = new Customers
            {
                FirstName = request.FirstName,
                Email = request.Email,
                LastName = request.LastName,
                Phone = request.Phone,
                Id = request.Id

            };

            _context.Entry(customer).State = customer.Id > 0 ? EntityState.Modified : EntityState.Added;

            _context.SaveChanges();
        }
    }
}
