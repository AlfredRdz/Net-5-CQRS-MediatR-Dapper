using AppCQRSMedia.Application.Commands.DeletePersona;
using AppCQRSMedia.Application.Queries.GetPersonas;
using AppCQRSMedia.Commands.AddPersona;
using AppCQRSMedia.Commands.UpdatePersona;
using AppCQRSMedia.CQRS.Application.Queries;
using AppCQRSMedia.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCQRSMedia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IPersonaQueries _personaQueries;

        public PersonController(IMediator mediator, IPersonaQueries personaQueries)
        {
            _mediator = mediator;
            _personaQueries = personaQueries;
        }

        [HttpGet]
        public async Task<IActionResult> getPersonasAll()
        {
            try
            {
                var personas = await _personaQueries.GetPersonas();
                return Ok(personas);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return NotFound();
            }
            //return StatusCode(StatusCodes.Status200OK, await _mediator.Send(new GetPersonasQuery()));
        }

        [HttpGet]
        [Route("{PersonId}")]
        public async Task<IActionResult> GetProductById([FromRoute] int PersonId)
        {
            try
            {
                var personas = await _personaQueries.GetPersonasById(PersonId);
                return Ok(personas);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return NotFound();
            }
        }


        [HttpPost]
        public async Task<ActionResult> CreateProduct([FromBody] AddPersonaCommand command)
        {
            try
            {
                var isSuccess = await _mediator.Send(command);
                if (!isSuccess)
                {
                    return BadRequest();
                }

                return Ok();
            }
            catch(Exception e)
            {
                return NotFound(e.Message + "Not Found");
            }
           
        }


        [HttpPut]
        public async Task<ActionResult> UpdatePersona([FromBody] AddPersonaCommand command)
        {
            try
            {
                var isSuccess = await _mediator.Send(command);
                if (!isSuccess)
                {
                    return BadRequest();
                }

                return Ok();
                //return StatusCode(StatusCodes.Status200OK, await _mediator.Send(command));
            }
            catch (Exception e)
            {
                return NotFound(e.Message + "Not Found");
            }
        }

        [HttpDelete]
        [Route("{PersonId}")]
        public async Task<ActionResult> DeletePersona([FromRoute] DeletePersonaCommand command)
        {
            try
            {
                var isSuccess = await _mediator.Send(command);
                if (!isSuccess)
                {
                    return BadRequest();
                }

                return Ok();
                //return StatusCode(StatusCodes.Status204NoContent, await _mediator.Send(command));
            }
            catch (Exception e)
            {
                return NotFound(e.Message + "Not Found");
            }
        }
    }
}
