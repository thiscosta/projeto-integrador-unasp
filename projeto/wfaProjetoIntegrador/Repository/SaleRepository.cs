using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfaProjetoIntegrador.Models;

namespace wfaProjetoIntegrador.Repository
{
    class SaleRepository : BaseRepository<Sale, int>
    {
        public override Sale parse(IDataRecord record)
        {
            return new Sale
            {
                id = int.Parse(record["id"].ToString()),
                payment = record["payment"].ToString(),
                price = Double.Parse(record["price"].ToString()),
                serviceId = int.Parse(record["serviceId"].ToString())
            };
        }
    }
}
