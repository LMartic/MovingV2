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
    public class RolesController : ControllerBase
    {
        private readonly UseCaseExecutor executor;
        private readonly IApplicationActor _actor;

        public RolesController(UseCaseExecutor executor, IApplicationActor actor)
        {
            this.executor = executor;
            _actor = actor;
        }

        // GET: api/Test
        [HttpGet]
        public IActionResult Get(
            [FromQuery] RoleSearch search,
            [FromServices] IGetRolesQuery query)
        {
            return Ok(executor.ExecuteQuery(query, search));
        }

        // POST: api/Test
        [HttpPost]
        public IActionResult Post([FromBody] RoleDto dto,
            [FromServices] ICreateRoleCommand command)
        {

            executor.ExecuteCommand(command, dto);
            return Ok(new { StatusCode = HttpStatusCode.OK, Message = "New Role Created" });
        }

        // PUT: api/Test/5
        [HttpPut]
        public IActionResult Put([FromBody] RoleDto dto, [FromServices] IUpdateRoleCommand command)
        {
            executor.ExecuteCommand(command, dto);
            return Ok(new { StatusCode = HttpStatusCode.OK, Message = "Role updated" });
        }

    }
}
