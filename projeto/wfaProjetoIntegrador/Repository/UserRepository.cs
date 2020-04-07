using System.Data;
using wfaProjetoIntegrador.Models;

namespace wfaProjetoIntegrador.Repository
{
    class UserRepository : BaseRepository<Users>
    {
        public override Users parse(IDataRecord record)
        {
            return new Users
            {
                id = int.Parse(record["id"].ToString()),
                name = record["name"].ToString(),
                email = record["email"].ToString(),
                password = record["password"].ToString()
            };
        }
    }
}
