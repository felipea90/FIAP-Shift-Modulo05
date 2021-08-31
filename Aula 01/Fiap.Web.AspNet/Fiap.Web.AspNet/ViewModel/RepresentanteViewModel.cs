using Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.ViewModel
{
    public class RepresentanteViewModel
    {
        public RepresentanteViewModel()
        { }

        public RepresentanteViewModel(
            int representanteId, 
            string nomeRepresentante)
        {
            RepresentanteId = representanteId;
            NomeRepresentante = nomeRepresentante;
        }

        public int RepresentanteId { get; set; }
        public String NomeRepresentante { get; set; }
        public IList<RepresentanteViewModel> Representantes { get; set; }
        public ICollection<ClienteViewModel> Clientes { get; set; }

    }
}
