﻿using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Moving.Application.Commands;
using Moving.Application.DataTransfer;
using Moving.Application.Email;
using Moving.Domain;
using Moving.EfDataAccess;
using Moving.Implementation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moving.Implementation.Commands
{
    public class EfUpdateUserCommand : IUpdateUserCommand
    {
        public int Id => 4;

        public string Name => "User Registration";

        private readonly MovingContext _context;
        private readonly UpdateUserValidator _validator;
        private readonly IEmailSender _sender;

        public EfUpdateUserCommand(MovingContext context, UpdateUserValidator validator, IEmailSender sender)
        {
            _context = context;
            _validator = validator;
            _sender = sender;
        }

        public void Execute(UserDto request)
        {
            _validator.ValidateAndThrow(request);
            var exisitingRoles = _context.UserRoles.Where(o => o.UserId == request.Id).ToList();
            foreach (var item in exisitingRoles)
            {
                _context.Entry(item).State = EntityState.Deleted;
            }
            var user = new Users()
            {
                Id = request.Id,
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
        }
    }
}
