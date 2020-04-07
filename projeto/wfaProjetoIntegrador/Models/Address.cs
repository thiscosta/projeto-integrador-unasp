using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProjetoIntegrador.Models
{
    class Address
    {
        public int id { get; set; }
        public String cep { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public String street{ get; set; }
        public int customerId { get; set; }
    }
}
