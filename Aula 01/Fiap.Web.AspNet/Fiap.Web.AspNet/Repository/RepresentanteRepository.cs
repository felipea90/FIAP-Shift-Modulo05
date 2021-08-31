using Fiap.Web.AspNet.Data;
using Fiap.Web.AspNet.Models;
using Fiap.Web.AspNet.Repository.Interface;
using Fiap.Web.AspNet.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fiap.Web.AspNet.Repository
{
    public class RepresentanteRepository : IRepresentanteRepository
    {
        private readonly DataContext _context;

        public RepresentanteRepository(
            DataContext context)
        {
            _context = context;
        }

        public IList<RepresentanteModel> FindAll()
        {
            var lista = _context.Representantes.ToList();
            return lista;
        }

        public RepresentanteModel FindById(int id)
        {
            var representante = _context.Representantes.Find(id);

            return representante;
        }

        public RepresentanteModel FindByIdWithClientes(int id)
        {
            var representante = _context.Representantes
                .Include(c => c.Clientes)
                .SingleOrDefault(c => c.RepresentanteId == id);

            return representante;
        }

        public void Insert(RepresentanteModel representante)
        {
            _context.Representantes.Add(representante);
            _context.SaveChanges();
        }

        public void Update(RepresentanteModel representante)
        {
            _context.Representantes.Update(representante);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Representantes.Remove(FindById(id));
            _context.SaveChanges();
        }

        //public void Delete(int id)
        //{
        //    RepresentanteModel representanteModel = new RepresentanteModel();
        //    representanteModel.RepresentanteId = id;

        //    Delete(representanteModel);
        //}

        //public void Delete(RepresentanteModel representanteModel)
        //{
        //    _context.Representante.Remove(representanteModel);
        //    _context.SaveChanges();
        //}
    }
}
