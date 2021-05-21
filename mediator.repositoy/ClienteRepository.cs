using mediator.repositoy.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mediator.repositoy
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> ListarPor(string nome);
        Task<int> Inserir(Cliente obj);
    }

    public class ClienteRepository : IClienteRepository
    {
        public Task<int> Inserir(Cliente obj)
        {
            Console.WriteLine(obj.Id);

            return Task.FromResult(1);
        }

        public Task<IEnumerable<Cliente>> ListarPor(string nome)
        {
            var listar = new List<Cliente>();
            listar.Add(new Cliente { Id = 1, Nome = "João" });
            listar.Add(new Cliente { Id = 2, Nome = "Maria" });

            return Task.FromResult<IEnumerable<Cliente>>(listar);
        }
    }
}
