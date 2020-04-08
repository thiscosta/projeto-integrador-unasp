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
                contact = record["contact"].ToString(),
                birthdate = Convert.ToDateTime(record["birthdate"].ToString()),
                email = record["email"].ToString()
            };
        }
    }
}
