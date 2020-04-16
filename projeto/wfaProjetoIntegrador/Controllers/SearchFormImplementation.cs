using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaProjetoIntegrador.Controllers
{
    class SearchFormImplementation : SearchFormInterface2
    {
        Action<int> handle;

        public SearchFormImplementation(Action<int> handle)
        {
            this.handle = handle;
        }
        public void handleSelect(int id)
        {
            handle(id);
        }
    }
}
