using Fiap.Web.AspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Repository.Interface
{
    public interface ILojaRepository
    {
        public IList<LojaModel> FindAll();

        public LojaModel FindById(int id);

        public int Insert(LojaModel loja);

        public void Update(LojaModel loja);

        public void Delete(int id);
    }
}
