using Fiap.Web.AspNet.Data;
using Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fiap.Web.AspNet.Repository
{
    public class RepresentanteRepository
    {
        private readonly DataContext context;

        public RepresentanteRepository()
        {
            context = new DataContext();
        }

        public IList<RepresentanteModel> FindAll()
        {
            var lista = context.Representantes.ToList();
            return lista;
        }

        public RepresentanteModel FindById(int id)
        {
            var representante = context.Representantes.Find(id);

            return representante;
        }

        public RepresentanteModel FindByIdWithClientes(int id)
        {
            var representante = context.Representantes
                .Include(c => c.Clientes)
                .SingleOrDefault(c => c.RepresentanteId == id);

            return representante;
        }

        public void Insert(RepresentanteModel representante)
        {
            context.Representantes.Add(representante);
            context.SaveChanges();
        }

        public void Update(RepresentanteModel representante)
        {
            context.Representantes.Update(representante);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Representantes.Remove(FindById(id));
            context.SaveChanges();
        }

        //public void Delete(int id)
        //{
        //    RepresentanteModel representanteModel = new RepresentanteModel();
        //    representanteModel.RepresentanteId = id;

        //    Delete(representanteModel);
        //}

        //public void Delete(RepresentanteModel representanteModel)
        //{
        //    context.Representante.Remove(representanteModel);
        //    context.SaveChanges();
        //}
    }
}
