using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.AspNet.Models
{
    public class LojaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LojaId { get; set; }
        public String NomeLoja { get; set; }

        public ICollection<ProdutoLojaModel> ProdutoLoja { get; set; }

    }
}
