using mediator.dbo;
using MediatR;
using System.Collections.Generic;

namespace mediator.application.Command
{
    public class ClienteConsultarCommand : IRequest<IEnumerable<ClienteDto>>
    {
        public string Nome { get; set; }
    }
}
