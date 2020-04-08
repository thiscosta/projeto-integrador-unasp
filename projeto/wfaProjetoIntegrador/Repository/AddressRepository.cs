using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfaProjetoIntegrador.Models;

namespace wfaProjetoIntegrador.Repository
{
    class AddressRepository : BaseRepository<Address, int>
    {
        public override Address parse(IDataRecord record)
        {
            return new Address
            {
                id = int.Parse(record["id"].ToString()),
                cep = record["cep"].ToString(),
                city = record["city"].ToString(),
                state = record["state"].ToString(),
                street = record["street"].ToString(),
                customerId = int.Parse(record["customerId"].ToString())
            };
        }
    }
}
