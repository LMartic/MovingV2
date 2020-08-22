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
    public class CustomersController : ControllerBase
    {
        private readonly UseCaseExecutor executor;

        public CustomersController(UseCaseExecutor executor)
        {
            this.executor = executor;
        }

        // GET: api/Test
        [HttpGet]
        public IActionResult Get(
            [FromQuery] CustomerSearch search,
            [FromServices] IGetCustomersQuery query)
        {
            return Ok(executor.ExecuteQuery(query, search));
        }

        // POST: api/Test
        [HttpPost]
        public IActionResult Post([FromBody] CustomerDto dto,
            [FromServices] ICreateCustomerCommand command)
        {
            executor.ExecuteCommand(command, dto);
            return Ok(new { StatusCode = HttpStatusCode.OK, Message = "New Customer Created" });
        }

        // PUT: api/Test/5
        [HttpPut]
        public IActionResult Put([FromBody] CustomerDto dto, [FromServices] IUpdateCustomerCommand command)
        {
            executor.ExecuteCommand(command, dto);
            return Ok(new { StatusCode = HttpStatusCode.OK, Message = "Customer updated" });
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteCustomerCommand command)
        {
            executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}
