using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfaProjetoIntegrador.Models;

namespace wfaProjetoIntegrador.Repository
{
    class ServiceRepository : BaseRepository<Service, int>
    {
        public override Service parse(IDataRecord record)
        {
            return new Service
            {
                id = int.Parse(record["id"].ToString()),
                description = record["description"].ToString(),
                price = Double.Parse(record["price"].ToString())
            };
        }
    }
}
