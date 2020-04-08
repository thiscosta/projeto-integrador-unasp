using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfaProjetoIntegrador.Models;

namespace wfaProjetoIntegrador.Repository
{
    class ParcelRepository : BaseRepository<Parcel, int>
    {
        public override Parcel parse(IDataRecord record)
        {
            return new Parcel
            {
                id = int.Parse(record["id"].ToString()),
                price = Double.Parse(record["price"].ToString()),
                duedate = DateTime.Parse(record["duedate"].ToString()),
                saleId = int.Parse(record["saleId"].ToString())
            };
        }
    }
}
