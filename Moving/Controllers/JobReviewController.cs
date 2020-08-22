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
    public class JobReviewController : ControllerBase
    {
        private readonly UseCaseExecutor executor;
        private readonly IApplicationActor _actor;

        public JobReviewController(UseCaseExecutor executor, IApplicationActor actor)
        {
            this.executor = executor;
            _actor = actor;
        }


        // POST: api/Test
        [HttpPost]
        public IActionResult Post([FromBody] JobReviewDto dto,
            [FromServices] ICreateJobReviewCommand command)
        {

            dto.UserId = _actor.Id;
            executor.ExecuteCommand(command, dto);
            return Ok(new { StatusCode = HttpStatusCode.OK, Message = "New Job Review Created" });
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteJobReviewCommand command)
        {
            executor.ExecuteCommand(command, id);
            return NoContent();
        }
        // GET: api/Test
        [HttpGet]
        public IActionResult Get(
            [FromQuery] JobReviewSearch search,
            [FromServices] IGetJobReviewsQuery query)
        {
            return Ok(executor.ExecuteQuery(query, search));
        }
    }
}
