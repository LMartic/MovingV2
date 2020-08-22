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
    public class EfDeleteJobCommand : IDeleteJobCommand
    {
        private readonly MovingContext _context;

        public EfDeleteJobCommand(MovingContext context)
        {
            this._context = context;
        }

        public int Id => 8;

        public string Name => "Delete Job";

        public void Execute(int request)
        {
            var job = _context.Jobs.Find(request);

            if (job == null)
            {
                throw new EntityNotFoundException(request, typeof(Jobs));
            }

            job.IsDeleted = true;
            _context.Entry(job).State = EntityState.Modified;

            _context.SaveChanges();
        }
    }
}
