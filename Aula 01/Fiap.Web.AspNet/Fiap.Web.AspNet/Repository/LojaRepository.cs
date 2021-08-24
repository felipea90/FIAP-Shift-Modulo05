using Fiap.Web.AspNet.Data;
using Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Repository
{
    public class LojaRepository
    {
        private readonly DataContext context;

        public LojaRepository()
        {
            context = new DataContext();
        }

        public IList<LojaModel> FindAll()
        {
            var lista = context.Lojas.ToList();
            return lista;
        }

        public LojaModel FindById(int id)
        {
            var loja = context.Lojas
                .Include(l => l.ProdutoLoja)
                .ThenInclude(p => p.Produto)
                .SingleOrDefault(l => l.LojaId == id);

            return loja;
        }

        public int Insert(LojaModel loja)
        {
            context.Lojas.Add(loja);
            context.SaveChanges();
            return loja.LojaId;
        }

        public void Update(LojaModel loja)
        {
            context.Lojas.Update(loja);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Lojas.Remove(new LojaModel() { LojaId = id });
            context.SaveChanges();
        }
    }
}
