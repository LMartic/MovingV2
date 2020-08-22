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
    public class JobsController : ControllerBase
    {
        private readonly UseCaseExecutor executor;
        private readonly IApplicationActor _actor;

        public JobsController(UseCaseExecutor executor, IApplicationActor actor)
        {
            this.executor = executor;
            _actor = actor;
        }

        // GET: api/Test
        [HttpGet]
        public IActionResult Get(
            [FromQuery] JobSearch search,
            [FromServices] IGetJobsQuery query)
        {
            return Ok(executor.ExecuteQuery(query, search));
        }

        // POST: api/Test
        [HttpPost]
        public IActionResult Post([FromBody] JobDto dto,
            [FromServices] ICreateJobCommand command)
        {

            dto.CreatedByUserId = _actor.Id;
            dto.JobStatusId = (int)JobStatus.InProgress;
            executor.ExecuteCommand(command, dto);
            return Ok(new { StatusCode = HttpStatusCode.OK, Message = "New Job Created" });
        }

        // PUT: api/Test/5
        [HttpPut]
        public IActionResult Put([FromBody] JobDto dto, [FromServices] IUpdateJobCommand command)
        {
            executor.ExecuteCommand(command, dto);
            return Ok(new { StatusCode = HttpStatusCode.OK, Message = "Job updated" });
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteJobCommand command)
        {
            executor.ExecuteCommand(command, id);
            return NoContent();
        }
        [Route("image")]
        [HttpPost]
        public IActionResult PostImage([FromBody] JobImageDto dto,
          [FromServices] ICreateJobImageCommand command)
        {
            executor.ExecuteCommand(command, dto);
            return Ok(new { StatusCode = HttpStatusCode.OK, Message = "New Job Image Added" });

        }
    }
}
