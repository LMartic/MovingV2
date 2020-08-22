using Microsoft.EntityFrameworkCore;
using Moving.Application.Commands;
using Moving.Application.Exceptions;
using Moving.Domain;
using Moving.EfDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Implementation.Commands
{
    public class EfDeleteCustomerCommand : IDeleteCustomerCommand
    {
        private readonly MovingContext _context;

        public EfDeleteCustomerCommand(MovingContext context)
        {
            this._context = context;
        }

        public int Id => 3;

        public string Name => "Delete Customer";

        public void Execute(int request)
        {
            var customer = _context.Customers.Find(request);

            if (customer == null)
            {
                throw new EntityNotFoundException(request, typeof(Customers));
            }

            customer.IsDeleted = true;
            _context.Entry(customer).State = EntityState.Modified;

            _context.SaveChanges();
        }
    }
}
