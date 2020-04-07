using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProjetoIntegrador.Models
{
    class Customer
    {
        public String id { get; set; }
        public String cpf { get; set; }
        public String name { get; set; }
        public String contact { get; set; }
        public DateTime birthdate { get; set; }
        public String email { get; set; }
    }
}
