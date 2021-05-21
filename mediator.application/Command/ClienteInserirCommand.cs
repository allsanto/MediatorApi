using MediatR;

namespace mediator.application.Command
{
    public class ClienteInserirCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
