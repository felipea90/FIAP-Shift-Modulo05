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
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DataContext _context;

        public ProdutoRepository(
            DataContext context)
        {
            _context = context;
        }

        public IList<ProdutoModel> FindAll()
        {
            var lista = _context.Produtos.ToList();
            return lista;
        }

        public ProdutoModel FindById(int id)
        {
            var produto = _context.Produtos
                .Include(p => p.ProdutoLoja)
                .ThenInclude(l => l.Loja)
                .SingleOrDefault(p => p.ProdutoId == id);

            return produto;
        }

        public int Insert(ProdutoModel produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return produto.ProdutoId;
        }

        public void Update(ProdutoModel produto)
        {
            var produtoAtual = FindById(produto.ProdutoId);

            produtoAtual.NomeProduto = produto.NomeProduto;
            produtoAtual.ProdutoLoja = produto.ProdutoLoja;

            _context.Produtos.Update(produtoAtual);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Produtos.Remove(new ProdutoModel() { ProdutoId = id });
            _context.SaveChanges();
        }
    }
}
