using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProjetoIntegrador.Models
{
    class BillsModel
    {
        public int id { get; set; }
        public Double price { get; set; }
        public DateTime dueDate { get; set; }
        public DateTime payDate { get; set; }
        public Double totalPrice { get; set; }
    }
}
