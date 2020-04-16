using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProjetoIntegrador.Models
{
    class Sale
    {
        public int id { get; set; }
        public int clientId { get; set; }
        public int serviceId { get; set; }
        public String payment { get; set; }
        public Double price { get; set; }
    }
}
