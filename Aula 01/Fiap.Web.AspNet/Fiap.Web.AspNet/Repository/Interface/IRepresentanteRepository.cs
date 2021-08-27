using Fiap.Web.AspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Repository.Interface
{
    public interface IRepresentanteRepository
    {
        public IList<RepresentanteModel> FindAll();

        public RepresentanteModel FindById(int id);

        public RepresentanteModel FindByIdWithClientes(int id);

        public void Insert(RepresentanteModel representante);

        public void Update(RepresentanteModel representante);

        public void Delete(int id);
    }
}
