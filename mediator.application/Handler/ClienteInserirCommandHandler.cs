using AutoMapper;
using mediator.repositoy;
using mediator.application.Command;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using mediator.repositoy.Entity;

namespace mediator.application.Handler
{
    public class ClienteInserirCommandHandler : IRequestHandler<ClienteInserirCommand, int>
    {
        private readonly IClienteRepository _rep;
        IMapper _mapper;
        public ClienteInserirCommandHandler(IClienteRepository rep, IMapper mapper)
        {
            _mapper = mapper;
            _rep = rep;
        }

        public async Task<int> Handle(ClienteInserirCommand cmd, CancellationToken cancellationToken)
        {
            var cliente = new Cliente { Id = cmd.Id, Nome = cmd.Nome };

            return await _rep.Inserir(cliente);
        }
    }
}
