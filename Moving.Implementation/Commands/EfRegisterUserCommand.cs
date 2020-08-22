using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Moving.Application.Commands;
using Moving.Application.DataTransfer;
using Moving.Application.Email;
using Moving.Domain;
using Moving.EfDataAccess;
using Moving.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moving.Implementation.Commands
{
    public class EfRegisterUserCommand : IRegisterUserCommand
    {
        public int Id => 4;

        public string Name => "User Registration";

        private readonly MovingContext _context;
        private readonly RegisterUserValidator _validator;
        private readonly IEmailSender _sender;

        public EfRegisterUserCommand(MovingContext context, RegisterUserValidator validator, IEmailSender sender)
        {
            _context = context;
            _validator = validator;
            _sender = sender;
        }

        public void Execute(RegisterUserDto request)
        {
            _validator.ValidateAndThrow(request);
            var user = new Users()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                Password = request.Password,
                Email = request.Email
            };
            var model = new UserRoles()
            {
                RoleId = request.RoleId,
                UserId = user.Id
            };
            user.UserRoles.Add(model);
            _context.Entry(model).State = EntityState.Added;
            _context.Entry(user).State = user.Id > 0 ? EntityState.Modified : EntityState.Added;
            _context.SaveChanges();
            _sender.Send(new SendEmailDto
            {
                Content = "<h1>Successfull registration!</h1>",
                SendTo = request.Email,
                Subject = "Registration"
            });
        }
    }
}
