using Fiap.Web.AspNet.Data;
using Fiap.Web.AspNet.Models;
using Fiap.Web.AspNet.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Repository
{
    public class LojaRepository : ILojaRepository
    {
        private readonly DataContext _context;

        public LojaRepository(
            DataContext context)
        {
            _context = context;
        }

        public IList<LojaModel> FindAll()
        {
            var lista = _context.Lojas.ToList();
            return lista;
        }

        public LojaModel FindById(int id)
        {
            var loja = _context.Lojas
                .Include(l => l.ProdutoLoja)
                .ThenInclude(p => p.Produto)
                .SingleOrDefault(l => l.LojaId == id);

            return loja;
        }

        public int Insert(LojaModel loja)
        {
            _context.Lojas.Add(loja);
            _context.SaveChanges();
            return loja.LojaId;
        }

        public void Update(LojaModel loja)
        {
            _context.Lojas.Update(loja);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Lojas.Remove(new LojaModel() { LojaId = id });
            _context.SaveChanges();
        }
    }
}
