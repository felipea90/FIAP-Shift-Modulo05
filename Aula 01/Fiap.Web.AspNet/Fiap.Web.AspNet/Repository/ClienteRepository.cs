using Fiap.Web.AspNet.Models;
using System;
using System.Collections.Generic;

namespace Fiap.Web.AspNet.Repository
{
    public class ClienteRepository
    {
        //private readonly Object context;
        private readonly IList<ClienteModel> listaClientes;

        public ClienteRepository()
        {
            //listaClientes = new List<ClienteModel>();

            //context = new Context;
            listaClientes = new List<ClienteModel>
            {
                new ClienteModel(1, "Flávio", "flavio@email.com", DateTime.Parse("1989-09-01"), "Observação 1", 4),
                new ClienteModel(2, "Eduardo", "eduardo@email.com", DateTime.Parse("1993-12-01"), "Observação 2", 3),
                new ClienteModel(3, "Moreni", "moreni@email.com",DateTime.Parse("1980-07-08"), "Observação 3", 2),
                new ClienteModel(4, "João", "joao@email.com",DateTime.Parse("1988-02-12"), "Observação 4", 1)
            };
        }

        public IList<ClienteModel> FindAll()
        {
            Console.WriteLine($"Cliente repository - FindAll");
            return listaClientes;
        }

        public ClienteModel FindById(int id)
        {
            Console.WriteLine($"Cliente repository - FindById Cliente: {id}");

            if (id > listaClientes.Count)
            {
                throw new Exception("Cliente não encontrado");
            }
            else
            {
                return listaClientes[id - 1];
            }

        }

        public int Insert(ClienteModel clienteModel)
        {
            Console.WriteLine($"Cliente repository - Insert Cliente: {clienteModel.Nome}");

            listaClientes.Add(clienteModel);
            return new Random().Next();
        }

        public void Delete(int id)
        {
            Console.WriteLine($"Cliente repository - Delete Id: {id}");
        }

        public void Update(ClienteModel clienteModel)
        {
            Console.WriteLine($"Cliente repository - Update Cliente: {clienteModel.Nome}");
        }
    }
}
