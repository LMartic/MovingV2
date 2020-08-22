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
using Moving.Application.DataTransfer;
using Moving.Application.Queries;
using Moving.Application.Searches;

namespace Moving.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UseCaseController : ControllerBase
    {
        private readonly UseCaseExecutor executor;

        public UseCaseController(UseCaseExecutor executor)
        {
            this.executor = executor;
        }

        // GET: api/Test
        [HttpGet]
        public IActionResult Get(
            [FromQuery] UseCaseSearch search,
            [FromServices] IGetUseCaseQuery query)
        {
            return Ok(executor.ExecuteQuery(query, search));
        }

        
    }
}
