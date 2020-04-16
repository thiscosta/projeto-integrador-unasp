using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProjetoIntegrador.Models
{
    public class Customer
    {
        public int id { get; set; }
        public String cpf { get; set; }
        public String name { get; set; }
        public String phone { get; set; }
        public DateTime birthdate { get; set; }
        public String email { get; set; }
        public String address1 { get; set; }
        public String address2 { get; set; }
    }
}
