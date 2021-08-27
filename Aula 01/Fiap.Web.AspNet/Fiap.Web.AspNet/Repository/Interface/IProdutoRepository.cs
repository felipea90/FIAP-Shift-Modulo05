using Fiap.Web.AspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Repository.Interface
{
    public interface IProdutoRepository
    {
        public IList<ProdutoModel> FindAll();

        public ProdutoModel FindById(int id);

        public int Insert(ProdutoModel produto);

        public void Update(ProdutoModel produto);

        public void Delete(int id);
    }
}
