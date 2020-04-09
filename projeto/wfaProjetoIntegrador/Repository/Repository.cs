using System;
using System.Collections.Generic;
using System.Data;

namespace wfaProjetoIntegrador.Repository
{
    interface Repository<T, K>
    {
        List<T> getAll();
        bool create(T model);
        T find(K id);
        T findBy(string fieldName, dynamic value);
        T findBy(Dictionary<string, dynamic> fields, string queryOperator = "AND");
        List<T> queryBy(Dictionary<string, dynamic> fields, string queryOperator = "AND"); 
        bool update(K id, T model);
        bool delete(K id);
        T parse(IDataRecord record);

    }
}
