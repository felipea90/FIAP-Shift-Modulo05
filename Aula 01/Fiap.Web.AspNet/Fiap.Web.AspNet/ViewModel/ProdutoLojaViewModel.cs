using Fiap.Web.AspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.ViewModel
{
    public class ProdutoLojaViewModel
    {
        public ProdutoModel Produto { get; set; }
        
        public ICollection<int> LojaId { get; set; }
    }
}
