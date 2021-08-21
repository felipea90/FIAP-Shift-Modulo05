using Fiap.Web.AspNet.Data;
using Fiap.Web.AspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fiap.Web.AspNet.Repository
{
    public class ClienteRepository
    {
        private readonly DataContext context;

        public ClienteRepository()
        {
            context = new DataContext();
        }

        public IList<ClienteModel> FindAll()
        {
            var lista = context.Clientes.ToList();
            return lista;
        }

        public ClienteModel FindById(int id)
        {
            var cliente = context.Clientes.Find(id);
            return cliente;
        }

        //public void Insert(ClienteModel cliente)
        //{
        //    context.Clientes.Add(cliente);
        //    context.SaveChanges();
        //}

        public int Insert(ClienteModel cliente)
        {
            context.Clientes.Add(cliente);
            context.SaveChanges();
            return cliente.ClienteId;
        }

        public void Update(ClienteModel cliente)
        {
            context.Clientes.Update(cliente);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            //context.Clientes.Remove(FindById(id));
            context.Clientes.Remove(new ClienteModel() { ClienteId = id });
            context.SaveChanges();
        }
    }
}
