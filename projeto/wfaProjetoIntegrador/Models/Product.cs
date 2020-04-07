using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProjetoIntegrador.Models
{
    class Product
    {
        public int id { get; set; }
        public String name { get; set; }
        public Double sellPrice { get; set; }
        public String company{ get; set; }
        public int quantity{ get; set; }
        public String category { get; set; }
        public Double buyprice { get; set; }
    }
}
