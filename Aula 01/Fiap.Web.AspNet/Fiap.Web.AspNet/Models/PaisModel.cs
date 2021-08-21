using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.Models
{
    public class PaisModel
    {

        public int PaisId { get; set; }

        public String NomePais { get; set; }

        public String Continente { get; set; }
    }
}
