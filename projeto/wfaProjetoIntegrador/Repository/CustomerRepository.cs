using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfaProjetoIntegrador.Models;

namespace wfaProjetoIntegrador.Repository
{
    class CustomerRepository : BaseRepository<Customer, int>
    {
        public override Customer parse(IDataRecord record)
        {
            return new Customer
            {
                id = int.Parse(record["id"].ToString()),
                cpf = record["cpf"].ToString(),
                name = record["name"].ToString(),
                phone = record["phone"].ToString(),
                birthdate = Convert.ToDateTime(record["birthdate"].ToString()),
                email = record["email"].ToString(),
                address1 = record["address1"].ToString(),
                address2 = record["address2"].ToString()
            };
        }
    }
}
