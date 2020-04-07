using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfaProjetoIntegrador.Models;

namespace wfaProjetoIntegrador.Repository
{
    class ProductRepository : BaseRepository<Product, int>
    {
        public override Product parse(IDataRecord record)
        {
            return new Product
            {
                id = int.Parse(record["id"].ToString()),
                name = record["name"].ToString(),
                sellPrice = Double.Parse(record["sellPrice"].ToString()),
                company = record["company"].ToString(),
                quantity = int.Parse(record["quantity"].ToString()),
                category = record["category"].ToString(),
                buyprice = Double.Parse(record["buyprice"].ToString())
            };
        }
    }
}
