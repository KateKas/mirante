using Microsoft.AspNetCore.Mvc;
using Questao5.Application.Queries.Requests;
using Questao5.Application.Queries.Responses;

namespace Questao5.Infrastructure.Services.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaCorrenteController : BaseApiController
    {

        [HttpGet("{idContaCorrente}")]
        public async Task<ActionResult<ContaCorrenteResponse>> GetContaCorrenteSaldo([FromRoute] string idContaCorrente)
        {
            try
            {
                var response = await Mediator.Send(new ContaCorrenteRequest(idContaCorrente));
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
