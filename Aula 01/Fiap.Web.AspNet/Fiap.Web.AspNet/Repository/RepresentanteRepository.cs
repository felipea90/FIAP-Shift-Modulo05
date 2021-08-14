using Fiap.Web.AspNet.Models;
using System;
using System.Collections.Generic;

namespace Fiap.Web.AspNet.Repository
{
    public class RepresentanteRepository
    {
        private readonly IList<RepresentanteModel> listaRepresentantes;

        public RepresentanteRepository()
        {
            listaRepresentantes = new List<RepresentanteModel>
            {
                new RepresentanteModel(1, "Ana"),
                new RepresentanteModel(2, "Felipe"),
                new RepresentanteModel(3, "Tassia"),
                new RepresentanteModel(4, "Thiago")
            };
        }

        public IList<RepresentanteModel> FindAll()
        {
            Console.WriteLine($"Representante repository - FindAll");
            return listaRepresentantes;
        }

        public RepresentanteModel FindById(int id)
        {
            Console.WriteLine($"Representante repository - FindById Representante: {id}");

            if (id > listaRepresentantes.Count)
            {
                throw new Exception("Representante não encontrado");
            }
            else
            {
                return listaRepresentantes[id - 1];
            }

        }
    }
}
