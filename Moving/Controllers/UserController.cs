using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moving.Application;
using Moving.Application.Commands;
using Moving.Api.Core;
using Moving.Application.DataTransfer;
using Moving.Application.Queries;
using Moving.Application.Searches;
using Moving.Implementation.Enums;

namespace Moving.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UseCaseExecutor executor;
        private readonly IApplicationActor _actor;

        public UserController(UseCaseExecutor executor, IApplicationActor actor)
        {
            this.executor = executor;
            _actor = actor;
        }

        // PUT: api/Test/5
        [HttpPut]
        public IActionResult Put([FromBody] UserDto dto, [FromServices] IUpdateUserCommand command)
        {
            executor.ExecuteCommand(command, dto);
            return Ok(new { StatusCode = HttpStatusCode.OK, Message = "User updated" });
        }
    }
}
