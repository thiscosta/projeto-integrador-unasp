using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProjetoIntegrador.Models
{
    class ProductModel
    {
        public String name { get; set; }
        public String company { get; set; }
        public String category { get; set; }
        public Double purchasePrice { get; set; }
        public Double salesPrice { get; set; }
        public Double hubQuantity { get; set; }
        public String barCode { get; set; }
        public DateTime dueDate { get; set; }
    }
}
