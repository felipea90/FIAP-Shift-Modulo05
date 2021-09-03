using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.ViewModel
{
    public class FornecedorViewModel
    {
        [Key]
        public int FornecedorId { get; set; }

        [Display(Name = "CNPJ: ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo CNPJ é obrigatório")]
        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$", ErrorMessage = "CNPJ no formato inválido")]
        public String Cnpj { get; set; }

        [Display(Name = "Razão Social: ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo Razão Social é obrigatório")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Informe uma Razão Social válida")]
        public String RazaoSocial { get; set; }

        [Display(Name = "Telefone: ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Campo Telefone é obrigatório")]
        public String Telefone { get; set; }

        [Display(Name = "Endereço: ")]
        public String Endereco { get; set; }

        [Display(Name = "E-mail: ")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }

        [Display(Name = "Data de Abertura: ")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataAbertura { get; set; }
        
        [Display(Name = "Valor do Capital Social: ")]
        [DataType(DataType.Currency)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:N2}")]
        public decimal ValorCapitalSocial { get; set; }

        [Display(Name = "Quantidade de Funcionários: ")]
        [Range(minimum:1, maximum:100000, ErrorMessage = "Permitido apenas entre 1 e 100.000")]
        public int QuantidadeFuncionario { get; set; }

    }
}
