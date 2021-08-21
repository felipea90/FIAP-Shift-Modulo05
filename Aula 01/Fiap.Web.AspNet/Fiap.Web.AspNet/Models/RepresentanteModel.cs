using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fiap.Web.AspNet.Models
{
    public class RepresentanteModel
    {
        [Key]
        [Display(Name = "Id do Representante:")]
        [HiddenInput]
        public int RepresentanteId { get; set; }

        [Display(Name = "Nome do Representante:")]
        [Required]
        public String NomeRepresentante { get; set; }

        //Navigator Property
        public ICollection<ClienteModel> Clientes { get; set; }

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
