using mediator.application.Command;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MediatorApi.Controllers
{
    /// <summary>
    /// API DE CLIENTES
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        /// <summary>
        /// CONSTRUTOR DA CLASSE DE CLIENTE
        /// </summary>
        /// <param name="mediator"></param>
        private IMediator _mediator;
        public ClienteController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// CONSULTAR CLIENTE PELO NOME
        /// </summary>
        /// <param name="filter"></param>
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] ClienteConsultarCommand filter)
        {
            try
            {
                return Ok(await _mediator.Send(filter));
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// PERSISTIR CLIENTE
        /// </summary>
        /// <param name="command">
        [HttpPost]
        public async Task<IActionResult> Post([FromQuery] ClienteInserirCommand command)   
        {
            try
            {
                return Ok(await _mediator.Send(command));
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

    }
}
