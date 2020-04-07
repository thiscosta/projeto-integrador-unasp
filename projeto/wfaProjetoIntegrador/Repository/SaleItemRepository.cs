using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfaProjetoIntegrador.Models;

namespace wfaProjetoIntegrador.Repository
{
    class SaleItemRepository : BaseRepository<SaleItem, int>
    {
        public override SaleItem parse(IDataRecord record)
        {
            return new SaleItem
            {
                id = int.Parse(record["id"].ToString()),
                serviceId = int.Parse(record["serviceId"].ToString()),
                productId = int.Parse(record["productId"].ToString())
            };
        }
    }
}
