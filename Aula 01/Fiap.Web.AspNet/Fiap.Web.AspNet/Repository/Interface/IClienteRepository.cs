using Fiap.Web.AspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Repository.Interface
{
    public interface IClienteRepository
    {
        public IList<ClienteModel> FindAll();

        public IList<ClienteModel> FindByEmailOrRepresentante(string email, int repId);

        public ClienteModel FindById(int id);

        public int Insert(ClienteModel cliente);

        public void Update(ClienteModel cliente);

        public void Delete(int id);
    }
}
