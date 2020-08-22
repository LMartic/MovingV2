using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moving.Application;
using Moving.Application.Commands;
using Moving.Application.DataTransfer;

namespace Moving.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public RegisterController(UseCaseExecutor executor) => _executor = executor;


        // POST: api/Register
        [HttpPost]
        public IActionResult Post(
            [FromBody] RegisterUserDto dto,
            [FromServices] IRegisterUserCommand command)
        {
            _executor.ExecuteRegisterCommand(command, dto);
            return Ok(new { StatusCode = HttpStatusCode.OK, Message = "Successfully registered" });
        }
    }
}
