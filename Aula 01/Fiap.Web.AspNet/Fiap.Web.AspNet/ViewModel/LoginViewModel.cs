using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.ViewModel
{
    public class LoginViewModel
    {
        [Key]
        public int LoginId { get; set; }
        public String Usuario { get; set; }
        public String NomeUsuario { get; set; }
        public String Senha { get; set; }
        public String Token { get; set; }

    }
}
