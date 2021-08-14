using System;

namespace Fiap.Web.AspNet.Models
{
    public class RepresentanteModel
    {
        public int RepresentanteId { get; set; }
        public String NomeRepresentante { get; set; }

        public RepresentanteModel()
        { }

        public RepresentanteModel(
            int representanteId, 
            string nomeRepresentante)
        {
            RepresentanteId = representanteId;
            NomeRepresentante = nomeRepresentante;
        }
    }
}
