using Fiap.Web.AspNet.Data;
using Fiap.Web.AspNet.Models;
using Fiap.Web.AspNet.Repository.Interface;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fiap.Web.AspNet.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext _context;

        public ClienteRepository(
            DataContext context)
        {
            _context = context;
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
        public IList<ClienteModel> FindByEmailOrRepresentante(string email, int repId)
        {
            var condition = PredicateBuilder.New<ClienteModel>(true);

            if (!String.IsNullOrWhiteSpace(email))
                condition = condition.And(c => c.Email == email);

            if (repId != 0)
                condition = condition.And(c => c.RepresentanteId == repId);

            var clientes = _context.Clientes.Include(c => c.Representante).Where(condition).ToList();

            //var clientes = _context.Clientes
            //    .Include(c => c.Representante)
            //    .Where(c => ("" == email || c.Email == email) && 
            //                (0 == repId || c.RepresentanteId == repId))
            //    .ToList();

            return clientes;
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
