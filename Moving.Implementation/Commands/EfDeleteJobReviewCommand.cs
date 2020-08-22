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
    public class EfDeleteJobReviewCommand : IDeleteJobReviewCommand
    {
        private readonly MovingContext _context;

        public EfDeleteJobReviewCommand(MovingContext context)
        {
            this._context = context;
        }

        public int Id => 14;

        public string Name => "Delete Job Review";

        public void Execute(int request)
        {
            var jobReview = _context.JobReviews.Find(request);

            if (jobReview == null)
            {
                throw new EntityNotFoundException(request, typeof(JobReviews));
            }
            jobReview.IsDeleted = true;
            _context.Entry(jobReview).State = EntityState.Modified;

            _context.SaveChanges();
        }
    }
}
