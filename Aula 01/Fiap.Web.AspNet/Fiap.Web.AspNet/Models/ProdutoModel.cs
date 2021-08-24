using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.AspNet.Models
{
    public class ProdutoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Id do Produto:")]
        public int ProdutoId { get; set; }

        [Display(Name = "Nome do Produto:")]
        public String NomeProduto { get; set; }

        public ICollection<ProdutoLojaModel> ProdutoLoja { get; set; }

    }
}
