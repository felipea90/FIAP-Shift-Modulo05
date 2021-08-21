using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fiap.Web.AspNet.Models
{
    //[Table("Cidades")]
    [Index(nameof(NomeCidade), nameof(Estado))]
    public class CidadeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Column("CidadeId")]
        public int CidadeId { get; set; }

        //[Column("QuantidadeHabitantes")]
        public int QuantidadeHabitantes { get; set; }

        [NotMapped]
        public string NomePrefeito { get; set; }

        [Required]
        //[Column("NomeCidade")]
        [MaxLength(70)]
        [MinLength(2)]
        public string NomeCidade { get; set; }

        [Required]
        [MaxLength(2)]
        //[Column("UF")]
        public string Estado { get; set; }
    }
}
