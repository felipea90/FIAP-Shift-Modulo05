using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.ViewModel
{
    public class ClienteViewModel
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }

        public ClienteViewModel()
        {
        }

        public ClienteViewModel(
            int clienteId, 
            string nome)
        {
            ClienteId = clienteId;
            Nome = nome;
        }
    }
}
