using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProjetoIntegrador.Models
{
    class Parcel
    {
        public Parcel() { }

        public int id { get; set; }
        public Double price { get; set; }
        public DateTime duedate { get; set; }
        public int saleId { get; set; }
    }
}
