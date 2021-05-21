using AutoMapper;
using mediator.application.Command;
using mediator.dbo;
using mediator.repositoy;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace mediator.application.Handler
{
    public class ClienteConsultarCommandHandler : IRequestHandler<ClienteConsultarCommand, IEnumerable<ClienteDto>> //, IRequestHandler<ClienteInserirCommand, int>
    {
        private readonly IClienteRepository _rep;
        IMapper _mapper;
        public ClienteConsultarCommandHandler(IClienteRepository rep, IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClienteDto>> Handle(ClienteConsultarCommand query, CancellationToken cancellationToken) // CancellationToken - Feito para abortar uma operação de um Token.
        {
            var clientes = await _rep.ListarPor(query.Nome);

            return await Task.FromResult(_mapper.Map<List<ClienteDto>>(clientes));
        }

    }
}
