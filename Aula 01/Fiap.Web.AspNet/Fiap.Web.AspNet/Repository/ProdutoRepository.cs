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
    public class ProdutoRepository
    {
        private readonly DataContext context;

        public ProdutoRepository()
        {
            context = new DataContext();
        }

        public IList<ProdutoModel> FindAll()
        {
            var lista = context.Produtos.ToList();
            return lista;
        }

        public ProdutoModel FindById(int id)
        {
            var produto = context.Produtos
                .Include(p => p.ProdutoLoja)
                .ThenInclude(l => l.Loja)
                .SingleOrDefault(p => p.ProdutoId == id);

            return produto;
        }

        public int Insert(ProdutoModel produto)
        {
            context.Produtos.Add(produto);
            context.SaveChanges();
            return produto.ProdutoId;
        }

        public void Update(ProdutoModel produto)
        {
            context.Produtos.Update(produto);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Produtos.Remove(new ProdutoModel() { ProdutoId = id });
            context.SaveChanges();
        }
    }
}
