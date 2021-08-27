using Fiap.Web.AspNet.Data;
using Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fiap.Web.AspNet.Repository
{
    public class ClienteRepository
    {
        private readonly DataContext _context;

        public ClienteRepository()
        {
            _context = new DataContext();
        }

        public IList<ClienteModel> FindAll()
        {
            var lista = _context.Clientes.ToList();
            return lista;
        }

        public ClienteModel FindById(int id)
        {
            var cliente = _context.Clientes
                .Include(c => c.Representante)
                .SingleOrDefault(c => c.ClienteId == id);

            return cliente;
        }

        //public void Insert(ClienteModel cliente)
        //{
        //    context.Clientes.Add(cliente);
        //    context.SaveChanges();
        //}

        public int Insert(ClienteModel cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return cliente.ClienteId;
        }

        public void Update(ClienteModel cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            //context.Clientes.Remove(FindById(id));
            _context.Clientes.Remove(new ClienteModel() { ClienteId = id });
            _context.SaveChanges();
        }
    }
}
